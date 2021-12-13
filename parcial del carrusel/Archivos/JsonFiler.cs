using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Archivos
{
    public class JsonFiler<T> : IMetodosArchivos<T>
    {
        string archivo;
        /// <summary>
        /// Retornará la ruta al escritorio (debe ser independiente de la máquina en
        ///la que se abra el programa). Concatenar la barra final \ siendo la ruta retornada: C:\...\Desktop\
        /// </summary>
        public string GenerarRutaCompleta
        {
            get 
            {
                return  Environment.GetFolderPath(
                           Environment.SpecialFolder.Desktop) 
                           + "\\"; 
            }
        }
        /// <summary>
        /// Comprobará si el archivo existe o no y validara el dato recibo por parametro.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns>Retorna true si existe</returns>
        public bool ExisteArchivo(string nombreArchivo)
        {
            if (!string.IsNullOrWhiteSpace(nombreArchivo))
            {
                string rutaArchivo = Path.Combine(this.GenerarRutaCompleta, nombreArchivo);
                return File.Exists(rutaArchivo);
            }
            return false;
        }
        /// <summary>
        /// Guardara el objeto generico pasado parametro si es posible y valido el nombre del archivo pasado por parametro
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="Objeto"></param>
        public void Guardar(string nombreArchivo, T objeto)
        {
            try
            {
                if (objeto is null)
                {
                    throw new Exception("objeto nulo");
                }
                if (string.IsNullOrWhiteSpace(nombreArchivo))
                {
                    throw new ErrorArchivosException("Nombre de archivo invalido");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;
                string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
                File.WriteAllText(nombreArchivo, objetoJson);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Leer(string archivo, out T objeto)
        {
            throw new NotImplementedException();
        }
    }
}
