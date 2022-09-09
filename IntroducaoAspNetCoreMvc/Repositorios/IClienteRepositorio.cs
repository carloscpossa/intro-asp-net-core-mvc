using IntroducaoAspNetCoreMvc.Models;

namespace IntroducaoAspNetCoreMvc.Repositorios
{
    public interface IClienteRepositorio
    {
        void Adicionar(ClienteModel cliente);
        IEnumerable<ClienteModel> ObterClientes();
        ClienteModel ObterPelaChave(int chave);

    }
}
