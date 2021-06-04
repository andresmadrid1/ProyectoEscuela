using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace miEscuela.Entidades
{
    public class Escuela
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
        public string tipoInstituto { get; set; }
        
        
        
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
                Console.WriteLine(" ");
                Console.WriteLine("Nombre del curso: " + cursosEscuela[i].nombre + "\nJornada: " + cursosEscuela[i].jornada + "\nID del curso: " + cursosEscuela[i].uniqueId);
                Console.WriteLine(" ");
            }
        }

        public void crearAsignaturaSecundaria()
        {
            foreach (var curso in cursosEscuela)
            {
                var listaAsignaturas = new List<Asignaturas>()
                {
                    new Asignaturas {nombre = "Matematicas"},
                    new Asignaturas {nombre = "Fisica"},
                    new Asignaturas {nombre = "Ingles"},
                    new Asignaturas {nombre = "Castellano"},
                    new Asignaturas {nombre = "Dibujo"}
                };        
                curso.AsignaturasCurso = listaAsignaturas;
                if (curso.AsignaturasCurso != null)
                {
                    Console.WriteLine($"El curso {curso.nombre} contiene las siguientes asignaturas: ");
                    Console.WriteLine("");
                    foreach (var asignatura in curso.AsignaturasCurso)
                    {
                        Console.WriteLine("Nombre de la asignatura es " + asignatura.nombre);
                    }
                    Console.WriteLine("");
                }
            }
        }
        
        public void crearAsignaturaPrimaria()
        {
            foreach (var curso in cursosEscuela)
            {
                var listaAsignaturas = new List<Asignaturas>()
                {
                    new Asignaturas {nombre = "Matematicas"},
                    new Asignaturas {nombre = "Educacion artistica"},
                    new Asignaturas {nombre = "Ingles"},
                    new Asignaturas {nombre = "Castellano"},
                    new Asignaturas {nombre = "Educacion fisica"} 
                };
                curso.AsignaturasCurso = listaAsignaturas;
                if (curso.AsignaturasCurso != null)
                {
                    Console.WriteLine($"El curso {curso.nombre} contiene las siguientes asignaturas: ");
                    Console.WriteLine("");
                    foreach (var asignatura in curso.AsignaturasCurso)
                    {
                        Console.WriteLine("Nombre de la asignatura es " + asignatura.nombre);
                    }
                    Console.WriteLine("");
                }
            }   
        }
        public void CrearAsignaturaPreescolar()
        {
            foreach (var curso in cursosEscuela)
            {
                var listaAsignaturas = new List<Asignaturas>()
                {
                    new Asignaturas {nombre = "Plastina"},
                    new Asignaturas {nombre = "Dibujo"},
                    new Asignaturas {nombre = "Lengua"},
                    new Asignaturas {nombre = "Pintura"},
                    new Asignaturas {nombre = "jUEGOS"}
                };
                curso.AsignaturasCurso = listaAsignaturas;
                if (curso.AsignaturasCurso != null)
                {
                    Console.WriteLine($"El curso {curso.nombre} contiene las siguientes asignaturas: ");
                    Console.WriteLine("");
                    foreach (var asignatura in curso.AsignaturasCurso)
                    {
                        Console.WriteLine("Nombre de la asignatura es " + asignatura.nombre);
                    }
                    Console.WriteLine("");
                }   
            }
                
        }
    }
}