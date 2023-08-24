using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{
    public class MatriculaExtracurricularService : IMatriculaExtracurricularService
    {
        private readonly IMatriculaExtracurricularAdapter _matriculaExtracurricularAdapter;
        private readonly IMatriculaExtracurricularRepository _matriculaExtracurricularRepository;
        private readonly ISessao _sessao;
        private readonly IAlunoRepository _alunoRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly ISecretariaAdapter _secretariaAdapter;
        public MatriculaExtracurricularService(IMatriculaExtracurricularAdapter matriculaExtracurricularAdapter, 
            IMatriculaExtracurricularRepository matriculaExtracurricularRepository
            , ISessao sessao, IAlunoRepository alunoRepository
            , ICursoRepository cursoRepository
            , ISecretariaAdapter secretariaAdapter)
        {
            _matriculaExtracurricularAdapter = matriculaExtracurricularAdapter;
            _matriculaExtracurricularRepository = matriculaExtracurricularRepository;
            _sessao = sessao;
            _alunoRepository = alunoRepository;
            _cursoRepository = cursoRepository;
            _secretariaAdapter = secretariaAdapter;
        }
        public async Task<MatriculaEntity> MatricularAlunoCursoExtracurricular(RequestMatriculaCursosExtracurricularesDTO requestMatriculaCursosExtracurricularesDTO)
        {
            var toEntity = _matriculaExtracurricularAdapter.ToMatriculaEntityCurso(requestMatriculaCursosExtracurricularesDTO);
            var sessao = _sessao.BuscarSessaoDoUsuario();
            var alunoAux = await _alunoRepository.ObterDadosDaTabelaAuxiliar(sessao.Id);
            toEntity.Ra = alunoAux.Ra;
            toEntity.IdCurso = await _cursoRepository.ObterIdDoCursoPeloNome(requestMatriculaCursosExtracurricularesDTO.NomeDoCurso);
            await _matriculaExtracurricularRepository.MatricularAlunoCursoExtracurricular(toEntity);
            await _alunoRepository.LimparTabelaAuxiliar(sessao.Id, alunoAux.Ra);
            return toEntity;
        }

        public async Task<List<ResponseSecretariaDTO>> ObterDisciplinasExtracurricularDoAluno(int ra)
        {
            var disciplinas = await _matriculaExtracurricularRepository.ObterDisciplinasExtracurricularDoAluno(ra);
            List<ResponseSecretariaDTO> retorno = _secretariaAdapter.ToResponseSecretariaDTODisciplinasRa(disciplinas);
            return retorno;
        }

        public async Task<ResponseSecretariaDTO> ObterMatriculaExtracurricularDoAlunoPorRa(int ra)
        {
            var matricula = await _matriculaExtracurricularRepository.ObterMatriculaExtracurricularDoAlunoPorRa(ra);
            var retorno = _secretariaAdapter.ToResponseSecretariaDTOMatriculaExtracuirricularRa(matricula);
            return retorno;
        }
    }
}
