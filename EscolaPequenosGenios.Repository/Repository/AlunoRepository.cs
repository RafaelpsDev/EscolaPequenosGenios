using Dapper;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Context.Scripts;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EscolaPequenosGenios.Repository.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly IConexao _conexao;  
        private readonly IParametrosAlunoRepository _parametrosRepository;

        public AlunoRepository(IConexao conexao, IParametrosAlunoRepository parametrosRepository)
        {
            _conexao = conexao;            
            _parametrosRepository = parametrosRepository;
        }
        public async Task<AlunoEntity> ObterRaDoAluno(int ra)
        {
            var p = new DynamicParameters();
            p.Add("@Ra", ra, DbType.Int32);
            using var connection = new SqlConnection(_conexao.StringConexao);
            await connection.OpenAsync();
            var retorno = await connection.QueryFirstAsync<AlunoEntity>(AlunoScript.ObterRaDoAluno, p);
            return retorno;
        }        
        public async Task<AlunoEntity> ObterDadosDoAlunoPorRa(int ra)
        {
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            var aluno = await cn.QueryFirstOrDefaultAsync<AlunoEntity>(AlunoScript.ObterAlunoPorRa, new {Ra = ra});
            return aluno;
        }             
        public async Task<AlunoEntity> ObterDadosDaTabelaAuxiliar(int idSessao)
        {
            DynamicParameters p = _parametrosRepository.ParametrosObterDadosDaTabelaAuxiliar(idSessao);
            using var connection = new SqlConnection(_conexao.StringConexao);
            await connection.OpenAsync();
            var retorno = await connection.QueryFirstAsync<AlunoEntity>(AlunoScript.ObterDadosAuxiliarMatricula, p);
            return retorno;
        }             
        public async Task<AlunoEntity> InserirAluno(AlunoEntity alunoEntity)
        {
                DynamicParameters p = _parametrosRepository.ParametrosTransacoesAluno(alunoEntity);
                using var cn = new SqlConnection(_conexao.StringConexao);
                await cn.OpenAsync();
                await cn.ExecuteAsync(AlunoScript.InsereAluno, p);
                return await ObterDadosDoAlunoPorRa(alunoEntity.Ra);            
        }

        public async Task<string> GeraComplementoRa()
        {
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();

            var ra = Convert.ToString(await cn.ExecuteScalarAsync(AlunoScript.ComplementoRa));
            return ra;
        }
        public async Task<bool> LimparTabelaAuxiliar(int idSessao, int raAluno)
        {
            DynamicParameters p = _parametrosRepository.ParametrosLimparTabelaAuxiliar(idSessao, raAluno);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            await cn.ExecuteAsync(AlunoScript.LimparAuxiliarMatricula, p);
            return true;
        }
        public async Task<string> VerificaAlunoCpf(string cpf)
        {
            DynamicParameters p = _parametrosRepository.ParametrosVerificaAlunoCpf(cpf);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            var retorno = Convert.ToString(await cn.ExecuteScalarAsync(AlunoScript.VerificaCpfAluno, p));
            return retorno;
        }
        public async Task<bool> PopularTabelaAuxiliarMatricula(int idSessao, int raAluno)
        {
            DynamicParameters p = _parametrosRepository.ParametrosPopularTabelaAuxiliarMatricula(idSessao, raAluno);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            await cn.ExecuteAsync(AlunoScript.PopulaAuxiliarMatricula, p);
            return true;
        }

        public async Task<bool> RemoverAluno(int raAluno)
        {
            DynamicParameters p = _parametrosRepository.ParametrosRemoverAluno(raAluno);
            using var cn = new SqlConnection(_conexao.StringConexao);
            await cn.OpenAsync();
            await cn.ExecuteAsync(AlunoScript.RemoverAluno, p);
            return true;
        }
    }
}
