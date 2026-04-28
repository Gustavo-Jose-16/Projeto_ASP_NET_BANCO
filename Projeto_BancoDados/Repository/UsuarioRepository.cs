using Projeto_BancoDados.Models;
using Projeto_BancoDados.Repository.Contract;

namespace Projeto_BancoDados.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _conexaoMySQL;

        public UsuarioRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");  
        }
        public void AtualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
