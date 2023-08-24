using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Helpers;
using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Infrastructure.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioAdapter _usuarioAdapter;
        
        
        public UsuarioService(IUsuarioRepository usuarioRepository, IUsuarioAdapter usuarioAdapter)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioAdapter = usuarioAdapter;
        }

        public async Task<UsuarioEntity> CriarUsuario(RequestUsuarioDTO requestUsuarioDTO)
        {
            var toEntity = _usuarioAdapter.ToUsuarioEntityRequest(requestUsuarioDTO);
            var usuario = await _usuarioRepository.ObterUsuarioPorCpf(toEntity);
            if (usuario != null) throw new Exception($"O Usuario informado já existe: Usuário: {usuario.Usuario}, Cpf: {usuario.Cpf}");

            toEntity.Usuario = toEntity.Cpf[..6];
            toEntity.Senha = FuncaoCriptografiaDeSenha.CriptografarSenha(toEntity.Senha);
            var retorno = await _usuarioRepository.CriarUsuario(toEntity);
            return retorno;
        }

        public async Task<UsuarioEntity> ObterUsuario(GetUsuarioDTO getUsuarioDTO)
        {
            getUsuarioDTO.Senha = FuncaoCriptografiaDeSenha.CriptografarSenha(getUsuarioDTO.Senha);
            var toEntity = _usuarioAdapter.ToUsuarioEntity(getUsuarioDTO);
            var usuario = await _usuarioRepository.ObterUsuario(toEntity) ?? throw new NullReferenceException("O Usuário informado não existe");

            if (usuario.Senha != getUsuarioDTO.Senha)
            {
                throw new ArgumentException("A senha informada é incorreta");
            }

            return usuario;
        }
    }
}
