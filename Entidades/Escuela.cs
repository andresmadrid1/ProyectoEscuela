using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Entidades.Escuela
{
    class Escuela
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int añoFundacion { get; set; }
        public string fundadorEscuela { get; set; }
        public int cantidadAlumnos { get; set; }
        public int cantidadProfesores { get; set; }  
        public int cantidadAulas { get; set;}
        public TiposEscuela TipoEscuela{get; set;}
        public string ciudad { get; set; }
        public List<CursoEscuela> cursosEscuela { get; set; }
        
        public Escuela(string nombre, string direccion, TiposEscuela TipoEscuela, string ciudad=" ")
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.TipoEscuela = TipoEscuela;
        }
        public Escuela()
        {    
        }

        public void ImprimirInformacionEscuela()
        {
            Console.WriteLine("Nombre de escuela: " + nombre);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Año de fundacion: " + añoFundacion);
            Console.WriteLine("Cantidad de alumnos: " + cantidadAlumnos);
            Console.WriteLine("Cantidad de Profesores: " + cantidadProfesores);
            Console.WriteLine("Cantidad de aulas: " + cantidadAulas);
            Console.WriteLine("Fundador: " + fundadorEscuela);
            Console.WriteLine("Tipo de escuela: " + TipoEscuela);
        }

        public void ImprimirInformacionEscuelaBasica()
        {
            Console.WriteLine("Nombre de escuela: " + nombre);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Tipo de escuela: " + TipoEscuela);
        }

        public void ImprimirCurso()
        {
            Console.WriteLine("Se presenta el listado de cursos creados: ");
            for (int i = 0; i < cursosEscuela.Count; i++)
            {
                Console.WriteLine("Nombre del curso: " + cursosEscuela[i].nombre + "\nJornada: " + cursosEscuela[i].jornada + "\nID del curso: " + cursosEscuela[i].uniqueId);   
            }
        }
    }
}