using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Application.DTOs
{
    public class ClienteDTO
    {
        public Guid Id{ get; set; }
        public string? Nome { get; private set; }
        public string? CPF { get; private set; }
        public string? Contato { get; private set; }
    }
}
