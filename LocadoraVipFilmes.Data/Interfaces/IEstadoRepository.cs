using LocadoraVipFilmes.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Interfaces
{
    public interface IEstadoRepository : IBaseRepository<Estado>
    {
        List<Estado> GetEstados();
        Estado GetEstadoById(int Id);
    }
}
