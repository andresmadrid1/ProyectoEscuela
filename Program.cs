using System.Runtime.ExceptionServices;
using System.Runtime.Versioning;
using System.Reflection;
using Microsoft.Win32.SafeHandles;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml;
using System.Drawing;
using System.Dynamic;
using Melodias.Timbre;
using miEscuela.Entidades;
using InstitucionEngine;
using cursoEngine;
using System.IO;
using System.Security.AccessControl;

namespace miEscuela
{
    class Program
    {   
        static void Main(string[] args)
        {
            var crearCurso = "";
            var tipoInstituto = "";

            Console.WriteLine("Hola bienvenido a nuestro sistema de registro de institutos educativos! \nPuedes crear instituciones tales como Escuelas y Universidades");
            Console.WriteLine("Te gustaria crear alguna institucion? SI/NO");
            var crearInstitucion = Console.ReadLine().ToUpper();
            Console.WriteLine(" ");
            Console.WriteLine("==========================");

            //Si la persona desea crear una institucion se le pregunta que tipo de institucion desea crear, si no desea 
            //se le pregunta si desea crear algun curso.
            if (crearInstitucion == "SI")
            {
                var institucion = new Institucion();
                institucion.CrearInstitucion();    
            
            }
            if (crearInstitucion == "NO") 
            {
                Console.WriteLine(" ");
                Console.WriteLine("==========================");
                Console.WriteLine("Desea crear un curso para alguna escuela o universidad? \nSI/NO"); 
                crearCurso = Console.ReadLine().ToUpper();
                Console.WriteLine(" ");
                
                //Si la persona desea crear algun curso se le pregunta el tipo de curso que desea crear,
                //caso contrario que no desee crear un curso tampoco, se cierra el programa.
                if (crearCurso == "SI")
                {
                    Console.WriteLine("Para que tipo de institucion te gustaria crear los cursos ?");
                    tipoInstituto = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (tipoInstituto == "Escuela")
                    {
                        var miCurso = new cursoEducativo();
                        miCurso.crearCurso = "SI";
                        miCurso.crearCursoNuevo();
                        Console.WriteLine(" ");
                        Console.WriteLine("==========================");
                        Console.WriteLine("Gracias por usar nuestro servicio!");   
                    }
                    else
                    {
                        var miCurso = new cursoEducativo();
                        miCurso.crearCurso = "SI";
                        miCurso.crearCursoNuevo();
                        Console.WriteLine(" ");
                        Console.WriteLine("==========================");
                        Console.WriteLine("Gracias por usar nuestro servicio!");
                    }
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("==========================");
                    Console.WriteLine("Gracias por usar nuestro servicio!");
                    return;
                }           
            }
        }
    }
}
