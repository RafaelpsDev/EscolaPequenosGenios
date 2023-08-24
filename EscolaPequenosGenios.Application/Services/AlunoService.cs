using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Helpers;
using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using System.Data;

namespace EscolaPequenosGenios.Application.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoAdapter _alunoAdapter;
        private readonly ISecretariaAdapter _secretariaAdapter;
        private readonly IAlunoRepository _alunoRepository;
        private readonly ISessao _sessao;

        public AlunoService(IAlunoAdapter alunoAdapter, IAlunoRepository alunoRepository, ISessao sessao, ISecretariaAdapter secretariaAdapter)
        {
            _alunoAdapter = alunoAdapter;
            _alunoRepository = alunoRepository;
            _sessao = sessao;
            _secretariaAdapter = secretariaAdapter;

        }
        public async Task<ResponseSecretariaDTO> ObterRaDoAluno(int ra)
        {
            var aluno = await _alunoRepository.ObterRaDoAluno(ra);
            var retorno = _secretariaAdapter.ToResponseSecretariaDTOAlunoRa(aluno);
            return retorno;
        }
        public async Task<ResponseSecretariaDTO> RetornoAluno(int ra)
        {
            var aluno = await _alunoRepository.ObterDadosDoAlunoPorRa(ra);
            var retorno = _secretariaAdapter.ToResponseSecretariaDTOAluno(aluno);
            return retorno;
        }
        public async Task<ResponseTabelaAuxiliarDTO> ObterDadosDaTabelaAuxiliar(int idSessao)
        {
            var dados = await _alunoRepository.ObterDadosDaTabelaAuxiliar(idSessao);
            var retorno = _alunoAdapter.ToResponseTabelaAuxiliarDTO(dados);
            return retorno;
        }        
        public async Task<AlunoEntity> InsereAluno(RequestAlunoDTO requestAlunoDTO)
        {
            requestAlunoDTO.Cpf = requestAlunoDTO.Cpf.Replace("-", "").Replace(".", "");
            var complementoRa = await GeraComplementoRa();
            var aluno = _alunoAdapter.ToAlunoEntity(requestAlunoDTO);
            aluno.Ra = FuncaoFormatacaoRa.GerarValorInteiroGenérico(aluno.Cpf, complementoRa);
            var retorno = await _alunoRepository.InserirAluno(aluno);
            var sessao = _sessao.BuscarSessaoDoUsuario();
            await PopularTabelaAuxiliarMatricula(sessao.Id, aluno.Ra);
            return retorno;
        }
        public Task<string> GeraComplementoRa()
        {
            return _alunoRepository.GeraComplementoRa();
        }
        public async Task<bool> PopularTabelaAuxiliarMatricula(int idSessao, int raAluno)
        {
            await _alunoRepository.PopularTabelaAuxiliarMatricula(idSessao, raAluno);
            return true;
        }

        public async Task<bool> RemoverAluno(int raAluno)
        {
            await _alunoRepository.RemoverAluno(raAluno);
            return true;
        }

        public async Task<bool> LimparTabelaAuxiliar(int idSessao, int raAluno)
        {
            await _alunoRepository.LimparTabelaAuxiliar(idSessao, raAluno);
            return true;
        }
    }
}
