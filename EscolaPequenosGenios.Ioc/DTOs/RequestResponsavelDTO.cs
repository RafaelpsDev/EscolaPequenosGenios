using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class RequestResponsavelDTO
    {
        [Required(ErrorMessage = "Informe um nome válido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe um CPF válido")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        [StringLength(2)]
        public string Ddd { get; set; }
        [Required(ErrorMessage = "Informe um telefone válido")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe um e-mail válido")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
