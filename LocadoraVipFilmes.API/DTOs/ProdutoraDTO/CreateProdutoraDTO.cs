﻿using LocadoraVipFilmes.API.DTOs.FilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.ProdutoraDTO
{
    public class CreateProdutoraDTO
    {
        public string NomeProdutora { get; set; }
        public List<ReadFilmeDTO>  ReadFilmeDTOs { get; set; }
    }
}
