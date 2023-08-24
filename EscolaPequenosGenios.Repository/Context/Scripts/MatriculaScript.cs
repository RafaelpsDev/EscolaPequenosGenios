
namespace EscolaPequenosGenios.Infrastructure.Context.Scripts
{
    public class MatriculaScript
    {
        public static string InsereAlunoNaMatricula
        {
            get
            {
                return @"INSERT INTO TB_MATRICULAS (RA, ID_CURSO, NOME_DO_CURSO, TURMA, 
                                TURNO, ID_DISCIPLINA, NOME_DA_DISCIPLINA, SERIE, DATA_DA_MATRICULA)
                            SELECT DISTINCT
                              @Ra AS RA
                             ,C.ID AS ID_CURSO
                             ,C.NOME AS NOME_DO_CURSO
                             ,T.TURMA
                             ,@Turno AS TURNO
                             ,D.ID AS ID_DISCIPLINA
                             ,D.NOME AS DISCIPLINA
                             ,T.SERIE
                             ,GETDATE() AS DATA_DA_MATRICULA
                            FROM TB_DISCIPLINAS D
                            INNER JOIN TB_CURSOS C
                            ON D.ID_CURSO = C.ID
                            INNER JOIN TB_TURMAS T
                            ON T.ID_CURSO = C.ID
                            WHERE C.ID = @IdCurso
                            AND T.SERIE = @Serie";
            }
        }
        public static string ObterMatriculaDoAlunoPeloRa
        {
            get
            {
                return @"SELECT DISTINCT RA, NOME_DO_CURSO AS NomeDoCurso, TURMA, TURNO, SERIE, DATA_DA_MATRICULA AS DataDaMatricula
                            FROM TB_MATRICULAS WHERE RA = @Ra";
            }
        }

        public static string ObterDisciplinasDaMatriculaPorRa
        {
            get
            {
                return @"SELECT NOME_DA_DISCIPLINA FROM TB_MATRICULAS WHERE RA = @Ra";
            }
        }
        public static string RemoverMatricula
        {
            get
            {
                return @"DELETE TB_MATRICULAS WHERE RA = @raAluno";
            }
        }
    }
}
