using Dapper;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Context.Scripts;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;


namespace EscolaPequenosGenios.Infrastructure.Repository
{
    public class HistoricoRepository : IHistoricoRepository
    {
        private readonly IConexao _conexao;
        public HistoricoRepository(IConexao conexao)
        {
            _conexao = conexao;
        }
        public async Task<List<HistoricoEntity>> ObterHistoricoDoAluno(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);

            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();

            var historico = await cn.QueryAsync<HistoricoEntity>(HistoricoScript.ObterHistoricoDoAluno, p);
            return historico.ToList();


        }
    }
}
