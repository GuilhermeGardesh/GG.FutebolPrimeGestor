using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Domain.Entities
{
    public class AluguelDeQuadra : Entity
    {
        public AluguelDeQuadra() { }

        public AluguelDeQuadra(Cliente? cliente,
            Quadra? quadra,
            DateTime inicioAluguel,
            DateTime fimAluguel,
            double valorFinalAluguel)
        {
            Cliente = cliente;
            Quadra = quadra;
            InicioAluguel = inicioAluguel;
            FimAluguel = fimAluguel;
            ValorFinalAluguel = valorFinalAluguel;
        }

        public Guid IdCliente { get; private set; }
        public Guid IdQuadra { get; private set; }
        public Cliente? Cliente { get; private set; }
        public Quadra? Quadra { get; private set; }
        public DateTime InicioAluguel { get; private set; }
        public DateTime FimAluguel { get; private set; }
        public double? ValorFinalAluguel { get; private set; }
    }
}
