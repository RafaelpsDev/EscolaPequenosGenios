namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IVerificaCpfAlunoService
    {
        Task<bool> VerificaCpfAluno(string cpfAluno);
    }
}
