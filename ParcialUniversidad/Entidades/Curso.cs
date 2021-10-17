using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short ano;
        private Divisiones division;
        private Profesor profesor;


        #region CONSTRUCTO
        ///  Constructor donde se instanciará la lista de alumnos
        /// </summary>
        private Curso()
        {
            alumnos = new List<Alumno>();
        }
        public Curso(short ano, Divisiones division, Profesor profesor) : this()
        {
            this.ano = ano;
            this.division = division;
            this.profesor = profesor;
        }

        #endregion


        #region PROPIEDADES
        /// <summary>
        /// Retorna un string con el año y la division
        /// </summary>
        public string AnoDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($" {this.ano}°{this.division}");
                return sb.ToString();

            }

        }

        #endregion

        #region METODOS
        /// <summary>
        /// El operador explícito retornará los datos del curso y todos sus alumnos, 
        /// utilizando StringBuilder para
        ///compilar dicha información
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator string(Curso c)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Año y division: {c.AnoDivision}");
            sb.AppendLine($"Profesor: {c.profesor.ExponerDatos()}");
            sb.AppendLine($"Lista de alumnos");
            foreach (Alumno item in c.alumnos)
            {
                sb.AppendLine($" {item.ExponerDatos()}");
            }
            
            return sb.ToString();

        }

        /// <summary>
        /// El operador == entre Curso y Alumno informará true si el
        /// alumno pertenece al mismo Año y División que el curso.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Curso c, Alumno a)
        {
            return c.AnoDivision == a.AnoDivision;
              
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            
                return !(c== a);
            }

       



        /// <summary>
        /// El operador + entre Curso y Alumno agregará al alumno
        /// al curso siempre y cuando su Año y División coincidan.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Curso operator +(Curso c, Alumno a)
        {
            if ( a is not null && c is not null && c== a)
            {
                foreach (Alumno item in c.alumnos)
                {
                    if( item.Documento == a.Documento || (item.Nombre == a.Nombre && item.Apellido == a.Apellido))
                    {
                          return c;
                    }
                }
                  c.alumnos.Add(a);
            }
            return c;
        }


        #endregion
    }

}
