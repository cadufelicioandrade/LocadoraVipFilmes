using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class ClienteVO : PessoaVO
    {
        public ClienteVO()
        {

        }

        public string NomeCliente { get; set; }
    }
}
