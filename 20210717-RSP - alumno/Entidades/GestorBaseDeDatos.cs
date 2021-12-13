using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public class GestorBaseDeDatos : IGuardar<AutoF1>
    {
        private static string cadenaConexion;


        /// <summary>
        /// Constructor por defecto
        /// </summary>
        static GestorBaseDeDatos()
        {
            cadenaConexion = @"Data Source=.; Initial Catalog = 20210717-RSP; Integrated Security = true;";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="autoF1">Auto</param>
        public void Guardar(AutoF1 autoF1)//Implementacion de la Interfaz IGuardar. Almacena la llegada de los autos a la meta.
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand();

                    conexion.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Connection = conexion;

                    comando.CommandText = "INSERT INTO resultados(escuderia, posicion, horaLlegada) VALUES(@escuderia, @posicion, @horaLlegada)";
                    comando.Parameters.AddWithValue("@escuderia", autoF1.Escuderia);
                    comando.Parameters.AddWithValue("@posicion", autoF1.Posicion);
                    comando.Parameters.AddWithValue("@horaLlegada", DateTime.Now.ToString());

                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar los datos.", ex);
            }
        }
    }

}
