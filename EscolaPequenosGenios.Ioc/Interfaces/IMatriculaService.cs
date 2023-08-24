using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IMatriculaService
    {
        Task<bool> MatricularAluno(RequestMatriculaDTO requestMatriculaDTO);
        Task<ResponseSecretariaDTO> ObterMatriculaDoAlunoPorRa(int ra);
        Task<List<ResponseSecretariaDTO>> ObterDisciplinasDoAluno(int ra);
        Task<bool> RemoverMatricular(int raAluno);
    }
}
