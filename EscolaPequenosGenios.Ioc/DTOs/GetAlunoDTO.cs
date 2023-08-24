using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class GetAlunoDTO
    {
        [Required(ErrorMessage = "Digite o Ra do aluno")]
        public int Ra { get; set; }
    }
}
