using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public class GestorBD
    {

        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        static GestorBD()
        {
            conexion = new SqlConnection(@"Server=DESKTOP-EA73OGJ;Database=Comiqueria;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.Connection = conexion;

        }
        #region Propiedades

        public static SqlConnection Conexion
        {
            get
            {
                return GestorBD.conexion;
            }
        }

        public static SqlCommand Comando
        {
            get
            {
                return GestorBD.comando;
            }
        }
        #endregion

      /// <summary>
      /// Insertar a la tabla 
      /// </summary>
      /// <param name="descripcion"></param>
      /// <param name="precio"></param>
      /// <param name="stock"></param>
        public static void Insert(string descripcion, double precio, int stock)
        {
            try
            {
                conexion.Open();
                GestorBD.Comando.CommandText = "INSERT INTO dbo.Productos (descripcion, precio, stock) VALUES (@descripcion, @precio, @stock);";
                GestorBD.Comando.Parameters.Clear();
                GestorBD.Comando.Parameters.AddWithValue("@descripcion", descripcion);
                GestorBD.Comando.Parameters.AddWithValue("@precio", precio);
                GestorBD.Comando.Parameters.AddWithValue("@stock", stock);

                Comando.ExecuteNonQuery();

            }
            catch (ComiqueriaException)
            {

                throw;
            }
            finally
            {
                conexion.Close();

            }
        }


        public static void Delete(string descripcion, double precio, int stock)
        {
            try
            {
                conexion.Open();
                GestorBD.Comando.CommandText = "DELETE INTO dbo.Productos (descripcion, precio, stock) VALUES (@descripcion, @precio, @stock);";
                GestorBD.Comando.Parameters.Clear();
                GestorBD.Comando.Parameters.AddWithValue("@descripcion", descripcion);
                GestorBD.Comando.Parameters.AddWithValue("@precio", precio);
                GestorBD.Comando.Parameters.AddWithValue("@stock", stock);

                Comando.ExecuteNonQuery();

            }
            catch (ComiqueriaException)
            {

                throw;
            }
            finally
            {
                conexion.Close();

            }
        }








    }

}
