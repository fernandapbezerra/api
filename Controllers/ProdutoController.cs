using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;
using EcommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IProdutoRepository _produtoRepository;
        //CTOR: Metodo construtor. 
        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository =  new ProdutoRepository(_context);

        }
        //GET 

        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        //Cadastrar Produto
        [HttpPost]

        public IActionResult CadastrarProduto(Produto prod)
        {
            //1 - Coloco o produto no Banco de Dados
            _produtoRepository.Cadastrar(prod);

            //2-Salvo a alteracao (padrao)
            _context.SaveChanges();
            
            //3- Retorno o resultado
            //201 - Created
            return Created();
        }
       
    }
}
