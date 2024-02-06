namespace FutebolPrimeGestor.Application.DTOs
{
    public class QuadraDTO
    {
        public Guid Id { get; set; }
        public int TipoQuadra { get; private set; }
        public int Numero { get; private set; }
        public double Valor { get; private set; }
        public bool Ativa { get; private set; }
        public DateTime HorarioInicioFuncionamento { get; private set; }
        public DateTime HorarioFimFuncionamento { get; private set; }
    }
}
