using EscolaPequenosGenios.Application.Services;
using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Threading.Tasks;

namespace EscolaPequenosGenios.Mvc.Controllers
{
    public class EscolaPequenosGeniosController : Controller
    {
        private readonly IAlunoService _alunoService;
        private readonly ICursoService _cursoService;
        private readonly IResponsavelService _responsavelService;
        private readonly IMatriculaService _matriculaService;
        private readonly IMatriculaExtracurricularService _matriculaExtracurricularService;
        private readonly ILimpaTabelasService _limpaTabelasService;
        private readonly ISessao _sessao;
        public EscolaPequenosGeniosController(
            IAlunoService alunoService
            , ICursoService cursoService
            , IResponsavelService responsavelService
            , IMatriculaService matriculaService
            , IMatriculaExtracurricularService matriculaExtracurricularService
            ,ILimpaTabelasService limpaTabelasService
            ,ISessao sessao
            )
        {
            _alunoService = alunoService;
            _cursoService = cursoService;
            _responsavelService = responsavelService;
            _matriculaService = matriculaService;
            _matriculaExtracurricularService = matriculaExtracurricularService;
            _limpaTabelasService = limpaTabelasService;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DadosDoAluno()
        {

            return View();
        }
        
        [HttpPost]
        [Route("/EscolaPequenosGenios/DadosDoAluno")]
        public async Task<IActionResult> DadosDoAluno(RequestAlunoDTO requestAlunoDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var aluno = await _alunoService.InsereAluno(requestAlunoDTO);
                    ViewBag.Ra = aluno.Ra;
                    return RedirectToAction("DadosDoResponsavel");
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Dados do aluno não inseridos, detalhe do erro: {erro.Message}";
                return View("Index");
            }
        }
        public IActionResult DadosDoResponsavel()
        {
            return View("DadosDoResponsavel");
        }

        [HttpPost]
        [Route("/EscolaPequenosGenios/DadosDoResponsavel")]
        public async Task<IActionResult> DadosDoResponsavel(RequestResponsavelDTO requestResponsavelDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _responsavelService.InsereResponsavel(requestResponsavelDTO);

                    return RedirectToAction("DadosDeMatricula");
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                var sessao = _sessao.BuscarSessaoDoUsuario();
                await _limpaTabelasService.LimparTabelas(sessao.Id, ViewBag.Ra);
                TempData["MensagemErro"] = $"Responsavel não cadastrado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DadosDeMatricula()
        {
            return View("DadosDeMatricula");
        }


        [HttpPost]
        public async Task<IActionResult> DadosDeMatricula(RequestMatriculaDTO requestMatriculaDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _matriculaService.MatricularAluno(requestMatriculaDTO);                    
                    return RedirectToAction("DadosCursoExtracurricular");
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                var sessao = _sessao.BuscarSessaoDoUsuario();
                await _limpaTabelasService.LimparTabelas(sessao.Id, ViewBag.Ra);
                TempData["MensagemErro"] = $"Aluno não matriculado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult DadosCursoExtracurricular()
        {
            return View("DadosCursoExtracurricular");
        }


        [HttpPost]
        public async Task<IActionResult> DadosCursoExtracurricular(RequestMatriculaCursosExtracurricularesDTO requestMatriculaCursosExtracurriculares)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var aluno = await _matriculaExtracurricularService.MatricularAlunoCursoExtracurricular(requestMatriculaCursosExtracurriculares);
                    TempData["MensagemSucesso"] = $"Aluno matriculado com sucesso, RA do aluno: {aluno.Ra}";
                    return View("Index");
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                var sessao = _sessao.BuscarSessaoDoUsuario();
                await _limpaTabelasService.LimparTabelas(sessao.Id, ViewBag.Ra);
                TempData["MensagemErro"] = $"Aluno não matriculado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }      

        [HttpGet]
        [Route("/EscolaPequenosGenios/ObterCursos")]
        public ActionResult ObterCursos()
        {
            var cursos = _cursoService.ObterCursos();
            return Json(cursos);
        }
    }
}
