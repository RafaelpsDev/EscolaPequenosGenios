using EscolaPequenosGenios.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EscolaPequenosGenios.Infrastructure.Context.DapperConnection
{
    public class Conexao : IConexao
    {
        private readonly IConfiguration _configuration;
        public Conexao(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string StringConexao => _configuration.GetConnectionString("ConexaoPadrao");
    }
}
