
namespace EscolaPequenosGenios.IoC.DTOs
{
    public class ResponseSecretariaDTO
    {
        //TB_ALUNOS
        public int Ra { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Mae { get; set; }
        public string Pai { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Situacao { get; set; }
        //TB_RESPONSAVEIS
        public string NomeResponsavel { get; set; }
        public string CpfResponsavel { get; set; }
        public string DddResponsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public string EmailResponsavel { get; set; }
        //TB_MATRICULAS e TB_HISTORICOS
        public string NomeDoCurso { get; set; }
        public string Turma { get; set; }
        public char Turno { get; set; }
        public int Serie { get; set; }
        public double Nota { get; set; }
        public int Frequencia { get; set; }
        public string DataDaMatricula { get; set; }
        public string DataDeInsercao { get; set; }
        public string NomeDaDisciplina { get; set; }
        public List<ResponseSecretariaDTO> ListaDeDisciplinas { get; set; }

    }
}
