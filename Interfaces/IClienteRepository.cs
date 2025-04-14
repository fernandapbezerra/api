using EcommerceAPI.Models;

namespace EcommerceAPI.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> ListarTodos();
        Cliente BuscarPorId(int id);
        Cliente BuscarPorEmailSenha (string email, string senha);
        void Cadastrar(Cliente cliente);
        void Atualizar(int id, Cliente cliente);
        void Deletar(int id);
    }
}
    