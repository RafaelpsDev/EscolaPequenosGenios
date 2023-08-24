using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class RequestUsuarioDTO
    {
        [Required(ErrorMessage = "Cpf inválido.")]
        public string Cpf { get; set; }
        
        [Required(ErrorMessage = "Nome inválido.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Senha inválida.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Setor inválido.")]
        public string Setor { get; set; }
    }
}
