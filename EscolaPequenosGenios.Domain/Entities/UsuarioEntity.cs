using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaPequenosGenios.Domain.Entities
{
    public class UsuarioEntity
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Usuário inválido.")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Nome inválido.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Senha inválida.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Setor inválido.")]
        public string Setor { get; set; }

    }
}
