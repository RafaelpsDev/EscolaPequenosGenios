using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioEntity> ObterUsuario(GetUsuarioDTO getUsuarioDTO);
        Task<UsuarioEntity> CriarUsuario(RequestUsuarioDTO requestUsuarioDTO);
    }
}
