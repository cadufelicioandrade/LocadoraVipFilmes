using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.API.Data.ValueObjects
{
    public class EnderecoVO : ModelBaseVO
    {
        public EnderecoVO()
        {

        }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }

        public ClienteVO Cliente { get; set; }
        public int? ClienteId { get; set; }

        public FuncionarioVO Funcionario { get; set; }
        public int? FuncionarioId { get; set; }

        public CidadeVO Cidade { get; set; }
        public int CidadeId { get; set; }

    }
}
