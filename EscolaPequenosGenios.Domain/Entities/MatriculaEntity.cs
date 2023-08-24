
namespace EscolaPequenosGenios.Domain.Entities
{
    public class MatriculaEntity
    {
        public int Ra { get; set; }
        public int IdCurso { get; set; }
        public string NomeDoCurso { get; set; }
        public string Turma { get; set; }
        public char Turno { get; set; }
        public int IdDisciplina { get; set; }
        public string NomeDaDisciplina { get; set; }
        public int Serie { get; set; }
        public DateTime DataDaMatricula { get; set; }
    }
}
