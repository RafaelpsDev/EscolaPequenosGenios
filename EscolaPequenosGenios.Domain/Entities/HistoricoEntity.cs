
namespace EscolaPequenosGenios.Domain.Entities
{
    public class HistoricoEntity
    {
        public int Ra { get; set; }
        public string NomeDoCurso { get; set; }
        public string NomeDaDisciplina { get; set; }
        public int Serie { get; set; }
        public double Nota { get; set; }
        public int Frequencia { get; set; }
        public string Situacao { get; set; }
        public DateTime DataDeInsercao { get; set; }
    }
}
