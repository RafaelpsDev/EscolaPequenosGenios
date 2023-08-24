using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EscolaPequenosGenios.Mvc.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Criar(RequestUsuarioDTO requestUsuarioDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await _usuarioService.CriarUsuario(requestUsuarioDTO);
                    TempData["MensagemSucesso"] = $"Usuário {usuario.Usuario} criado com sucesso";
                        return RedirectToAction("Index");
                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Não foi possível adicionar o usuário. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
