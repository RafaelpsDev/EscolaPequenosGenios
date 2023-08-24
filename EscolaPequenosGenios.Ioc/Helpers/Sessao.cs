using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.IoC.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EscolaPequenosGenios.IoC.Helpers
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;
        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public UsuarioEntity BuscarSessaoDoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (String.IsNullOrEmpty(sessaoUsuario)) return null;

            return JsonConvert.DeserializeObject<UsuarioEntity>(sessaoUsuario);
            
        }

        public void CriarSessaoDoUsuario(UsuarioEntity usuarioEntity)
        {
            string valor = JsonConvert.SerializeObject(usuarioEntity);
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoDoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
