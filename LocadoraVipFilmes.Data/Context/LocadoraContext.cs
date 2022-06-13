using LocadoraVipFilmes.Data.Configuration;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Context
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options):base(options)
        {

        }

        public DbSet<Ator>  Atores { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }
        public DbSet<FilmeAtor> FilmeAtores { get; set; }
        public DbSet<PedidoFilme> PedidoFilmes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AtorConfiguration());
            builder.ApplyConfiguration(new ProdutoraConfiguration());
            builder.ApplyConfiguration(new GeneroConfiguration());
            builder.ApplyConfiguration(new FilmeAtorConfiguration());
            builder.ApplyConfiguration(new FilmeConfiguration());
            builder.ApplyConfiguration(new PedidoFilmeConfiguration());
            builder.ApplyConfiguration(new PedidoConfiguration());
            builder.ApplyConfiguration(new EstadoConfiguration());
            builder.ApplyConfiguration(new CidadeConfiguration());
            builder.ApplyConfiguration(new EnderecoConfiguration());
            builder.ApplyConfiguration(new ClienteConfiguration());
            builder.ApplyConfiguration(new FuncionarioConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
