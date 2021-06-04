using System.Security.Cryptography;
using System.Transactions;
using Microsoft.Win32.SafeHandles;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace miEscuela.Entidades
{
    public class Universidad
    {
        public string nombre { get; set; }
    
        public string sede { get; set; }
        public string pais { get; set; }
        public int añoFundacion { get; set; }
        public string decano { get; set; }
        public int cantidadEstudiantes { get; set; }
        public int cantidadProfesores { get; set; }
        public int cantidadCarreras { get; set; }
        public int cantidadAulas { get; set; }
        public List<CursoUniversidad> cursosUniversidad { get; set; }
        

        public Universidad(string nombre, string sede, string pais, int añoFundacion=2015)
        {
            this.nombre = nombre;
            this.sede = sede;
            this.pais = pais;
            this.añoFundacion = añoFundacion;
        }
        public Universidad()
        {
        }
        public void ImprimirInformacionUniversidad()
        {
            Console.WriteLine("Nombre de la Universidad: " + nombre);
            Console.WriteLine("Sede: "  + sede);
            Console.WriteLine("Pais: " + pais);
            Console.WriteLine("Año de fundacion: " + añoFundacion);
            Console.WriteLine("Decano: " + decano);
            Console.WriteLine("Cantidad de estudiantes: " + cantidadEstudiantes);
            Console.WriteLine("Cantidad de profesores: " + cantidadProfesores);
            Console.WriteLine("Cantidad de carreras " + cantidadCarreras);
            Console.WriteLine("Cantidad de aulas " + cantidadAulas);
        }
        public void ImprimirInformacionUniversidadBasica()
        {
            Console.WriteLine("Nombre de la Universidad: " + nombre);
            Console.WriteLine("Sede: "  + sede);
            Console.WriteLine("Pais: " + pais);
            Console.WriteLine("Año de fundacion: " + añoFundacion);
        }
        public void ImprimirCurso()
        {
            Console.WriteLine("Se presenta el listado de cursos creados: ");
            for (int i = 0; i<cursosUniversidad.Count; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nombre del curso: " + cursosUniversidad[i].nombre + "\nJornada: " + cursosUniversidad[i].jornada + "\nID del curso: " + cursosUniversidad[i].uniqueId);
                Console.WriteLine(" ");
            }
        }

        public void AsignaturasUniversidad()
        {
            foreach (var curso in cursosUniversidad)
            {
                var listaAsignaturas = new List<Asignaturas>()
                {
                    new Asignaturas{nombre = "Matematicas 1"},
                    new Asignaturas{nombre = "Calculo Diferencial"},
                    new Asignaturas{nombre = "Fisica 1"},
                    new Asignaturas{nombre = "Programacion basica"},
                    new Asignaturas{nombre = "Programacion avanzada"}
                };

                curso.AsignaturasCurso = listaAsignaturas;
                if (curso.AsignaturasCurso != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"El curso {curso.nombre} contiene las siguientes asignaturas: ");
                    Console.WriteLine("");
                    foreach (var asignatura in curso.AsignaturasCurso)
                    {
                        Console.WriteLine("Nombre de la asignatura es " + asignatura.nombre);
                    }
                }
            }
        }
    }
}