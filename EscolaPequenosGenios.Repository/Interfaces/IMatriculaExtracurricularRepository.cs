using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IMatriculaExtracurricularRepository
    {
        Task<MatriculaEntity> MatricularAlunoCursoExtracurricular(MatriculaEntity matriculaEntity);
        Task<MatriculaEntity> ObterMatriculaExtracurricularDoAlunoPorRa(int ra);
        Task<List<string>> ObterDisciplinasExtracurricularDoAluno(int ra);
    }
}
