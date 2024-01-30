namespace FutebolPrimeGestor.Domain.Entities
{
    public class Quadra : Entity
    {
        public Quadra() { }
        public Quadra(TipoQuadra tipoQuadra,
            int numero,
            double valor,
            bool ativa, DateTime horarioInicioFuncionamento, DateTime horarioFimFuncionamento)
        {
            TipoQuadra = tipoQuadra;
            Numero = numero;
            Valor = valor;
            Ativa = ativa;
            HorarioInicioFuncionamento = horarioInicioFuncionamento;
            HorarioFimFuncionamento = horarioFimFuncionamento;
        }

        public TipoQuadra TipoQuadra { get; private set; }
        public int Numero { get; private set; }
        public double Valor { get; private set; }
        public bool Ativa { get; private set; }
        public DateTime HorarioInicioFuncionamento { get; private set; }
        public DateTime HorarioFimFuncionamento { get; private set; }

        public List<AluguelDeQuadra> AlugueisDeQuadras { get; private set; }
    }

    public enum TipoQuadra
    {
        Areia,
        Society
    }
}
