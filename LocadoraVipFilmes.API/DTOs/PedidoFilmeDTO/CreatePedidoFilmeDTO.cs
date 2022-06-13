﻿using LocadoraVipFilmes.API.DTOs.FilmeDTO;
using LocadoraVipFilmes.API.DTOs.PedidoDTO;

namespace LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO
{
    public class CreatePedidoFilmeDTO
    {
        public double ValorUnitario { get; set; }
        public int PedidoId { get; set; }
        public int FilmeId { get; set; }
        public ReadFilmeDTO  ReadFilmeDTO { get; set; }
        public ReadPedidoDTO ReadPedidoDTO { get; set; }
    }
}
