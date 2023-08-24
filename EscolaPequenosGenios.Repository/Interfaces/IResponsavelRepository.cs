using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IResponsavelRepository
    {
        Task<bool> InsereResponsavel(ResponsavelEntity responsavelEntity);
        Task<bool> RemoveResponsavel(int raAluno);
        Task<ResponsavelEntity> ObterResponsavelPeloRaDoAluno(int ra);

    }
}
