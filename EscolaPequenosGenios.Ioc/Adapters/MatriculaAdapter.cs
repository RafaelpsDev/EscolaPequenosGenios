using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.IoC.Adapters
{
    public class MatriculaAdapter : IMatriculaAdapter
    {
        public MatriculaEntity ToMatriculaEntity(RequestMatriculaDTO requestMatriculaDTO)
        {
            return new MatriculaEntity
            {
                NomeDoCurso = requestMatriculaDTO.NomeDoCurso,
                Turno = requestMatriculaDTO.Turno,
                Serie = requestMatriculaDTO.Serie
            };
        }
    }
}
