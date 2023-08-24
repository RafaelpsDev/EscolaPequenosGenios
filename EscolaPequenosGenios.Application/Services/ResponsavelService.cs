using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Infrastructure.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{
    public class ResponsavelService : IResponsavelService
    {
        private readonly IResponsavelRepository _responsavelRepository;
        private readonly IResponsavelAdapter _responsavelAdapter;
        private readonly ISessao _sessao;
        private readonly IAlunoRepository _alunoRepository;
        private readonly ISecretariaAdapter _secretariaAdapter;
        public ResponsavelService(
            IResponsavelRepository responsavelRepository, 
            IResponsavelAdapter responsavelAdapter, 
            ISessao sessao, 
            IAlunoRepository alunoRepository,
            ISecretariaAdapter secretariaAdapter)
        {
            _responsavelRepository = responsavelRepository;
            _responsavelAdapter = responsavelAdapter;
            _sessao = sessao;
            _alunoRepository = alunoRepository;
            _secretariaAdapter = secretariaAdapter;

        }
        public async Task<bool> InsereResponsavel(RequestResponsavelDTO requestResponsavelDTO)
        {
            var respToEntity = _responsavelAdapter.ToResponsavelEntity(requestResponsavelDTO);
            var sessao = _sessao.BuscarSessaoDoUsuario();
            var alunoAux = await _alunoRepository.ObterDadosDaTabelaAuxiliar(sessao.Id);
            respToEntity.RaAluno = alunoAux.Ra;
            await _responsavelRepository.InsereResponsavel(respToEntity);
            return true;
        }
        public async Task<ResponseSecretariaDTO> ObterResponsavelPeloRaDoAluno(int ra)
        {
            var responsavel = await _responsavelRepository.ObterResponsavelPeloRaDoAluno(ra);
            var retorno = _secretariaAdapter.ToResponseSecretariaDTOResponsavel(responsavel);
            return retorno;
        }

        public async Task<bool> RemoveResponsavel(int raAluno)
        {
            await _responsavelRepository.RemoveResponsavel(raAluno);
            return true;
        }
    }
}
