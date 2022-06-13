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
        [MaxLength(40, ErrorMessage = "O Título não pode ter mais de 40 caracteres.")]
        [MinLength(3, ErrorMessage = "O Titulo não pode ter menos de 3 caracteres.")]
        public string Titulo { get; set; }

        [MinLength(1, ErrorMessage = "Duração não pode ser menor que zero.")]
        [Required(ErrorMessage = "O campo Duracao é obrigatório.")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "O campo Descricao é obrigatório.")]
        [MaxLength(150, ErrorMessage = "A Descrição não pode ter mais de 150 caracteres.")]
        [MinLength(5, ErrorMessage = "O Descricao não pode ter menos de 5 caracteres.")]
        public string Descricao { get; set; }

        public DateTime DtInclusao { get; set; }
        
        [Required(ErrorMessage = "O campo AnoLancamento é obrigatório.")]
        [MaxLength(3000, ErrorMessage = "Ano lançamento fora da faixa de valor.")]
        [MinLength(1700, ErrorMessage = "Ano lançamento fora da faixa de valor.")]
        public int AnoLancamento { get; set; }
        
        public bool Disponivel { get; set; }
        
        [Required(ErrorMessage = "O campo ValorLocacao é obrigatório.")]
        [MinLength(0, ErrorMessage = "Valor Locação não pode ser menor que zero")]
        [MaxLength(20, ErrorMessage = "Valor Locação não pode ser maior que 20.")]
        public double ValorLocacao { get; set; }
        
        [Required(ErrorMessage = "O campo GeneroId é obrigatório.")]
        public int GeneroId { get; set; }

        [Required(ErrorMessage = "O campo ProdutoraId é obrigatório.")]
        public int ProdutoraId { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual Produtora Produtora { get; set; }
        public virtual List<FilmeAtor> FilmeAtors { get; set; }
        public virtual List<PedidoFilme> PedidoFilmes { get; set; }

    }
}
