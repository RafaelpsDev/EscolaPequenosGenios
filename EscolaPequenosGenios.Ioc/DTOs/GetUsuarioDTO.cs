using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class GetUsuarioDTO
    {
        [Required(ErrorMessage = "Usuário inválido.")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Senha inválida.")]
        public string Senha { get; set; }}
}
