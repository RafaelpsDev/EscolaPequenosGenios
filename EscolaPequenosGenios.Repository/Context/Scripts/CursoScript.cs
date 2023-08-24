
namespace EscolaPequenosGenios.Infrastructure.Context.Scripts
{
    public class CursoScript
    {
        public static string ObterNomeDeTodosOsCursos
        {
            get { return "SELECT NOME AS NomeDoCurso FROM TB_CURSOS WHERE Extracurricular = 'N'"; }
        }

        public static string ObterIdDoCursoPorNome
        {
            get { return "SELECT ID FROM TB_CURSOS WHERE NOME = @NomeDoCurso"; }
        }
        
        public static string ObtemTempCurso
        {
            get
            {
                return @"SELECT * FROM TB_AUXILIAR_CURSO";
            }
        }

        public static string TempCurso
        {
            get
            {
                return @"INSERT INTO TB_AUXILIAR_CURSO VALUES (@IdCurso, @Turno, @Serie)";
            }
        }
    }
}
