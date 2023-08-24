using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.IoC.Adapters
{
    public class SecretariaAdapter : ISecretariaAdapter
    {

        public ResponseSecretariaDTO ToResponseSecretariaDTOAluno(AlunoEntity alunoEntity)
        {
            return new ResponseSecretariaDTO
            {
                Ra = alunoEntity.Ra,
                Nome = alunoEntity.Nome,
                Cpf = alunoEntity.Cpf,
                Mae = alunoEntity.Mae,
                Pai = alunoEntity.Pai,
                Sexo = alunoEntity.Sexo,
                Telefone = alunoEntity.Telefone,
                Email = alunoEntity.Email,
                Cep = alunoEntity.Cep,
                Logradouro = alunoEntity.Logradouro,
                Numero = alunoEntity.Numero,
                Complemento = alunoEntity.Complemento,
                Cidade = alunoEntity.Cidade,
                Uf = alunoEntity.Uf,
                Situacao = alunoEntity.Situacao
            };
        }
        public ResponseSecretariaDTO ToResponseSecretariaDTOResponsavel(ResponsavelEntity responsavelEntity)
        {
            return new ResponseSecretariaDTO
            {
                Ra = responsavelEntity.RaAluno,
                NomeResponsavel = responsavelEntity.Nome,
                CpfResponsavel = responsavelEntity.Cpf,
                DddResponsavel = responsavelEntity.Ddd,
                TelefoneResponsavel = responsavelEntity.Telefone,
                EmailResponsavel = responsavelEntity.Email
            };
        }

        public ResponseSecretariaDTO ToResponseSecretariaDTOAlunoRa(AlunoEntity alunoEntity)
        {
            return new ResponseSecretariaDTO
            {
                Ra = alunoEntity.Ra
            };
        }

        public ResponseSecretariaDTO ToResponseSecretariaDTOMatriculaRa(MatriculaEntity matriculaEntity)
        {
            return new ResponseSecretariaDTO
            {
                NomeDoCurso = matriculaEntity.NomeDoCurso,
                Turma = matriculaEntity.Turma,
                Turno = matriculaEntity.Turno,
                Serie = matriculaEntity.Serie,
                DataDaMatricula = matriculaEntity.DataDaMatricula.ToString("dd/MM/yyyy"),
                NomeDaDisciplina = matriculaEntity.NomeDaDisciplina
            };
        }
        public List<ResponseSecretariaDTO> ToResponseSecretariaDTODisciplinasRa(List<string> matriculaEntity)
        {
            List<ResponseSecretariaDTO> responseSecretariaDTOList = new();
            foreach (string entity in matriculaEntity)
            {
                responseSecretariaDTOList.Add(new ResponseSecretariaDTO
                {
                    NomeDaDisciplina = entity
                });
            }
            return responseSecretariaDTOList;
        }

        public ResponseSecretariaDTO ToResponseSecretariaDTOMatriculaExtracuirricularRa(MatriculaEntity matriculaEntity)
        {
            return new ResponseSecretariaDTO
            {
                NomeDoCurso = matriculaEntity.NomeDoCurso,
                DataDaMatricula = matriculaEntity.DataDaMatricula.ToString("dd/MM/yyyy"),
                NomeDaDisciplina = matriculaEntity.NomeDaDisciplina
            };
        }

        public List<ResponseSecretariaDTO> ToResponseSecretariaDTOHistorico(List<HistoricoEntity> historicoEntity)
        {
            List<ResponseSecretariaDTO> Dto = new();
            foreach (var entity in historicoEntity)
            {
                Dto.Add(new ResponseSecretariaDTO
                {
                    Ra = entity.Ra,
                    NomeDoCurso = entity.NomeDoCurso,
                    NomeDaDisciplina = entity.NomeDaDisciplina,
                    Serie = entity.Serie,
                    Nota = entity.Nota,
                    Frequencia = entity.Frequencia,
                    Situacao = entity.Situacao,
                    DataDeInsercao = entity.DataDeInsercao.ToString("dd/MM/yyyy")
                });
            }
            return Dto;
        }
    }
}
