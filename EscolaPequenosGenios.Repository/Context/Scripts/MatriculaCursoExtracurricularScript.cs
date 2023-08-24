
namespace EscolaPequenosGenios.Infrastructure.Context.Scripts
{
    public class MatriculaCursoExtracurricularScript
    {
        public static string InsereAlunoCursoExtracurricular { 
            get
            {
                return @"INSERT INTO TB_MATRICULAS_CURSOS_EXTRACURRICULARES
                        SELECT DISTINCT
                              @Ra AS RA
                             ,C.ID AS ID_CURSO
                             ,C.NOME AS NOME_DO_CURSO
                             ,D.ID AS ID_DISCIPLINA
                             ,D.NOME AS DISCIPLINA
                             ,GETDATE() AS DATA_DA_MATRICULA
                            FROM TB_DISCIPLINAS D
                            INNER JOIN TB_CURSOS C
                            ON D.ID_CURSO = C.ID
                            WHERE C.NOME = @NomeDoCurso";
            } 
        }
        public static string ObterMatriculaExtracurricularDoAlunoPeloRa
        {
            get
            {
                return @"SELECT DISTINCT
                             RA
                            ,NOME_DO_CURSO AS NomeDoCurso
                            ,DATA_DA_MATRICULA 
                            FROM TB_MATRICULAS_CURSOS_EXTRACURRICULARES
                            WHERE RA = @Ra";
            }
        }

        public static string ObterDisciplinasExtracurricularDaMatriculaPorRa
        {
            get
            {
                return @"SELECT NOME_DA_DISCIPLINA FROM TB_MATRICULAS_CURSOS_EXTRACURRICULARES WHERE RA = @Ra";
            }
        }
    }
}
