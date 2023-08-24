using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EscolaPequenosGenios.Mvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ISessao _sessao;

        public LoginController(IUsuarioService usuarioService, ISessao sessao)
        {
            _usuarioService = usuarioService;
            _sessao = sessao;

        }
        public IActionResult Index()
        {
            //Se o usuário estiver logado, redirecionar para a home
            if (_sessao.BuscarSessaoDoUsuario() != null)
                return RedirectToAction("Index", "Home");
            return View();
        }
        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();
            return RedirectToAction("Index", "Login");
        }
        [HttpPost]
        public async Task<IActionResult> Entrar(GetUsuarioDTO getUsuarioDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await _usuarioService.ObterUsuario(getUsuarioDTO);
                    _sessao.CriarSessaoDoUsuario(usuario);
                    return RedirectToAction("Index", "Home");
                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Não conseguimos realizar seu login, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
