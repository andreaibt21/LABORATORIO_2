using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        /// <summary>
        /// El constructor estático instanciará la lista estática appsInstaladas,
        /// y seteará el sistema operativo de este dispositivo en ANDROID.
        /// </summary>
        static Dispositivo()
        {
            Dispositivo.appsInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }
        #region Metodos

        /// <summary>
        /// El método InstalarApp recibirá por parámetro una aplicación para ser instalada. 
        /// Antes de intentar instalarla, debe comprobarse que sea compatible para 
        /// ese sistema operativo. Una vez comprobado que es compatible, 
        /// intentará añadir esa aplicación a la lista de aplicaciones. 
        /// Devolverá true si logra añadirla. Reutilizar código.
        /// </summary>
        /// <param name="App"></param>
        /// <returns></returns>
        public static bool InstalarApp(Aplicacion app)
        {
            if (app is not null && app.SistemaOperativo == SistemaOperativo.ANDROID)
            {
                return appsInstaladas+app;
               
            }
            return false;
        }


        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Aplicacion item in appsInstaladas)
            {
                sb.AppendLine(item.ObtenerInformacionApp());
           
            }

            return sb.ToString();
        }
        #endregion




    }

}
