using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domain;

namespace WebApplication1.Data
{
    public class JugadorData
    {

        String connectionString = "Server=allanserverdbmysql.mysql.database.azure.com; Database=hidroquim; Uid=admindev@allanserverdbmysql; Pwd=Admin12345678!;";

        public JugadorData()
        {
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }



        public List<Jugador> GetAllJugadores()
        {
            Jugador jugador;
            List<Jugador> jugadorList = new List<Jugador>();
            using (MySqlConnection sqlCon = GetConnection())
            {
                
                sqlCon.Open();
                String query = "select * from jugador;";

                MySqlCommand sqlSelect = new MySqlCommand(query, sqlCon);

                using (MySqlDataReader reader = sqlSelect.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        jugador = new Jugador();
                        jugador.Identificacion = reader.GetString("identificacion");
                        jugador.Nombre = reader.GetString("nombre");
                        jugador.Apellidos = reader.GetString("apellidos");
                        jugador.FechaNacimiento = reader.GetDateTime("fecha_nacimiento");
                        jugador.IdEquipo = reader.GetInt32("identificador_equipo");

                        jugadorList.Add(jugador);

                    }
                    sqlCon.Close();

                }
            }
            return jugadorList;





        }


        public List<Jugador> d()
        {

            Jugador jugador;
            List<Jugador> jugadorList = new List<Jugador>();
            string connectionString = "Server=163.178.107.130; Database=iwincjm; Uid= laboratorios; Pwd=UCRSA.118;";
            // Tu consulta en SQL
            string query = "SELECT * FROM Jugador";

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // A consultar !
          
                // Abre la base de datos
                databaseConnection.Open();

                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();

                // Hasta el momento todo bien, es decir datos obtenidos

                // IMPORTANTE :#
                // Si tu consulta retorna un resultado, usa el siguiente proceso para obtener datos
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        jugador = new Jugador();
                        jugador.Identificacion = reader.GetString("identificacion");
                        jugador.Nombre = reader.GetString("nombre");
                        jugador.Apellidos = reader.GetString("apellidos");
                        jugador.FechaNacimiento = reader.GetDateTime("fecha_nacimiento");
                        jugador.IdEquipo = reader.GetInt32("identificador_equipo");

                        jugadorList.Add(jugador);
                    }
                }
                else
                {

                    Console.WriteLine("No se encontraron datos.");
                }

                // Cerrar la conexión
                databaseConnection.Close();
            

            return jugadorList;
        }





    }
}
