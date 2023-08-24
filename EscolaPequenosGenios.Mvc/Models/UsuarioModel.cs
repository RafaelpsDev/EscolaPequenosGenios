using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.Mvc.Models
{
    public class UsuarioModel
    {
        
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha inválida.")]
        public string Senha { get; set; }
    }
}
