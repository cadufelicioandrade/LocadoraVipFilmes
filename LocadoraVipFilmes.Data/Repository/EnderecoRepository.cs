using LocadoraVipFilmes.Data.Context;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Repository
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(LocadoraContext context) : base(context)
        {
        }

        public Endereco GetEnderecoByClienteId(int clienteId)
        {
            var endereco = _context.Enderecos
                                .Where(e => e.ClienteId == clienteId)
                                .FirstOrDefault();

            return endereco;
        }

        public Endereco GetEnderecoByFuncionarioId(int funcionarioId)
        {
            var endereco = _context.Enderecos
                                .Where(e => e.FuncionarioId == funcionarioId)
                                .FirstOrDefault();

            return endereco;
        }
    }
}
