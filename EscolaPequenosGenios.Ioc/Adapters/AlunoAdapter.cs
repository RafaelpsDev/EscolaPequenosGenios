using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.Interfaces;

namespace EscolaPequenosGenios.IoC.Adapters
{
    public class AlunoAdapter : IAlunoAdapter
    {
        public AlunoEntity ToAlunoEntity(RequestAlunoDTO requestAlunoDTO)
        {
            return new AlunoEntity
            {
                Nome = requestAlunoDTO.Nome,
                Cpf = requestAlunoDTO.Cpf,
                Mae = requestAlunoDTO.Mae,
                Pai = requestAlunoDTO.Pai,
                Sexo = requestAlunoDTO.Sexo,
                Ddd = requestAlunoDTO.Ddd,
                Telefone = requestAlunoDTO.Telefone,
                Email = requestAlunoDTO.Email,
                Cep = requestAlunoDTO.Cep,
                Logradouro = requestAlunoDTO.Logradouro,
                Numero = requestAlunoDTO.Numero,
                Complemento = requestAlunoDTO.Complemento,
                Cidade = requestAlunoDTO.Cidade,
                Uf = requestAlunoDTO.Uf
            };
        }

        public ResponseAlunoDTO ToResponseAlunoDTO(AlunoEntity alunoEntity)
        {
            return new ResponseAlunoDTO
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

        public ResponseTabelaAuxiliarDTO ToResponseTabelaAuxiliarDTO(AlunoEntity alunoEntity)
        {
            return new ResponseTabelaAuxiliarDTO
            {
                RaAluno = alunoEntity.Ra
            };
        }
    }
}
