using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IAlunoAdapter
    {
        public AlunoEntity ToAlunoEntity(RequestAlunoDTO requestAlunoDTO);
        public ResponseTabelaAuxiliarDTO ToResponseTabelaAuxiliarDTO(AlunoEntity alunoEntity);
        public ResponseAlunoDTO ToResponseAlunoDTO(AlunoEntity alunoEntity);
    }
}
