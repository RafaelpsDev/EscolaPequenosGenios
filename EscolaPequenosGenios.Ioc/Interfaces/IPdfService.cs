
namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface IPdfService
    {
        public byte[] GeneratePdfFromHtml(string htmlContent);
    }
}
