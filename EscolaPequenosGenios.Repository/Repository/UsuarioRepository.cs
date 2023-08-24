using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using EscolaPequenosGenios.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaPequenosGenios.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EscolaPequenosGeniosContext _context;
        public UsuarioRepository(EscolaPequenosGeniosContext context)
        {
            _context = context;
        }

        public async Task<UsuarioEntity> CriarUsuario(UsuarioEntity usuarioEntity)
        {            
            await _context.TB_USUARIOS.AddAsync(usuarioEntity);
            await _context.SaveChangesAsync();
            return usuarioEntity;
        }

        public async Task<UsuarioEntity> ObterUsuario(UsuarioEntity usuarioEntity)
        {
            var retorno = await _context.TB_USUARIOS.FirstOrDefaultAsync(u => u.Usuario == usuarioEntity.Usuario);
            return retorno;
        }

        public async Task<UsuarioEntity> ObterUsuarioPorCpf(UsuarioEntity usuarioEntity)
        {
            var retorno = await _context.TB_USUARIOS.FirstOrDefaultAsync(u => u.Cpf == usuarioEntity.Cpf);
            return retorno;
        }
    }
}
