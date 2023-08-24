using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IAlunoRepository
    {
        Task<AlunoEntity> ObterDadosDaTabelaAuxiliar(int idSessao);
        Task<AlunoEntity> ObterDadosDoAlunoPorRa(int ra);
        Task<AlunoEntity> ObterRaDoAluno(int ra);
        Task<string> GeraComplementoRa();
        Task<AlunoEntity> InserirAluno(AlunoEntity alunoEntity);
        Task<string> VerificaAlunoCpf(string cpf);
        Task<bool> RemoverAluno(int raAluno);
        Task<bool> PopularTabelaAuxiliarMatricula(int idSessao, int raAluno);
        Task<bool> LimparTabelaAuxiliar(int idSessao, int raAluno);        
    }
}
