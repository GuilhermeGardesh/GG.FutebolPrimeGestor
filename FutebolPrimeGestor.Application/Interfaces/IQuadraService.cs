using FutebolPrimeGestor.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Application.Interfaces
{
    public interface IQuadraService
    {
        Task<QuadraDTO> Add(QuadraDTO quadra);
        Task<QuadraDTO> Update(QuadraDTO quadra);
    }
}
