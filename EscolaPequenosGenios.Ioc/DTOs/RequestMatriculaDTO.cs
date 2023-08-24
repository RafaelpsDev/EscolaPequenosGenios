
using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class RequestMatriculaDTO
    {
        [Required(ErrorMessage = "Campo obirgatório")]
        public string NomeDoCurso { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public char Turno { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public int Serie { get; set; }
    }
}
