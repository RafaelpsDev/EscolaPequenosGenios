
namespace EscolaPequenosGenios.Infrastructure.Context.Scripts
{
    public class AlunoScript
    {
       public static string PopulaAuxiliarMatricula
        {
            get
            {
                return @"INSERT INTO TB_AUXILIAR_MATRICULA (ID_SESSAO, RA_ALUNO) VALUES (@idSessao, @raAluno)";
            }
        }

        public static string InsereAluno
        {
            get
            {
                return @"INSERT INTO TB_ALUNOS VALUES(@Ra, @Nome, @Cpf, @Mae, @Pai, @Sexo, @Ddd, @Telefone, @Email, @Cep, @Logradouro, @Numero, @Complemento, @Cidade, @Uf, 'Ativo')";
            }
        }        
        public static string ObterAlunoPorRa
        {
            get
            {
                return @"SELECT * FROM TB_ALUNOS WHERE RA = @Ra";
            }
        }
        public static string RemoverAluno
        {
            get
            {
                return @"DELETE TB_ALUNOS WHERE RA = @raAluno";
            }
        }

        public static string ObterDadosAuxiliarMatricula
        {
            get
            {
                return @"SELECT RA_ALUNO as Ra FROM TB_AUXILIAR_MATRICULA WHERE ID_SESSAO = @idSessao";
            }
        }
        public static string LimparAuxiliarMatricula
        {
            get
            {
                return @"DELETE TB_AUXILIAR_MATRICULA WHERE ID_SESSAO = @idSessao AND RA_ALUNO = @raAluno";
            }
        }
        public static string ComplementoRa
        {
            get { return "SELECT LEFT(ABS(CHECKSUM(NEWID())), 5)"; }
        }
        public static string VerificaCpfAluno
        {
            get
            {
                return "SELECT CPF FROM TB_ALUNOS WHERE CPF = @Cpf";
            }
        }

        public static string ObterRaDoAluno
        {
            get
            {
                return "SELECT RA FROM TB_ALUNOS WHERE RA = @Ra";
            }
        }

        public static string AtualizarDadosDoAluno
        {
            get
            {
                return @"UPDATE TB_ALUNOS
                            SET NOME = @Nome
                            , CPF = @Cpf
                            , MAE = @Mae
                            , PAI = @Pai
                            , SEXO = @Sexo
                            , DDD = @Ddd
                            , TELEFONE = @Telefone
                            , EMAIL = @Email
                            , CEP = @Cep
                            , LOGRADOURO = @Logradouro
                            , NUMERO = @Numero
                            , COMPLEMENTO = @Complemento
                            , CIDADE = @Cidade
                            , UF = @Uf
                            WHERE RA = @Ra";
            }
        }
    }
}
