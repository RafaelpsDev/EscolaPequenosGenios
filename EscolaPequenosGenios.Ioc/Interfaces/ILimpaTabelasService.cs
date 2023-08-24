using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaPequenosGenios.IoC.Interfaces
{
    public interface ILimpaTabelasService
    {
        Task<bool> LimparTabelas(int idSessao, int raAluno);
    }
}
