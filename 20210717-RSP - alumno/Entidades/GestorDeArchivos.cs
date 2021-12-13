using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorDeArchivos : IGuardar<AutoF1>, IGuardar<Carrera>
    {
        // a.Generar una clase que implemente la interfaz de forma implícita y
        //  explicita(ver diagrama), la cual se utilizara para:
        //    i.Texto: Almacenar la llegada de los vehículos a la meta.
        //    ii.Serializar en formato XML los datos de la Carrera al cerrar la aplicación.
        // b.De no poder leer el archivo, lanzar excepción propia ArchivoExcept

        private string archivo;
        public GestorDeArchivos(string ruta)
        {
           
        }
        public void Guardar(AutoF1 tipo)
        {
          //  throw new NotImplementedException();
        }
        void IGuardar<AutoF1>.Guardar(AutoF1 tipo)
        {
           throw new NotImplementedException();

        }


        public void Guardar(Carrera carrera)
        {
           // throw new NotImplementedException();
        }

        public static string CrearLaRuta(string nombreArchivo)
        {
            string auxRuta = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(auxRuta, nombreArchivo);
            return rutaArchivo;
        }
        public static void SerializarAJason<T>(string ruta, T obj) where T : class
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
            jsonSerializerOptions.WriteIndented = true;

            string objetoJson = JsonSerializer.Serialize(obj, jsonSerializerOptions);

            File.WriteAllText(ruta, objetoJson);
        }
    }
}
