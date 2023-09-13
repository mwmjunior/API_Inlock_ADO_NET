using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private string stringConexao = "Data Source = 127.0.0.1; Initial Catalog = inlock_games; User Id = sa; Pwd = mwm123";
        public List<TiposUsuarioDomain> ListarTodos()
        {
            List<TiposUsuarioDomain> exibirTiposUsuario = new List<TiposUsuarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT IdTipoUsuario, Titulo FROM TiposUsuario";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        TiposUsuarioDomain estudio = new TiposUsuarioDomain
                        {
                            IdTipoUsuario = Convert.ToInt32(rdr[("IdTipoUsuario")]),
                            Titulo = rdr["Titulo"].ToString()
                        };

                        exibirTiposUsuario.Add(estudio);
                    }
                }
            }

            return exibirTiposUsuario;
        }
    }
}
