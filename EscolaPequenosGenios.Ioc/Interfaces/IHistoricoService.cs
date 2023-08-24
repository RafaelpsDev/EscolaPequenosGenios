using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IHistoricoService
    {
        Task<List<ResponseSecretariaDTO>> ObterHistoricoDoAluno(int ra);
    }
}
