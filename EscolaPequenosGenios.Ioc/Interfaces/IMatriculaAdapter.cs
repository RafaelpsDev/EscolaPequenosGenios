using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IMatriculaAdapter
    {
        public MatriculaEntity ToMatriculaEntity(RequestMatriculaDTO requestMatriculaDTO);        
    }
}
