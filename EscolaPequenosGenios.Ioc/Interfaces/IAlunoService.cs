using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.DTOs;
using System.Data;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IAlunoService
    {
        Task<ResponseTabelaAuxiliarDTO> ObterDadosDaTabelaAuxiliar(int idSessao);
        Task<ResponseSecretariaDTO> RetornoAluno(int ra);
        Task<ResponseSecretariaDTO> ObterRaDoAluno(int ra);        
        Task<AlunoEntity> InsereAluno(RequestAlunoDTO requestAlunoDTO);
        Task<bool> PopularTabelaAuxiliarMatricula(int idSessao, int raAluno);
        Task<bool> RemoverAluno(int raAluno);
        Task<string> GeraComplementoRa();
        Task<bool> LimparTabelaAuxiliar(int idSessao, int raAluno);
    }
}
