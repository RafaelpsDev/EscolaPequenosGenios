using Dapper;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Context.Scripts;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EscolaPequenosGenios.Infrastructure.Repository
{
    public class MatriculaExtracurricularRepository : IMatriculaExtracurricularRepository
    {
        private readonly IConexao _conexao;
        public MatriculaExtracurricularRepository(IConexao conexao)
        {
            _conexao = conexao;
        }
        public async Task<MatriculaEntity> MatricularAlunoCursoExtracurricular(MatriculaEntity matriculaEntity)
        {
            var p = new DynamicParameters();
            p.Add("@NomeDoCurso", matriculaEntity.NomeDoCurso, DbType.String);
            p.Add("@Ra", matriculaEntity.Ra, DbType.Int32);

            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            await cn.ExecuteAsync(MatriculaCursoExtracurricularScript.InsereAlunoCursoExtracurricular, p);
            return matriculaEntity;

        }

        public async Task<List<string>> ObterDisciplinasExtracurricularDoAluno(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);

            await cn.OpenAsync();
            var retorno = await cn.QueryAsync<string>(MatriculaCursoExtracurricularScript.ObterDisciplinasExtracurricularDaMatriculaPorRa, p);
            return retorno.ToList();
        }

        public async Task<MatriculaEntity> ObterMatriculaExtracurricularDoAlunoPorRa(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);

            await cn.OpenAsync();
            var retorno = await cn.QueryFirstAsync<MatriculaEntity>(MatriculaCursoExtracurricularScript.ObterMatriculaExtracurricularDoAlunoPeloRa, p);
            return retorno;
        }
    }
}
