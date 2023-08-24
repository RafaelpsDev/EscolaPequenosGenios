using Dapper;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Context.Scripts;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EscolaPequenosGenios.Infrastructure.Repository
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly IConexao _conexao;

        public MatriculaRepository(IConexao conexao)
        {
            _conexao = conexao;
        }
        public async Task<bool> MatricularAluno(MatriculaEntity matriculaEntity)
        {
            using var cn = new SqlConnection(_conexao.StringConexao);
            var p = new DynamicParameters();
            p.Add("@Ra", matriculaEntity.Ra, DbType.Int32);
            p.Add("@IdCurso", matriculaEntity.IdCurso, DbType.Int32);
            p.Add("@Turno", matriculaEntity.Turno, DbType.String);
            p.Add("@Serie", matriculaEntity.Serie, DbType.Int32);

            await cn.OpenAsync();

            await cn.QueryAsync(MatriculaScript.InsereAlunoNaMatricula, p);
            return true;            
        }
        public async Task<List<string>> ObterDisciplinasDoAluno(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);

            await cn.OpenAsync();
            var retorno = await cn.QueryAsync<string>(MatriculaScript.ObterDisciplinasDaMatriculaPorRa, p);            
            return retorno.ToList();
        }

        public async Task<MatriculaEntity> ObterMatriculaDoAlunoPorRa(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);

            await cn.OpenAsync();
            var retorno = await cn.QueryFirstAsync<MatriculaEntity>(MatriculaScript.ObterMatriculaDoAlunoPeloRa, p);            
            return retorno;
        }

        public async Task<bool> RemoverMatricular(int raAluno)
        {
            var p = new DynamicParameters();
            p.Add("@raAluno", raAluno, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);

            await cn.OpenAsync();
            await cn.ExecuteAsync(MatriculaScript.RemoverMatricula, p);
            return true;
        }
    }
}
