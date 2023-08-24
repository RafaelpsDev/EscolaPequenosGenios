using Dapper;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Context.Scripts;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EscolaPequenosGenios.Infrastructure.Repository
{    
    public class ResponsavelRepository : IResponsavelRepository
    {
        private readonly IConexao _conexao;

        public ResponsavelRepository(IConexao conexao)
        {
            _conexao = conexao;
        }
        public async Task<bool> InsereResponsavel(ResponsavelEntity responsavelEntity)
        {
                using var cn = new SqlConnection(_conexao.StringConexao);
                await cn.OpenAsync();
                await cn.ExecuteAsync(ResponsavelScript.InsereResponsavel, responsavelEntity);
                return true;
        }

        public async Task<ResponsavelEntity> ObterResponsavelPeloRaDoAluno(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            return await cn.QueryFirstOrDefaultAsync<ResponsavelEntity>
                (ResponsavelScript.ObterResponsavel, p);            
        }

        public async Task<bool> RemoveResponsavel(int raAluno)
        {
            var p = new DynamicParameters();
            p.Add("@raAluno", raAluno, DbType.Int32);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            await cn.ExecuteAsync(ResponsavelScript.RemoverResponsavel, p);
            return true;
        }
    }
}
