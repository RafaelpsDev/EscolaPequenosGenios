using Dapper;
using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface IParametrosAlunoRepository
    {
        public DynamicParameters ParametrosTransacoesAluno(AlunoEntity alunoEntity);
        public DynamicParameters ParametrosObterDadosDaTabelaAuxiliar(int idSessao);
        public DynamicParameters ParametrosPopularTabelaAuxiliarMatricula(int idSessao, int raAluno);
        public DynamicParameters ParametrosVerificaAlunoCpf(string cpf);
        public DynamicParameters ParametrosLimparTabelaAuxiliar(int idSessao, int raAluno);
        public DynamicParameters ParametrosRemoverAluno(int raAluno);
    }
}
