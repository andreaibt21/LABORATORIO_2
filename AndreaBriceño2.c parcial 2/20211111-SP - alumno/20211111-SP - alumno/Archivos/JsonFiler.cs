using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Archivos
{
    public class JsonFiler<T> : IMetodosArchivos<T> where T : class
    {

        /// <summary>
        /// Genera un path donde se puede guardar el archivo
        /// </summary>
        /// <param name="titulo">que tiene el archivo</param>
        /// <returns>path donde se encuentra el archivo</returns>
            
        public string GenerarRuta 
        { get {

                try
                {
                    string ruta = AppDomain.CurrentDomain.BaseDirectory;
                    string rutaFinal = Path.Combine(ruta, "/");
           //         string rutaFinal = Path.Combine(ruta, "\Desktop\.json");
                    return rutaFinal;
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo generar la ruta", ex);
                }

            }
        }

        public bool ExisteArchivo(string nombreArchivo)
        {
            string path = GenerarRuta;
            string rutaFinal = Path.Combine(GenerarRuta, nombreArchivo);
            return File.Exists(rutaFinal);
        }

        public void Guardar(string archivo, T objeto)
        {
            try
            {
                if (objeto is null)
                {
                    throw new Exception("objeto nulo");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);

                File.WriteAllText(archivo, objetoJson);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException(ex.Message);
            }
        }

        public void Leer(string archivo, T objeto)
        {

            try
            {
                string objetoJson = File.ReadAllText(archivo);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                {
                    Converters =
                    { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
                };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                // return objetoDeserealizado;

            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException(ex.Message);
            }


        }
    }
}
