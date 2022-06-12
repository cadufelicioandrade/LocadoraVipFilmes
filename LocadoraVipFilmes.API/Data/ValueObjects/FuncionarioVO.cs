using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.API.Data.ValueObjects
{
    public class FuncionarioVO : PessoaVO
    {
        public FuncionarioVO()
        {

        }

        public string NomeFuncionario { get; set; }
    }
}
