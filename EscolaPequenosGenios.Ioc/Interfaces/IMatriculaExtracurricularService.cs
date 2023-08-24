using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IMatriculaExtracurricularService
    {
        Task<MatriculaEntity> MatricularAlunoCursoExtracurricular(RequestMatriculaCursosExtracurricularesDTO requestMatriculaCursosExtracurricularesDTO);
        Task<ResponseSecretariaDTO> ObterMatriculaExtracurricularDoAlunoPorRa(int ra);
        Task<List<ResponseSecretariaDTO>> ObterDisciplinasExtracurricularDoAluno(int ra);
    }
}
