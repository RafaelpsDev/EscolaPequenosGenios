using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IHistoricoRepository
    {
        Task<List<HistoricoEntity>> ObterHistoricoDoAluno(int ra);
    }
}
