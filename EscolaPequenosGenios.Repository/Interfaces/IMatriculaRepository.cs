using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IMatriculaRepository
    {
        Task<bool> MatricularAluno(MatriculaEntity matriculaEntity);
        Task<bool> RemoverMatricular(int raAluno);
        Task<MatriculaEntity> ObterMatriculaDoAlunoPorRa(int ra);
        Task<List<string>> ObterDisciplinasDoAluno(int ra);

    }
}
