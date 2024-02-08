using FutebolPrimeGestor.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> Add(ClienteDTO cliente);
        Task<ClienteDTO> Update(ClienteDTO cliente);
    }
}
