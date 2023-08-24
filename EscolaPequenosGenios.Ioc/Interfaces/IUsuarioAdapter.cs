using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IUsuarioAdapter
    {
        public UsuarioEntity ToUsuarioEntity(GetUsuarioDTO getUsuarioDTO);
        public UsuarioEntity ToUsuarioEntityRequest(RequestUsuarioDTO requestUsuarioDTO);
    }
}
