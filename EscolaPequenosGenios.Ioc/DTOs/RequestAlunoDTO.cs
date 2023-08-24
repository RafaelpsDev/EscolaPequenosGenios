using System.ComponentModel.DataAnnotations;

namespace EscolaPequenosGenios.IoC.DTOs
{
    public class RequestAlunoDTO
    {
        [Required(ErrorMessage = "Campo obirgatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe um CPF válido")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public string Mae { get; set; }
        public string Pai { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        [StringLength(2)]
        public string Ddd { get; set; }
        [Required(ErrorMessage = "Informe um telefone válido")]        
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe um e-mail válido")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe um CEP válido")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public int Numero { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo obirgatório")]
        public string Uf { get; set; }        
    }
}
