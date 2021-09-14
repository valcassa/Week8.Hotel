using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaException
{
    class UtenteRepository: IUtenteRepository
    {

        const string connectionString = @"Data Source = (localdb)\mssqllocaldb;" +
                                       "Initial Catalog = Utente;" +
                                       "Integrated Security = true;";

        const string discriminator = "Utente";

        public static UtenteRepository utenteRepository = new UtenteRepository();
        List<Utente> users = new List<Utente>();

        public List<Utente> Fetch()
        {
            List<Utente> users = new List<Utente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Utente";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = (string)reader["NomeUtente"];
                    var psw = (string)reader["Password"];
                    var id = (int)reader["Id"]; 

                    Utente usern = new Utente(user, psw, id);

                    users.Add(usern);
                }
            }
            return users;
        }
    }
}
