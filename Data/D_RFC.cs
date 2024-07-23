using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class D_RFC
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["sql_RFCDB"].ConnectionString;

        public void CreateUser(E_RFC user, string rfc) //Recibe los datos del usuario y la cadena correspondiente al RFC (calculado en la capa de Negocio)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("add_user", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", user.Name.ToUpper());
                command.Parameters.AddWithValue("@paternalsurname", user.PaternalSurname.ToUpper());
                if (user.MaternalSurname != null)
                {
                    command.Parameters.AddWithValue("@maternalsurname", user.MaternalSurname.ToUpper());
                }
                else
                {
                    command.Parameters.AddWithValue("@maternalsurname", ' '); // Si el apellido materno es nulo, introducimos en blanco
                }
                command.Parameters.AddWithValue("@birthdate", user.BirthDate);
                command.Parameters.AddWithValue("@rfc", rfc.ToUpper());

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
