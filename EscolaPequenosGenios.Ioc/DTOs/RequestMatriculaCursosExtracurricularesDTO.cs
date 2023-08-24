using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class RequestMatriculaCursosExtracurricularesDTO
    {
        [Required(ErrorMessage = "Campo obirgatório")]
        public string NomeDoCurso { get; set; }
    }
}
