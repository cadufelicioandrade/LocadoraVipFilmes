using LocadoraVipFilmes.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Interfaces
{
    public interface ICidadeRepository: IBaseRepository<Cidade>
    {
        List<Cidade> GetCidades();
        Cidade GetCidadeById(int id);
    }
}
