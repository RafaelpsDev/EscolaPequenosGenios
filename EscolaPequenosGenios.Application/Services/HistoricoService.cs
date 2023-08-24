using EscolaPequenosGenios.Infrastructure.Interfaces;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{
    public class HistoricoService : IHistoricoService
    {
        private readonly IHistoricoRepository _historicoRepository;
        private readonly ISecretariaAdapter _secretariaAdapter;
        public HistoricoService(IHistoricoRepository historicoRepository, ISecretariaAdapter secretariaAdapter)
        {
            _historicoRepository = historicoRepository;
            _secretariaAdapter = secretariaAdapter;
        }
        public async Task<List<ResponseSecretariaDTO>> ObterHistoricoDoAluno(int ra)
        {
            var historico = await _historicoRepository.ObterHistoricoDoAluno(ra);
            var toResponse = _secretariaAdapter.ToResponseSecretariaDTOHistorico(historico);
            return toResponse;
        }
    }
}
