using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{
    public class LimpaTabelasService : ILimpaTabelasService
    {
        private readonly IAlunoService _alunoService;
        private readonly IResponsavelService _responsavelService;
        private readonly IMatriculaService _matriculaService;
        public LimpaTabelasService(IAlunoService alunoService, IResponsavelService responsavelService, IMatriculaService matriculaService)
        {
            _alunoService = alunoService;
            _responsavelService = responsavelService;
            _matriculaService = matriculaService;

        }
        public async Task<bool> LimparTabelas(int idSessao, int raAluno)
        {
            var responsavel = await _responsavelService.ObterResponsavelPeloRaDoAluno(raAluno);
            if(responsavel != null) { await _responsavelService.RemoveResponsavel(raAluno); }

            var matricula = await _matriculaService.ObterMatriculaDoAlunoPorRa(raAluno);
            if (matricula != null) { await _matriculaService.RemoverMatricular(raAluno); }

            var aluno = await _alunoService.ObterRaDoAluno(raAluno);
            if (aluno != null) { await _alunoService.RemoverAluno(raAluno); }
            
            await _alunoService.LimparTabelaAuxiliar(idSessao, raAluno);
            return true;

        }
    }
}
