using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class PessoaVO : ModelBaseVO
    {
        
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string TelFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public bool Ativo { get; set; }

        public EnderecoVO Endereco { get; set; }

        public List<PedidoVO> Pedidos { get; set; }

    }
}
