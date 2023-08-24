namespace EscolaPequenosGenios.Infrastructure.Interfaces
{
    public interface ICursoRepository
    {
        List<string> ObterCursos();
        Task<int> ObterIdDoCursoPeloNome(string nomeDoCurso);
    }
}
