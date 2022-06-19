using LocadoraVipFilmes.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Interfaces
{
    public interface IAtorRepository : IBaseRepository<Ator>
    {
        void AdicionarFilmeAtor(Ator ator);
    }
}
