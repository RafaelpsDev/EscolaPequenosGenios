using EscolaPequenosGenios.Infrastructure.Interfaces;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public List<string> ObterCursos()
        {
            List<string> cursos = _cursoRepository.ObterCursos();
            return cursos;
        }        
    }
}
