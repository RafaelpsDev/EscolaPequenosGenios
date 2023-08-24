using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IResponsavelService
    {
        Task<bool> InsereResponsavel(RequestResponsavelDTO requestResponsavelDTO);
        Task<ResponseSecretariaDTO> ObterResponsavelPeloRaDoAluno(int ra);
        Task<bool> RemoveResponsavel(int raAluno);
    }
}
