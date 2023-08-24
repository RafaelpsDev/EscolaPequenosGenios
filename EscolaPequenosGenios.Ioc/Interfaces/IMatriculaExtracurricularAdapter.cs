using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IMatriculaExtracurricularAdapter
    {
        public MatriculaEntity ToMatriculaEntityCurso(RequestMatriculaCursosExtracurricularesDTO requestMatriculaCursosExtracurricularesDTO);
    }
}
