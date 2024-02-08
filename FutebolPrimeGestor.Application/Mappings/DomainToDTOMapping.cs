using AutoMapper;
using FutebolPrimeGestor.Application.DTOs;
using FutebolPrimeGestor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Application.Mappings
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Quadra, QuadraDTO>().ReverseMap();
            CreateMap<AluguelDeQuadra, AluguelDeQuadraDTO>().ReverseMap();
        }
    }
}
