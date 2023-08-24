using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioEntity> ObterUsuario(UsuarioEntity usuarioEntity);
        Task<UsuarioEntity> ObterUsuarioPorCpf(UsuarioEntity usuarioEntity);
        Task<UsuarioEntity> CriarUsuario(UsuarioEntity usuarioEntity);
    }
}
