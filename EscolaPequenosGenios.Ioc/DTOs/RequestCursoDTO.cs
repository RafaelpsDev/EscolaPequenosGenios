using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class RequestCursoDTO
    {
        public int IdCurso { get; set; }
        public string NomeDoCurso { get; set; }
        [Required(ErrorMessage = "O campo Turno é obrigatório")]
        public char Turno { get; set; }
        [Required(ErrorMessage = "A campo Série é obrigatória")]
        public int Serie { get; set; }
    }
}
