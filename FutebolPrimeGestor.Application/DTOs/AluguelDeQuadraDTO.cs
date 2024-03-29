﻿namespace FutebolPrimeGestor.Application.DTOs
{
    public class AluguelDeQuadraDTO
    {
        public Guid Id { get; private set; }
        public Guid IdCliente { get; private set; }
        public Guid IdQuadra { get; private set; }
        //public Cliente? Cliente { get; private set; }
        //public Quadra? Quadra { get; private set; }
        public DateTime InicioAluguel { get; private set; }
        public DateTime FimAluguel { get; private set; }
        public double? ValorFinalAluguel { get; private set; }
    }
}
