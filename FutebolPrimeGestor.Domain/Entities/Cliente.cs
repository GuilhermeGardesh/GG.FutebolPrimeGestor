using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Domain.Entities
{
    public class Cliente : Entity
    {
        public Cliente() { }
        public Cliente(string? nome, string? cpf, string? contato)
        {
            Nome = nome;
            CPF = cpf;
            Contato = contato;
        }

        public string? Nome { get; private set; }
        public string? CPF { get; private set; }
        public string? Contato {  get; private set; }

        public List<AluguelDeQuadra> AlugueisDeQuadras { get; private set; }
    }
}
