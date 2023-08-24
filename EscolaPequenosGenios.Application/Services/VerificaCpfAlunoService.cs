using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Infrastructure.Interfaces;

namespace EscolaPequenosGenios.Application.Services
{
    
    public class VerificaCpfAlunoService : IVerificaCpfAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public VerificaCpfAlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<bool> VerificaCpfAluno(string cpfAluno)
        {
            var existeCpf = await _alunoRepository.VerificaAlunoCpf(cpfAluno);
            return string.IsNullOrEmpty(existeCpf);
        }
    }
}
