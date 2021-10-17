using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short ano;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short ano, Divisiones division): base(nombre,  apellido,  documento)
        {
            this.ano = ano;
            this.division = division;
        }


        #region PROPIEDADES

        /// <summary>
        /// propiedad de lectura para el atributo ano
        /// La propiedad AnioDivision retornará un string con el siguiente formato: XºZ, siendo X el año que se
        /// encuentra cursando y Z la división en letra(A, B, C, D o E).
        /// </summary>
        public string AnoDivision
        {
            get {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($" {this.ano}°{this.division}"  );
                return sb.ToString();
            }
        }
        #endregion

        #region MOTODOS 

        /// <summary>
        /// ValidarDocumentacion dará como válido sólo documentos que tengan el siguiente formato XX-XXXXX siendo las X números. 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns> si la validacion esta ok retorna true, caso contrario retornará false y no se asignará el documento</returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            if (!string.IsNullOrWhiteSpace(doc) && doc.Length == 9)
            {
                for (int i = 0; i < doc.Length - 1; i++)
                {
                    if ((i == 2 || i == 7) && doc[i] != '-')
                    {
                        return false;
                    }
                    else if (!char.IsDigit(doc[i]) && (i != 2 && i != 7))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


        /// <summary>
        /// retorna los datos de un alumno
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Año y division {this.AnoDivision}");
           
            return sb.ToString();
        }

        #endregion

    }
}
