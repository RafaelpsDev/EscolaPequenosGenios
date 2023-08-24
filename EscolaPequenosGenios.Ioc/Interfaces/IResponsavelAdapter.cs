using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IResponsavelAdapter
    {
        public ResponsavelEntity ToResponsavelEntity(RequestResponsavelDTO requestResponsavelDTO);
        public ResponseResponsavelDTO ToResponseResponsavelDTO(ResponsavelEntity responsavelEntity);

    }
}
