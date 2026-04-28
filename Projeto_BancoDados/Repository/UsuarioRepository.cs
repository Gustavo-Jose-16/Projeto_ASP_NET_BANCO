using MySql.Data.MySqlClient;
using Projeto_BancoDados.Models;
using Projeto_BancoDados.Repository.Contract;
using System.Data;

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
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into usuario(nomeUsu, Cargo, DataNasc) " +
                                                " values (@nomeUsu, @Cargo, @DataNasc )", conexao); // @: PARAMETRO

                cmd.Parameters.Add("@nomeUsu", MySqlDbType.VarChar).Value = usuario.nomeUsu;
                cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = usuario.Cargo;
                // cmd.Parameters.Add("@DataNasc", MySqlDbType.VarChar).Value = usuario.DataNasc.ToString("yyyy/MM/dd");
                cmd.Parameters.Add("@DataNasc", MySqlDbType.VarChar).Value = usuario.DataNasc.ToString("yyyy/MM/dd");

                cmd.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            List<Usuario> UsuarioList = new List<Usuario>();
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexao.Close(); // Ajustado de Clone para Close

                foreach (DataRow dr in dt.Rows)
                {
                    UsuarioList.Add(new Usuario
                    {
                        idUsu = Convert.ToInt32(dr["IdUsu"]),
                        nomeUsu = dr["nomeUsu"].ToString(),
                        Cargo = dr["Cargo"].ToString(),
                        DataNasc = Convert.ToDateTime(dr["DataNasc"])
                    });
                }
                return UsuarioList;
            }
        }


        public Usuario ObterUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
