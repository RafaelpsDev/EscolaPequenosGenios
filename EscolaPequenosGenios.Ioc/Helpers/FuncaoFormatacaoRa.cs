
namespace EscolaPequenosGenios.IoC.Helpers
{
    public class FuncaoFormatacaoRa
    {
        public static int GerarValorInteiroGenérico(string inputString, string complemento)
        {
            string concatenatedString = string.Concat(inputString.AsSpan(1, 3), complemento);
            int result = Convert.ToInt32(concatenatedString);
            return result;
        }
    }
}
