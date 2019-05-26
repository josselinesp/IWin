using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iwin1._2.Domain;

namespace Iwin1._2.Data
{
    public class JuegoData
    {

        public List<Juego> listarJuegos()
        {

            Juego juego;
            List<Juego> juegoList = new List<Juego>();
            string connectionString = "Server=163.178.107.130; Database=iwincjm; Uid= laboratorios; Pwd=UCRSA.118;";
            // Tu consulta en SQL
            string query = "SELECT * FROM Juego";

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
                    juego = new Juego();
                    juego.Identificador = reader.GetInt32("identificador");
                    juego.IdentificadorCampeonato = reader.GetInt32("identificador_campeonato");
                    juego.EquipoA = reader.GetInt32("equipo_A");
                    juego.EquipoB = reader.GetInt32("equipo_B");
                    juego.FechaJuego = reader.GetDateTime("fecha_juego");
                    juego.EstadoJuego = reader.GetBoolean("estado_juego");
                    juego.Lugar = reader.GetString("lugar");
                    juego.ArbitroAsignado = reader.GetString("arbitro_asignado");

                    juegoList.Add(juego);
                }
            }
            else
            {

                Console.WriteLine("No se encontraron datos.");
            }

            // Cerrar la conexión
            databaseConnection.Close();


            return juegoList;
        }



        public List<Juego> listarJuegosPorCampeonato(Int32 identificadorCampeonato)
        {
            
            Juego juego;
            List<Juego> juegoList = new List<Juego>();
            string connectionString = "Server=163.178.107.130; Database=iwincjm; Uid= laboratorios; Pwd=UCRSA.118;";
            // Tu consulta en SQL
            string query = "SELECT * FROM Juego WHERE identificador_campeonato=" + identificadorCampeonato;

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
                    juego = new Juego();
                    juego.Identificador = reader.GetInt32("identificador");
                    juego.IdentificadorCampeonato = reader.GetInt32("identificador_campeonato");
                    juego.EquipoA = reader.GetInt32("equipo_A");
                    juego.EquipoB = reader.GetInt32("equipo_B");
                    juego.FechaJuego = reader.GetDateTime("fecha_juego");
                    juego.EstadoJuego = reader.GetBoolean("estado_juego");
                    juego.Lugar = reader.GetString("lugar");
                    juego.ArbitroAsignado = reader.GetString("arbitro_asignado");

                    juegoList.Add(juego);
                }
            }
            else
            {

                Console.WriteLine("No se encontraron datos.");
            }

            // Cerrar la conexión
            databaseConnection.Close();


            return juegoList;
        }



        public Juego listarJuegoPorIdentificador(Int32 identificadorJuego)
        {

            Juego juego = new Juego();
            
            string connectionString = "Server=163.178.107.130; Database=iwincjm; Uid= laboratorios; Pwd=UCRSA.118;";
            // Tu consulta en SQL
            string query = "SELECT * FROM Juego WHERE identificador=" + identificadorJuego;

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
                    juego.Identificador = reader.GetInt32("identificador");
                    juego.IdentificadorCampeonato = reader.GetInt32("identificador_campeonato");
                    juego.EquipoA = reader.GetInt32("equipo_A");
                    juego.EquipoB = reader.GetInt32("equipo_B");
                    juego.FechaJuego = reader.GetDateTime("fecha_juego");
                    juego.EstadoJuego = reader.GetBoolean("estado_juego");
                    juego.Lugar = reader.GetString("lugar");
                    juego.ArbitroAsignado = reader.GetString("arbitro_asignado");

                }
            }
            else
            {

                Console.WriteLine("No se encontraron datos.");
            }

            // Cerrar la conexión
            databaseConnection.Close();


            return juego;
        }

    

        public void actualizarJuego(Juego jueg)
        {

            Juego juego= new Juego();
            juego = jueg; 
          
            string connectionString = "Server=163.178.107.130; Database=iwincjm; Uid= laboratorios; Pwd=UCRSA.118;";
            // Tu consulta en SQL
            string query = "UPDATE juego SET identificador_campeonato="+juego.IdentificadorCampeonato+ ",equipo_A="+juego.EquipoA+ ",equipo_B="+juego.EquipoB+ ",fecha_juego="+juego.FechaJuego+ ",estado_juego="+juego.EstadoJuego+ ",arbitro_asignado="+ juego.ArbitroAsignado + " WHERE identifcador="+juego.Identificador;


            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            // Abre la base de datos
            databaseConnection.Open();

            // Ejecuta la consultas
            reader = commandDatabase.ExecuteReader();

            // actualizooo


            // Cerrar la conexión
            databaseConnection.Close();

        }


    }
}