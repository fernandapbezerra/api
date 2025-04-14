﻿namespace EcommerceAPI.Repositories
{
   
    using EcommerceAPI.Context;
    using EcommerceAPI.Interfaces;
    using EcommerceAPI.Models;

    namespace API_ECommerce.Repositories
    {
        // 1 - Herdar da Interface
        // 2 - Implementar a Interface
        // 3 - Injetar o Contexto
        public class ClienteRepository : IClienteRepository
        {
            private readonly EcommerceContext _context;

            public ClienteRepository(EcommerceContext context)
            {
                _context = context;
            }

            public void Atualizar(int id, Cliente cliente)
            {
                throw new NotImplementedException();
            }

            public Cliente BuscarPorEmailSenha(string email, string senha)
            {
                throw new NotImplementedException();
            }

            public Cliente BuscarPorId(int id)
            {
                throw new NotImplementedException();
            }

            public void Cadastrar(Cliente cliente)
            {
                 _context.Clientes.Add(cliente); 
            }

            public void Deletar(int id)
            {
                throw new NotImplementedException();
            }

            public List<Cliente> ListarTodos()
            {
                return _context.Clientes.ToList();
            }
        }
    }
}
