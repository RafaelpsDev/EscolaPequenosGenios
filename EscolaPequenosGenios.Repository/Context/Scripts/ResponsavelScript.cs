
namespace EscolaPequenosGenios.Infrastructure.Context.Scripts
{
    public class ResponsavelScript
    {
        public static string InsereResponsavel
        {
            get
            {
                return @"INSERT INTO TB_RESPONSAVEIS VALUES (@Nome, @Cpf, @Ddd, @Telefone, @Email, @RaAluno)";
            }
        }
        public static string ObterResponsavel
        {
            get
            {
                return @"SELECT * FROM TB_RESPONSAVEIS WHERE RA = @Ra";
            }
        }
        public static string RemoverResponsavel
        {
            get
            {
                return @"DELETE TB_RESPONSAVEIS where RA = @raAluno";
            }
        }
    }
}
