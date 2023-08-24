using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Infrastructure.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{    
    public class MatriculaService : IMatriculaService
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly IMatriculaAdapter _matriculaAdapter;
        private readonly IAlunoRepository _alunoRepository;
        private readonly ISessao _sessao;
        private readonly ICursoRepository _cursoRepository;
        private readonly ISecretariaAdapter _secretariaAdapter;
        public MatriculaService(
            IMatriculaRepository matriculaRepository, 
            IMatriculaAdapter matriculaAdapter, 
            IAlunoRepository alunoRepository,
            ISessao sessao,
            ICursoRepository cursoRepository,
            ISecretariaAdapter secretariaAdapter)
        {
            _matriculaRepository = matriculaRepository;
            _matriculaAdapter = matriculaAdapter;
            _alunoRepository = alunoRepository;
            _sessao = sessao;
            _cursoRepository = cursoRepository;
            _secretariaAdapter = secretariaAdapter;
        }
        public async Task<ResponseSecretariaDTO> ObterMatriculaDoAlunoPorRa(int ra)
        {
            var matricula = await _matriculaRepository.ObterMatriculaDoAlunoPorRa(ra);            
            var retorno = _secretariaAdapter.ToResponseSecretariaDTOMatriculaRa(matricula);
            return retorno;
        }
        public async Task<List<ResponseSecretariaDTO>> ObterDisciplinasDoAluno(int ra)
        {
            var disciplinas = await _matriculaRepository.ObterDisciplinasDoAluno(ra);
            List<ResponseSecretariaDTO> retorno = _secretariaAdapter.ToResponseSecretariaDTODisciplinasRa(disciplinas);
            return retorno;
        }
        public async Task<bool> MatricularAluno(RequestMatriculaDTO requestMatriculaDTO)
        {
            var toEntity = _matriculaAdapter.ToMatriculaEntity(requestMatriculaDTO);

            var sessao = _sessao.BuscarSessaoDoUsuario();
            var alunoAux = await _alunoRepository.ObterDadosDaTabelaAuxiliar(sessao.Id);
            toEntity.Ra = alunoAux.Ra;
            toEntity.IdCurso = await _cursoRepository.ObterIdDoCursoPeloNome(toEntity.NomeDoCurso);
            await _matriculaRepository.MatricularAluno(toEntity);
            return true;
        }
        public async Task<bool> RemoverMatricular(int raAluno)
        {
            await _matriculaRepository.RemoverMatricular(raAluno);
            return true;
        }
    }
}
