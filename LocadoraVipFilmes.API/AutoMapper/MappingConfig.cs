using AutoMapper;
using LocadoraVipFilmes.API.DTOs.AtorDTO;
using LocadoraVipFilmes.API.DTOs.CidadeDTO;
using LocadoraVipFilmes.API.DTOs.ClienteDTO;
using LocadoraVipFilmes.API.DTOs.EnderecoDTO;
using LocadoraVipFilmes.API.DTOs.EstadoDTO;
using LocadoraVipFilmes.API.DTOs.FilmeAtorDTO;
using LocadoraVipFilmes.API.DTOs.FilmeDTO;
using LocadoraVipFilmes.API.DTOs.FuncionarioDTO;
using LocadoraVipFilmes.API.DTOs.GeneroDTO;
using LocadoraVipFilmes.API.DTOs.PedidoDTO;
using LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO;
using LocadoraVipFilmes.API.DTOs.ProdutoraDTO;
using LocadoraVipFilmes.Dominio.Model;

namespace LocadoraVipFilmes.API.AutoMapper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Ator, CreateAtorDTO>().ReverseMap();
                config.CreateMap<IEnumerable<Ator>, IEnumerable<ReadAtorDTO>>().ReverseMap();
                config.CreateMap<Ator, ReadAtorDTO>().ReverseMap();
                config.CreateMap<Ator, UpdateAtorDTO>().ReverseMap();

                config.CreateMap<Cidade, CreateCidadeDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Cidade>, IEnumerable<ReadCidadeDTO>>().ReverseMap();
                config.CreateMap<Cidade, ReadCidadeDTO>().ReverseMap();
                config.CreateMap<Cidade, UpdateCidadeDTO>().ReverseMap();

                config.CreateMap<Cliente, CreateClienteDTO>().ReverseMap();
                config.CreateMap<IEnumerable<Cliente>, IEnumerable<ReadClienteDTO>>().ReverseMap();
                config.CreateMap<Cliente, ReadClienteDTO>().ReverseMap();
                config.CreateMap<Cliente, UpdateClienteDTO>().ReverseMap();

                config.CreateMap<Endereco, CreateEnderecoDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Endereco>, IEnumerable<ReadEnderecoDTO>>().ReverseMap();
                config.CreateMap<Endereco, ReadEnderecoDTO>().ReverseMap();
                config.CreateMap<Endereco, UpdateEnderecoDTO>().ReverseMap();

                config.CreateMap<Estado, CreateEstadoDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Estado>, IEnumerable<ReadEstadoDTO>>().ReverseMap();
                config.CreateMap<Estado, ReadEstadoDTO>().ReverseMap();
                config.CreateMap<Estado, UpdateEstadoDTO>().ReverseMap();

                config.CreateMap<FilmeAtor, CreateFilmeAtorDTO>().ReverseMap();
                config.CreateMap< IEnumerable<FilmeAtor>, IEnumerable<ReadFilmeAtorDTO>>().ReverseMap();
                config.CreateMap<FilmeAtor, ReadFilmeAtorDTO>().ReverseMap();
                config.CreateMap<FilmeAtor, UpdateFilmeAtorDTO>().ReverseMap();

                config.CreateMap<Filme, CreateFilmeDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Filme>, IEnumerable<ReadFilmeDTO>>().ReverseMap();
                config.CreateMap<Filme, ReadFilmeDTO>().ReverseMap();
                config.CreateMap<Filme, UpdateFilmeDTO>().ReverseMap();

                config.CreateMap<Funcionario, CreateFuncionarioDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Funcionario>, IEnumerable<ReadFuncionarioDTO>>().ReverseMap();
                config.CreateMap<Funcionario, ReadFuncionarioDTO>().ReverseMap();
                config.CreateMap<Funcionario, UpdateFuncionarioDTO>().ReverseMap();

                config.CreateMap<Genero, CreateGeneroDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Genero>, IEnumerable<ReadGeneroDTO>>().ReverseMap();
                config.CreateMap<Genero, ReadGeneroDTO>().ReverseMap();
                config.CreateMap<Genero, UpdateGeneroDTO>().ReverseMap();

                config.CreateMap<Pedido, CreatePedidoDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Pedido>, IEnumerable<ReadPedidoDTO>>().ReverseMap();
                config.CreateMap<Pedido, ReadPedidoDTO>().ReverseMap();
                config.CreateMap<Pedido, UpdatePedidoDTO>().ReverseMap();

                config.CreateMap<PedidoFilme, CreatePedidoFilmeDTO>().ReverseMap();
                config.CreateMap< IEnumerable<PedidoFilme>, IEnumerable<ReadPedidoFilmeDTO>>().ReverseMap();
                config.CreateMap<PedidoFilme, ReadPedidoFilmeDTO>().ReverseMap();
                config.CreateMap<PedidoFilme, UpdatePedidoFilmeDTO>().ReverseMap();

                config.CreateMap<Produtora, CreateProdutoraDTO>().ReverseMap();
                config.CreateMap< IEnumerable<Produtora>, IEnumerable<ReadProdutoraDTO>>().ReverseMap();
                config.CreateMap<Produtora, ReadProdutoraDTO>().ReverseMap();
                config.CreateMap<Produtora, UpdateProdutoraDTO>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
