
namespace EscolaPequenosGenios.Infrastructure.Context.Scripts
{
    public class HistoricoScript
    {
        public static string ObterHistoricoDoAluno { 
            get
            {
                return @"SELECT DISTINCT 
                             RA
                            ,NOME_DO_CURSO AS NomeDoCurso
                            ,NOME_DA_DISCIPLINA AS NomeDaDisciplina
                            ,SERIE
                            ,NOTA
                            ,FREQUENCIA
                            ,SITUACAO
                            ,DATA_DE_INSERCAO AS DataDeInsercao
                            from TB_HISTORICOS where RA = @Ra";
            } 
        }
    }
}
