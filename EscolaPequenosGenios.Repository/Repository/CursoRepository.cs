using Dapper;
using EscolaPequenosGenios.Infrastructure.Context.Scripts;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using EscolaPequenosGenios.Repository.Context;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EscolaPequenosGenios.Infrastructure.Repository
{
    public class CursoRepository : ICursoRepository
    {
        private readonly IConexao _conexao;
        public CursoRepository(IConexao conexao, EscolaPequenosGeniosContext context)
        {
            _conexao = conexao;        
        }
        public List<string> ObterCursos()
        {

            using var cn = new SqlConnection(_conexao.StringConexao);
            cn.Open();
            var cursos = cn.Query<string>(CursoScript.ObterNomeDeTodosOsCursos);
            return cursos.ToList();
        }

        public async Task<int> ObterIdDoCursoPeloNome(string nomeDoCurso)
        {
            var p = new DynamicParameters();
            p.Add("@NomeDoCurso", nomeDoCurso, DbType.String);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            var idCurso = await cn.QueryFirstOrDefaultAsync<int>(CursoScript.ObterIdDoCursoPorNome, p);
            return idCurso;
        }
    }
}
