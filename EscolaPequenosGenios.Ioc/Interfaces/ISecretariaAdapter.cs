using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface ISecretariaAdapter
    {
        public ResponseSecretariaDTO ToResponseSecretariaDTOAluno(AlunoEntity alunoEntity);
        public ResponseSecretariaDTO ToResponseSecretariaDTOResponsavel(ResponsavelEntity responsavelEntity);
        public ResponseSecretariaDTO ToResponseSecretariaDTOAlunoRa(AlunoEntity alunoEntity);
        public ResponseSecretariaDTO ToResponseSecretariaDTOMatriculaRa(MatriculaEntity matriculaEntity);
        public ResponseSecretariaDTO ToResponseSecretariaDTOMatriculaExtracuirricularRa(MatriculaEntity matriculaEntity);
        public List<ResponseSecretariaDTO> ToResponseSecretariaDTODisciplinasRa(List<string> matriculaEntity);
        public List<ResponseSecretariaDTO> ToResponseSecretariaDTOHistorico(List<HistoricoEntity> historicoEntity);
    }
}
