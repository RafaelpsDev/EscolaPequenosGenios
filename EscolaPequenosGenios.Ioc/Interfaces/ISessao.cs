using EscolaPequenosGenios.Domain.Entities;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioEntity usuarioEntity);
        void RemoverSessaoDoUsuario();
        UsuarioEntity BuscarSessaoDoUsuario();
    }
}
