using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.IoC.Adapters
{
    public class UsuarioAdapter : IUsuarioAdapter
    {
        public UsuarioEntity ToUsuarioEntity(GetUsuarioDTO getUsuarioDTO)
        {
            return new UsuarioEntity
            {
                Usuario = getUsuarioDTO.Usuario,
                Senha = getUsuarioDTO.Senha
            };
        }

        public UsuarioEntity ToUsuarioEntityRequest(RequestUsuarioDTO requestUsuarioDTO)
        {
            return new UsuarioEntity
            {
                Cpf = requestUsuarioDTO.Cpf,
                Nome = requestUsuarioDTO.Nome,
                Senha = requestUsuarioDTO.Senha,
                Setor = requestUsuarioDTO.Setor
            };
        }
    }
}
