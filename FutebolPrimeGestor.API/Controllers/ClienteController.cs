using FutebolPrimeGestor.Application.DTOs;
using FutebolPrimeGestor.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutebolPrimeGestor.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ClienteDTO>> Create(ClienteDTO cliente)
        {
            _clienteRepository.
            return cliente;
        }
    }
}
