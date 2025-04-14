using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Repositories;
using EcommerceAPI.Repositories.API_ECommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IClienteRepository _ClienteRepository;

        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _ClienteRepository = new ClienteRepository(_context);
        }
    }

}