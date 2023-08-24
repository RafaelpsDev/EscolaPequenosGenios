
namespace EscolaPequenosGenios.Domain.Entities
{
    public class DisciplinaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int IdCurso { get; set; }
    }
}
