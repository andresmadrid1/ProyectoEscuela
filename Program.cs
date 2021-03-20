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
using Entidades.Escuela;
using Entidades.Universidad;
using Entidades.Curso;
using System.IO;
using System.Security.AccessControl;

namespace miEscuela
{
    class Program
    {   
        static void Main(string[] args)
        {
            var añoFundacion= "";
            var fundadorEscuela= "";
            var cantidadAlumnos= "";
            var cantidadProfesores = "";
            var cantidadAulas = "";
            var tipoEscuela = "";
            var decano = "";
            var cantidadEstudiantes = "";
            var cantidadCarreras = "";
            var crearCurso = "";


            Console.WriteLine("Hola bienvenido a nuestro sistema de registro de institutos educativos! \nPuedes crear instituciones tales como Escuelas y Universidades");
            Console.WriteLine("Te gustaria crear alguna institucion? SI/NO");
            var crearInstitucion = Console.ReadLine().ToUpper();
            Console.WriteLine(" ");
            Console.WriteLine("==========================");

            //Si la persona desea crear una institucion se le pregunta que tipo de institucion desea crear, si no desea 
            //ninguna se finaliza el programa.
            if (crearInstitucion == "SI")
            {
                Console.WriteLine(" ");
                Console.WriteLine("==========================");
                Console.WriteLine("Genial! Que tipo de institucion te gustaria crear?");
                Console.WriteLine("Escuela/Universidad");
                Console.WriteLine(" ");

                var tipoInstituto = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("El instituto que se desea crear es una " + tipoInstituto + " a continuación complete el formulario para poder crear la escuela: ");
                
            //Si desea crear una escuela se procede a preguntar los datos basicos
                if (tipoInstituto == "Escuela")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("==========================");
                    Console.WriteLine("Que tipo de escuela quiere crear? \nPrimaria, Secundaria o Preescolar");
                    tipoEscuela = Console.ReadLine();
                    Console.WriteLine(" ");

            //Si desea crear una escuela primaria se piden los datos para la escuela primaria.
                    if (tipoEscuela == "Primaria")
                    {
                        Console.WriteLine("Por favor indique el nombre de la escuela " + tipoEscuela);
                        var nombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la ciudad: ");
                        var ciudad = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la dirección: ");
                        var direccion = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Desea agregar informacion adicional de la escuela " + tipoEscuela + " ? \nSI/NO");
                        var informacionAdicional= Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");
                        
                        if (informacionAdicional == "SI")
                        {
                            Console.WriteLine("Indique el año de fundación de la escuela " + tipoEscuela + " : ");
                            añoFundacion = Console.ReadLine();
                            Console.WriteLine(" ");
                                               
                            Console.WriteLine("Indique el nombre del fundador de la escuela " + tipoEscuela + " : ");
                            fundadorEscuela = Console.ReadLine();
                            Console.WriteLine(" ");
                            
                            Console.WriteLine("Cuantos alumnos pueden matricularse en la escuela " + tipoEscuela + " ? ");
                            cantidadAlumnos = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            Console.WriteLine("Cuantos profesores posee la escuela " + tipoEscuela + " ? ");
                            cantidadProfesores = Console.ReadLine();
                            Console.WriteLine(" ");   
                            
                            Console.WriteLine("Cuantas aulas posee la escuela " + tipoEscuela + " ? ");
                            cantidadAulas = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            var miEscuelaPrimaria = new Escuela(nombre,direccion,TiposEscuela.Primaria, ciudad);
                            //var timbreEscuela = new Melodia();
                            miEscuelaPrimaria.añoFundacion = Convert.ToInt32(añoFundacion);
                            miEscuelaPrimaria.fundadorEscuela = fundadorEscuela;
                            miEscuelaPrimaria.cantidadAlumnos = Convert.ToInt32(cantidadAlumnos);
                            miEscuelaPrimaria.cantidadProfesores = Convert.ToInt32(cantidadProfesores);
                            miEscuelaPrimaria.cantidadAulas = Convert.ToInt32(cantidadAulas);
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion de la escuela " + tipoEscuela + " : \n");
                            miEscuelaPrimaria.ImprimirInformacionEscuela();
                            Console.WriteLine("Timbre de recreo!");                  
                        }
                        else
                        {
                            var miEscuelaPrimaria = new Escuela(nombre,direccion,TiposEscuela.Primaria, ciudad);
                            //var timbreEscuela = new Melodia();
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion de la escuela " + tipoEscuela + " : \n");
                            miEscuelaPrimaria.ImprimirInformacionEscuelaBasica();
                            Console.WriteLine("Timbre de recreo!");
                        }  
                    }

                    //Si desea crear una escuela primaria se piden los datos para la escuela primaria.
                    if (tipoEscuela == "Secundaria")
                    {
                        Console.WriteLine("Por favor indique el nombre de la escuela " + tipoEscuela);
                        var nombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la ciudad: ");
                        var ciudad = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la dirección: ");
                        var direccion = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Desea agregar informacion adicional de la escuela " + tipoEscuela + " ? \nSI/NO");
                        var informacionAdicional= Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");
                        
                        if (informacionAdicional == "SI")
                        {
                            Console.WriteLine("Indique el año de fundación de la escuela: ");
                            añoFundacion = Console.ReadLine();
                            Console.WriteLine(" ");
                                               
                            Console.WriteLine("Indique el nombre del fundador de la escuela: ");
                            fundadorEscuela = Console.ReadLine();
                            Console.WriteLine(" ");
                            
                            Console.WriteLine("Cuantos alumnos pueden matricularse en la escuela? ");
                            cantidadAlumnos = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            Console.WriteLine("Cuantos profesores posee la escuela? ");
                            cantidadProfesores = Console.ReadLine();
                            Console.WriteLine(" ");   
                            
                            Console.WriteLine("Cuantas aulas posee la escuela? ");
                            cantidadAulas = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            var miEscuelaSecundaria = new Escuela(nombre,direccion,TiposEscuela.Secundaria, ciudad);
                            miEscuelaSecundaria.añoFundacion = Convert.ToInt32(añoFundacion);
                            miEscuelaSecundaria.fundadorEscuela = fundadorEscuela;
                            miEscuelaSecundaria.cantidadAlumnos = Convert.ToInt32(cantidadAlumnos);
                            miEscuelaSecundaria.cantidadProfesores = Convert.ToInt32(cantidadProfesores);
                            miEscuelaSecundaria.cantidadAulas = Convert.ToInt32(cantidadAulas);
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion de la escuela: \n");
                            miEscuelaSecundaria.ImprimirInformacionEscuela();              
                        }
                        else
                        {
                            var miEscuelaSecundaria = new Escuela(nombre,direccion,TiposEscuela.Secundaria, ciudad);
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion de la escuela: \n");
                            miEscuelaSecundaria.ImprimirInformacionEscuelaBasica();
                        }  
                    } 

                    //Si desea crear una escuela primaria se piden los datos para la escuela primaria.
                    if (tipoEscuela == "Preescolar")
                    {
                        Console.WriteLine("Por favor indique el nombre de la escuela " + tipoEscuela);
                        var nombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la ciudad: ");
                        var ciudad = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la dirección: ");
                        var direccion = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Desea agregar informacion adicional de la escuela? \nSI/NO");
                        var informacionAdicional= Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");
                        
                        if (informacionAdicional == "SI")
                        {
                            Console.WriteLine("Indique el año de fundación de la escuela: ");
                            añoFundacion = Console.ReadLine();
                            Console.WriteLine(" ");
                                               
                            Console.WriteLine("Indique el nombre del fundador de la escuela: ");
                            fundadorEscuela = Console.ReadLine();
                            Console.WriteLine(" ");
                            
                            Console.WriteLine("Cuantos alumnos pueden matricularse en la escuela? ");
                            cantidadAlumnos = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            Console.WriteLine("Cuantos profesores posee la escuela? ");
                            cantidadProfesores = Console.ReadLine();
                            Console.WriteLine(" ");   
                            
                            Console.WriteLine("Cuantas aulas posee la escuela? ");
                            cantidadAulas = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            var miEscuelaSecundaria = new Escuela(nombre,direccion,TiposEscuela.Preescolar, ciudad);
                            miEscuelaSecundaria.añoFundacion = Convert.ToInt32(añoFundacion);
                            miEscuelaSecundaria.fundadorEscuela = fundadorEscuela;
                            miEscuelaSecundaria.cantidadAlumnos = Convert.ToInt32(cantidadAlumnos);
                            miEscuelaSecundaria.cantidadProfesores = Convert.ToInt32(cantidadProfesores);
                            miEscuelaSecundaria.cantidadAulas = Convert.ToInt32(cantidadAulas);
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion de la escuela: \n");
                            miEscuelaSecundaria.ImprimirInformacionEscuela();              
                        }
                        else
                        {
                            var miEscuelaSecundaria = new Escuela(nombre,direccion,TiposEscuela.Preescolar, ciudad);
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion de la escuela: \n");
                            miEscuelaSecundaria.ImprimirInformacionEscuelaBasica();
                        }  
                    } 
                //Se ejecuta este bloque de codigo en caso de que se desee crear una universidad                
                }
                if (tipoInstituto == "Universidad")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("==========================");

                    Console.WriteLine("Por favor indique el nombre de la universidad ");
                    var nombre = Console.ReadLine();
                    Console.WriteLine(" ");
                        
                    Console.WriteLine("Por favor indique la sede: ");
                    var sede = Console.ReadLine();
                    Console.WriteLine(" ");
                        
                    Console.WriteLine("Por favor indique el pais: ");
                    var pais = Console.ReadLine();
                    Console.WriteLine(" ");
                        
                    Console.WriteLine("Desea agregar informacion adicional de la universidad? \nSI/NO");
                    var informacionAdicional= Console.ReadLine().ToUpper();
                    Console.WriteLine(" ");

                    if (informacionAdicional == "SI")
                    {
                        Console.WriteLine("Indique el año de fundación de la universidad: ");
                        añoFundacion = Console.ReadLine();
                        Console.WriteLine(" ");
                                               
                        Console.WriteLine("Indique el nombre del decano: ");
                        decano = Console.ReadLine();
                        Console.WriteLine(" ");
                            
                        Console.WriteLine("Cuantos estudiantes pueden matricularse en la universidad? ");
                        cantidadEstudiantes = Console.ReadLine();
                        Console.WriteLine(" "); 
                            
                        Console.WriteLine("Cuantos profesores posee la universidad? ");
                        cantidadProfesores = Console.ReadLine();
                        Console.WriteLine(" ");   
                            
                        Console.WriteLine("Cuantas carreras posee la universidad? ");
                        cantidadCarreras = Console.ReadLine();
                        Console.WriteLine(" "); 

                        Console.WriteLine("Cuantas aulas posee la universidad para sus cursos? ");
                        cantidadAulas = Console.ReadLine();
                        Console.WriteLine(" "); 

                        var miUniversidad = new Universidad(nombre,sede,pais,Convert.ToInt32(añoFundacion));
                        miUniversidad.decano = decano;
                        miUniversidad.cantidadEstudiantes = Convert.ToInt32(cantidadEstudiantes);
                        miUniversidad.cantidadProfesores = Convert.ToInt32(cantidadProfesores);
                        miUniversidad.cantidadCarreras = Convert.ToInt32(cantidadCarreras);
                        miUniversidad.cantidadAulas = Convert.ToInt32(cantidadAulas);
                        Console.WriteLine(" ");
                        Console.WriteLine("Se muestra la informacion de la universidad: \n");
                        miUniversidad.ImprimirInformacionUniversidad();
                    }
                    else
                    {
                        var miUniversidad = new Universidad(nombre,sede,pais);
                        Console.WriteLine(" ");
                        Console.WriteLine("Se muestra la informacion de la universidad: \n");
                        miUniversidad.ImprimirInformacionUniversidadBasica();
                    }
                }
                else
                {
                    Console.WriteLine("Lo sentimos pero solo se permiten crear escuela o universidades");
                }
            }
            if (crearInstitucion == "NO") 
            {
                Console.WriteLine(" ");
                Console.WriteLine("==========================");
                Console.WriteLine("Desea crear un curso para alguna escuela o universidad? \nSI/NO"); 
                crearCurso = Console.ReadLine().ToUpper();
                Console.WriteLine(" ");

                if (crearCurso == "SI")
                {
                    List<Curso> cursos = new List<Curso>();
                    while (crearCurso == "SI")
                    {
                        Console.WriteLine("Vale indique por favor el nombre del curso que desea crear");
                        var nombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde,Noche");
                        var jornada = Console.ReadLine();
                        if (jornada == "Diurno")
                        {
                            cursos.Add(new Curso(){nombre = nombre, jornada = TiposJornada.Diurno});
                        }
                        if (jornada == "Tarde")
                        {
                            cursos.Add(new Curso(){nombre = nombre, jornada = TiposJornada.Tarde});
                        }
                        if (jornada == "Noche")
                        {
                            cursos.Add(new Curso(){nombre = nombre, jornada = TiposJornada.Noche});
                        }
                        Console.WriteLine("Desea crear otro curso \nSI/NO");
                        crearCurso = Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");
                    };
                    
                    ImprimirCurso(cursos);
                }
                else
                {
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
            }
        }
        public static void ImprimirCurso(List<Curso> cursos)
        {
            Console.WriteLine("Se presenta el listado de cursos creados: ");
            for (int i = 0; i<cursos.Count; i++)
            {
                Console.WriteLine("Nombre del curso: " + cursos[i].nombre + "\nJornada: " + cursos[i].jornada + "\nID del curso: " + cursos[i].uniqueId);
            }
        }
    }
}
