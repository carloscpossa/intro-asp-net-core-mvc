using IntroducaoAspNetCoreMvc.Models;

namespace IntroducaoAspNetCoreMvc.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private static Dictionary<int, ClienteModel> clientes;

        public ClienteRepositorio()
        {
            if (clientes == null)
                clientes = new Dictionary<int, ClienteModel>();
        }

        public void Adicionar(ClienteModel cliente)
        {            
            clientes.Add(clientes.Count() + 1, cliente);
        }

        public IEnumerable<ClienteModel> ObterClientes() => clientes.Values;

        public ClienteModel ObterPelaChave(int chave) => clientes[chave];        
    }
}
