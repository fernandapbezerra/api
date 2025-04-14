using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        //Metodos que acessam o banco de dados
        //Injetar o Context 
        private readonly EcommerceContext _context;

        //CTOR: Metodo construtor. 
        public ProdutoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
           return _context.Produtos.ToList();
        }
    }
}
