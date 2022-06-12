using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class FilmeVO : ModelBaseVO
    {
        public FilmeVO()
        {

        }

        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; }
        public double ValorLocacao { get; set; }

        public GeneroVO Genero { get; set; }
        public int GeneroId { get; set; }

        public ProdutoraVO Produtora { get; set; }
        public int ProdutoraId { get; set; }

        public List<FilmeAtorVO> FilmeAtors { get; set; }

        public List<PedidoFilmeVO> PedidoFilmes { get; set; }

    }
}
