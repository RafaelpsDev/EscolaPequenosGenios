using Dapper;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using System.Data;

namespace EscolaPequenosGenios.Infrastructure.Repository
{
    public class ParametrosAlunoRepository : IParametrosAlunoRepository
    {
        private readonly DynamicParameters p;
        public ParametrosAlunoRepository()
        {
            p = new DynamicParameters();
        }
        public DynamicParameters ParametrosTransacoesAluno(AlunoEntity alunoEntity)
        {
            p.Add("@Ra", alunoEntity.Ra, DbType.Int32);
            p.Add("@Nome", alunoEntity.Nome, DbType.String);
            p.Add("@Cpf", alunoEntity.Cpf, DbType.String);
            p.Add("@Mae", alunoEntity.Mae, DbType.String);
            p.Add("@Pai", alunoEntity.Pai, DbType.String);
            p.Add("@Sexo", alunoEntity.Sexo, DbType.String);
            p.Add("@Ddd", alunoEntity.Ddd, DbType.String);
            p.Add("@Telefone", alunoEntity.Telefone, DbType.String);
            p.Add("@Email", alunoEntity.Email, DbType.String);
            p.Add("@Cep", alunoEntity.Cep, DbType.String);
            p.Add("@Logradouro", alunoEntity.Logradouro, DbType.String);
            p.Add("@Numero", alunoEntity.Numero, DbType.Int32);
            p.Add("@Complemento", alunoEntity.Complemento, DbType.String);
            p.Add("@Cidade", alunoEntity.Cidade, DbType.String);
            p.Add("@Uf", alunoEntity.Uf, DbType.String);
            return p;
        }

        public DynamicParameters ParametrosObterDadosDaTabelaAuxiliar(int idSessao)
        {
            p.Add("@idSessao", idSessao, DbType.Int32);
            return p;
        }

        public DynamicParameters ParametrosPopularTabelaAuxiliarMatricula(int idSessao, int raAluno)
        {
            p.Add("@idSessao", idSessao, DbType.Int32);
            p.Add("@raAluno", raAluno, DbType.Int32);
            return p;
        }

        public DynamicParameters ParametrosVerificaAlunoCpf(string cpf)
        {
            p.Add("@Cpf", cpf, DbType.String);
            return p;
        }

        public DynamicParameters ParametrosLimparTabelaAuxiliar(int idSessao, int raAluno)
        {
            p.Add("@idSessao", idSessao, DbType.Int32);
            p.Add("@raAluno", raAluno, DbType.Int32);
            return p;
        }

        public DynamicParameters ParametrosRemoverAluno(int raAluno)
        {
            p.Add("@raAluno", raAluno, DbType.Int32);
            return p;
        }
    }
}
