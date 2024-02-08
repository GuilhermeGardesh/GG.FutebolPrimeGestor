using FutebolPrimeGestor.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Application.Interfaces
{
    public interface IAluguelDeQuadraService
    {
        Task<AluguelDeQuadraDTO> Add(AluguelDeQuadraDTO aluguelDeQuadra);
        Task<AluguelDeQuadraDTO> Update(AluguelDeQuadraDTO aluguelDeQuadra);
    }
}
