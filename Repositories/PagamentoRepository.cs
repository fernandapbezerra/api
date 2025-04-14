namespace EcommerceAPI.Repositories
{
    using System.Collections.Generic;
    using EcommerceAPI.Context;
    using EcommerceAPI.Interfaces;
    using EcommerceAPI.Models;

    namespace API_ECommerce.Repositories
    {
        public class PagamentoRepository : IPagamentoRepository
        {
            
        //Metodos que acessam o banco de dados
        //Injetar o Context 
        private readonly EcommerceContext _context;

            //CTOR: Metodo construtor. 
            public PagamentoRepository(EcommerceContext context)
            {
                _context = context;
            }
            public void Atualizar(int id, Pagamento pagamento)
            {
                throw new NotImplementedException();
            }

            public Pagamento BuscarPorId(int id)
            {
                throw new NotImplementedException();
            }

            public void Cadastrar(Pagamento pagamento)
            {
                _context.Pagamentos.Add(pagamento);
            }

            public void Deletar(int id)
            {
                throw new NotImplementedException();
            }

            public List<Pagamento> ListarTodos()
            {
               return _context.Pagamentos.ToList();
            }
        
            
        
        }
    }
}