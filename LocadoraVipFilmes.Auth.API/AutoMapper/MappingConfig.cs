using AutoMapper;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Model;

namespace LocadoraVipFilmes.Auth.API.AutoMapper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CreateUsuarioDTO, Usuario>().ReverseMap();
            });

            return mappingConfig;
        } 
    }
}
