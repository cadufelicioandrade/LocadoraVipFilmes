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
                config.CreateMap<Ator, ReadAtorDTO>()
                        .ForMember(a => a.ReadFilmeAtorDTOs, opt =>
                                opt.MapFrom(a => a.FilmeAtors)).ReverseMap();
                config.CreateMap<Ator, UpdateAtorDTO>().ReverseMap();

                config.CreateMap<Cidade, CreateCidadeDTO>().ReverseMap(); 
                config.CreateMap<Cidade, ReadCidadeDTO>()
                        .ForMember(c => c.ReadEstadoDTO, opt =>
                                    opt.MapFrom(c => c.Estado))
                        .ForMember(c => c.ReadEnderecoDTOs, opt =>
                                    opt.MapFrom(c => c.Enderecos)).ReverseMap();
                config.CreateMap<Cidade, UpdateCidadeDTO>()
                        .ForMember(c => c.ReadEstadoDTO, opt => 
                            opt.MapFrom(c => c.Estado)).ReverseMap();

                config.CreateMap<Cliente, CreateClienteDTO>()
                        .ForMember(c => c.CreateEnderecoDTO, opt =>
                            opt.MapFrom(c => c.Endereco)).ReverseMap();
                config.CreateMap<Cliente, ReadClienteDTO>()
                        .ForMember(c => c.ReadPedidoDTOs, opt =>
                            opt.MapFrom(c => c.Pedidos))
                        .ForMember(c => c.ReadEnderecoDTO, opt =>
                            opt.MapFrom(c => c.Endereco)).ReverseMap();
                config.CreateMap<Cliente, UpdateClienteDTO>()
                        .ForMember(c => c.UpdateEnderecoDTO, opt =>
                            opt.MapFrom(c => c.Endereco)).ReverseMap();

                config.CreateMap<Endereco, CreateEnderecoDTO>().ReverseMap();
                config.CreateMap<Endereco, ReadEnderecoDTO>()
                        .ForMember(e => e.ReadCidadeDTO, opt =>
                            opt.MapFrom(c => c.Cidade)).ReverseMap();
                config.CreateMap<Endereco, UpdateEnderecoDTO>().ReverseMap();

                config.CreateMap<Estado, CreateEstadoDTO>().ReverseMap();
                config.CreateMap<Estado, ReadEstadoDTO>()
                        .ForMember(e => e.ReadCidadeDTOs, opt =>
                            opt.MapFrom(f => f.Cidades)).ReverseMap();
                config.CreateMap<Estado, UpdateEstadoDTO>().ReverseMap();

                config.CreateMap<FilmeAtor, CreateFilmeAtorDTO>().ReverseMap();
                config.CreateMap<FilmeAtor, ReadFilmeAtorDTO>()
                        .ForMember(f => f.ReadFilmeDTO, opt =>
                            opt.MapFrom(f => f.Filme))
                        .ForMember(f => f.ReadAtorDTO, opt =>
                            opt.MapFrom(f => f.Ator)).ReverseMap();
                config.CreateMap<FilmeAtor, UpdateFilmeAtorDTO>().ReverseMap();

                config.CreateMap<Filme, CreateFilmeDTO>().ReverseMap();
                config.CreateMap<Filme, ReadFilmeDTO>()
                    .ForMember(f => f.ReadGeneroDTO, opt =>
                opt.MapFrom(f => f.Genero))
                    .ForMember(f => f.ReadProdutoraDTO, opt =>
                opt.MapFrom(f => f.Produtora))
                    .ForMember(f => f.ReadPedidoFilmeDTOs, opt =>
                opt.MapFrom(f => f.PedidoFilmes)).ReverseMap();
                config.CreateMap<Filme, UpdateFilmeDTO>().ReverseMap();

                config.CreateMap<Funcionario, CreateFuncionarioDTO>().ReverseMap();
                config.CreateMap<Funcionario, ReadFuncionarioDTO>().ReverseMap();
                config.CreateMap<Funcionario, UpdateFuncionarioDTO>().ReverseMap();

                config.CreateMap<Genero, CreateGeneroDTO>().ReverseMap();
                config.CreateMap<Genero, ReadGeneroDTO>().ReverseMap();
                config.CreateMap<Genero, UpdateGeneroDTO>().ReverseMap();

                config.CreateMap<Pedido, CreatePedidoDTO>()
                    .ForMember(p => p.CreatePedidoFilmeDTOs, opt => 
                        opt.MapFrom(p => p.PedidoFilmes)).ReverseMap();
                config.CreateMap<Pedido, ReadPedidoDTO>()
                    .ForMember(p => p.ReadPedidoFilmeDTOs, opt =>
                        opt.MapFrom(p => p.PedidoFilmes)).ReverseMap();
                config.CreateMap<Pedido, UpdatePedidoDTO>().ReverseMap();

                config.CreateMap<PedidoFilme, CreatePedidoFilmeDTO>().ReverseMap();
                config.CreateMap<PedidoFilme, ReadPedidoFilmeDTO>()
                    .ForMember(p => p.ReadPedidoDTO, opt =>
                        opt.MapFrom(p => p.Pedido))
                    .ForMember(p => p.ReadFilmeDTO, opt =>
                        opt.MapFrom(p => p.Filme)).ReverseMap();
                config.CreateMap<PedidoFilme, UpdatePedidoFilmeDTO>().ReverseMap();

                config.CreateMap<Produtora, CreateProdutoraDTO>().ReverseMap();
                config.CreateMap<Produtora, ReadProdutoraDTO>().ReverseMap();
                config.CreateMap<Produtora, UpdateProdutoraDTO>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
