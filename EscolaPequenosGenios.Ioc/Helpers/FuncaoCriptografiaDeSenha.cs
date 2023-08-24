using System.Security.Cryptography;
using System.Text;

namespace EscolaPequenosGenios.IoC.Helpers
{
    public class FuncaoCriptografiaDeSenha
    {
        public static string CriptografarSenha(string senha)
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
            byte[] hashSenha = SHA256.HashData(bytesSenha);
            return Convert.ToBase64String(hashSenha);
        }
    }
}
