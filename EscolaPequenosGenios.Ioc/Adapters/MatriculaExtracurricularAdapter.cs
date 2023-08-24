using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.IoC.Adapters
{
    public class MatriculaExtracurricularAdapter : IMatriculaExtracurricularAdapter
    {
        public MatriculaEntity ToMatriculaEntityCurso(RequestMatriculaCursosExtracurricularesDTO requestMatriculaCursosExtracurricularesDTO)
        {
            return new MatriculaEntity
            {
                NomeDoCurso = requestMatriculaCursosExtracurricularesDTO.NomeDoCurso
            };
        }
    }
}
