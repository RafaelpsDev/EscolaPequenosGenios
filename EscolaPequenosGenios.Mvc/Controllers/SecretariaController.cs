using EscolaPequenosGenios.IoC.DTOs;
using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Mvc.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EscolaPequenosGenios.Mvc.Controllers
{
    public class SecretariaController : Controller
    {
        private readonly IAlunoService _alunoService;
        private readonly IResponsavelService _responsavelService;
        private readonly IMatriculaService _matriculaService;
        private readonly IMatriculaExtracurricularService _matriculaExtracurricularService;
        private readonly IHistoricoService _historicoService;
        private readonly IPdfService _exportPdfService;
        public SecretariaController(
            IAlunoService alunoService, 
            IResponsavelService responsavelService, 
            IMatriculaService matriculaService,
            IMatriculaExtracurricularService matriculaExtracurricularService,
            IHistoricoService historicoService,
            IPdfService exportPdfService)
        {
            _alunoService = alunoService;
            _responsavelService = responsavelService;
            _matriculaService = matriculaService;
            _matriculaExtracurricularService = matriculaExtracurricularService;
            _historicoService = historicoService;
            _exportPdfService = exportPdfService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ObterAluno() 
        {
                return View("ObterAluno");
        }

        [HttpGet]
        public async Task<IActionResult> DadosDoAlunoInfo(int ra)
        {
            var aluno = await _alunoService.RetornoAluno(ra);
            return View(aluno);
        }
        [HttpGet]
        public async Task<IActionResult> DadosDoResponsavelInfo(int ra)
        {
            ViewBag.Ra = ra;
            var responsavel = await _responsavelService.ObterResponsavelPeloRaDoAluno(ra);
            return View(responsavel);
        }
        [HttpGet]
        public async Task<IActionResult> DadosDaMatriculaInfo(int ra)
        {
            ViewBag.Ra = ra;
            var matricula = await _matriculaService.ObterMatriculaDoAlunoPorRa(ra);
            return View(matricula);
        }
        public async Task<IActionResult> DadosDaMatriculaExtracurricularInfo(int ra)
        {
            ViewBag.Ra = ra;
            var matricula = await _matriculaExtracurricularService.ObterMatriculaExtracurricularDoAlunoPorRa(ra);
            return View(matricula);
        }
        [HttpGet]
        public async Task<IActionResult> DisciplinasDaMatriculaInfo(int ra)
        {
            ViewBag.Ra = ra;            
            List<ResponseSecretariaDTO> listaDisciplinas = 
                await _matriculaService.ObterDisciplinasDoAluno(ra);// Obtenha a lista de valores da coluna
            return View(listaDisciplinas);
        }
        [HttpGet]
        public async Task<IActionResult> DisciplinasExtracurricularDaMatriculaInfo(int ra)
        {
            ViewBag.Ra = ra;
            List<ResponseSecretariaDTO> listaDisciplinas =
                await _matriculaExtracurricularService.ObterDisciplinasExtracurricularDoAluno(ra);// Obtenha a lista de valores da coluna
            return View(listaDisciplinas);
        }
        [HttpGet]
        public async Task<IActionResult> ObterHistoricoDoAluno(int ra)
        {
            ViewBag.Ra = ra;
            List<ResponseSecretariaDTO> historico =
                await _historicoService.ObterHistoricoDoAluno(ra);// Obtenha a lista de valores da coluna
            return View(historico);
        }
        public async Task<IActionResult> Secretaria(GetAlunoDTO getAlunoDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var ra = await _alunoService.ObterRaDoAluno(getAlunoDTO.Ra);
                    return View(ra);
                }
                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Aluno não existe, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
            
        }
        public async Task<IActionResult> ExportToPdf(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<List<ResponseSecretariaDTO>>(jsonData);
            var templateViewName = "TemplateTabela"; // Nome da view do template HTML
            var templateHtmlContent = await ViewRender.RenderViewToStringAsync(this, templateViewName, model);

            var pdfBytes = _exportPdfService.GeneratePdfFromHtml(templateHtmlContent);

            return File(pdfBytes, "application/pdf", "historico_aluno.pdf");
        }
    }
}
