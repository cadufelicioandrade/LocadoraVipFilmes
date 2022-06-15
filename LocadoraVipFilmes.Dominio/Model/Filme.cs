using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Filme : ModelBase
    {
        public Filme()
        {

        }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Título deve ter entre 3 e 40 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Duracao é obrigatório.")]
        [MinLength(1, ErrorMessage = "Duração não pode ser menor que zero.")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "O campo Descricao é obrigatório.")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Descricao deve ter entre 3 e 250 caracteres.")]
        public string Descricao { get; set; }

        public DateTime DtInclusao { get; set; }
        
        [Required(ErrorMessage = "O campo AnoLancamento é obrigatório.")]
        [Range(1700, 3000, ErrorMessage = "Ano lançamento fora da faixa de valor.")]
        public int AnoLancamento { get; set; }
        
        [Required(ErrorMessage = "O campo ValorLocacao é obrigatório.")]
        [Range(0, 25, ErrorMessage = "Faixa de valor deve ser entre 0 e 25.")]
        public double ValorLocacao { get; set; }
        
        [Required(ErrorMessage = "O campo GeneroId é obrigatório.")]
        public int GeneroId { get; set; }

        [Required(ErrorMessage = "O campo ProdutoraId é obrigatório.")]
        public int ProdutoraId { get; set; }

        public bool Disponivel { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual Produtora Produtora { get; set; }
        public virtual List<FilmeAtor> FilmeAtors { get; set; }
        public virtual List<PedidoFilme> PedidoFilmes { get; set; }

    }
}
