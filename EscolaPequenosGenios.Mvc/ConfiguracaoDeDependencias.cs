using EscolaPequenosGenios.Application.Services;
using EscolaPequenosGenios.Infrastructure.Context.DapperConnection;
using EscolaPequenosGenios.Infrastructure.Interfaces;
using EscolaPequenosGenios.Infrastructure.Repository;
using EscolaPequenosGenios.IoC.Adapters;
using EscolaPequenosGenios.IoC.Helpers;
using EscolaPequenosGenios.IoC.Interfaces;
using EscolaPequenosGenios.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace EscolaPequenosGenios.Mvc
{
    public class ConfiguracaoDeDependencias
    {
        public static void ConfigurarDependencias(IServiceCollection services)
        {
            services.AddScoped<IConexao, Conexao>();
            services.AddScoped<ISessao, Sessao>();

            services.AddScoped<IAlunoAdapter, AlunoAdapter>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IAlunoService, AlunoService>();

            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICursoService, CursoService>();

            services.AddScoped<IResponsavelAdapter, ResponsavelAdapter>();
            services.AddScoped<IResponsavelRepository, ResponsavelRepository>();
            services.AddScoped<IResponsavelService, ResponsavelService>();
                
            services.AddScoped<IMatriculaRepository, MatriculaRepository>();
            services.AddScoped<IMatriculaAdapter, MatriculaAdapter>();
            services.AddScoped<IMatriculaService, MatriculaService>();

            services.AddScoped<IMatriculaExtracurricularRepository, MatriculaExtracurricularRepository>();
            services.AddScoped<IMatriculaExtracurricularAdapter, MatriculaExtracurricularAdapter>();
            services.AddScoped<IMatriculaExtracurricularService, MatriculaExtracurricularService>();

            services.AddScoped<IUsuarioAdapter, UsuarioAdapter>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddScoped<IVerificaCpfAlunoService, VerificaCpfAlunoService>();
            services.AddScoped<IParametrosAlunoRepository, ParametrosAlunoRepository>();
            services.AddScoped<ISecretariaAdapter, SecretariaAdapter>();

            services.AddScoped<IHistoricoService, HistoricoService>();
            services.AddScoped<IHistoricoRepository, HistoricoRepository>();
                
            services.AddScoped<IPdfService, PdfService>();

            services.AddScoped<ILimpaTabelasService, LimpaTabelasService>();

        }

    }
}
