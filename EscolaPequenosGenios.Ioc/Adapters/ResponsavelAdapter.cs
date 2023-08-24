using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.IoC.Adapters
{
    public class ResponsavelAdapter : IResponsavelAdapter
    {
        public ResponsavelEntity ToResponsavelEntity(RequestResponsavelDTO requestResponsavelDTO)
        {
            return new ResponsavelEntity
            {
                Nome = requestResponsavelDTO.Nome,
                Cpf = requestResponsavelDTO.Cpf,
                Ddd = requestResponsavelDTO.Ddd,
                Telefone = requestResponsavelDTO.Telefone,
                Email = requestResponsavelDTO.Email
            };
        }

        public ResponseResponsavelDTO ToResponseResponsavelDTO(ResponsavelEntity responsavelEntity)
        {
            return new ResponseResponsavelDTO
            {
                Nome = responsavelEntity.Nome,
                Cpf = responsavelEntity.Cpf,
                Ddd = responsavelEntity.Ddd,
                Telefone = responsavelEntity.Telefone,
                Email = responsavelEntity.Email
            };
        }
    }
}
