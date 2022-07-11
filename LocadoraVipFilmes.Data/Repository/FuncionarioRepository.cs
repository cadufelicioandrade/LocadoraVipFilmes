using LocadoraVipFilmes.Data.Context;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.EntityFrameworkCore;

namespace LocadoraVipFilmes.Data.Repository
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(LocadoraContext context) : base(context)
        {
        }

        public Funcionario GetFuncionario(int id)
        {
            var funcionario = _context.Funcionarios
                                       .Include(f => f.Endereco)
                                       .Where(f => f.Id == id)
                                       .FirstOrDefault();
            return funcionario;
        }

        public List<Funcionario> GetFuncionarios()
        {
            var funcionarios = _context.Funcionarios
                                       .Include(f => f.Endereco)
                                       .ToList();
            return funcionarios;
        }
    }
}
