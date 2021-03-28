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
            var tipoInstituto = "";
            var nombre = "";

            Console.WriteLine("Hola bienvenido a nuestro sistema de registro de institutos educativos! \nPuedes crear instituciones tales como Escuelas y Universidades");
            Console.WriteLine("Te gustaria crear alguna institucion? SI/NO");
            var crearInstitucion = Console.ReadLine().ToUpper();
            Console.WriteLine(" ");
            Console.WriteLine("==========================");

            //Si la persona desea crear una institucion se le pregunta que tipo de institucion desea crear, si no desea 
            //se le pregunta si desea crear algun curso.
            if (crearInstitucion == "SI")
            {
                Console.WriteLine(" ");
                Console.WriteLine("==========================");
                Console.WriteLine("Genial! Que tipo de institucion te gustaria crear?");
                Console.WriteLine("Escuela/Universidad");
                Console.WriteLine(" ");

                tipoInstituto = Console.ReadLine();
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
                        nombre = Console.ReadLine();
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

                            // Una vez creada la escuela primaria se le pregunta a la persona si desea crearle cursos a dicha escuela
                            Console.WriteLine("Desea crear algun curso para la escuela primaria? \nSI/NO"); 
                            crearCurso = Console.ReadLine().ToUpper();
                            Console.WriteLine(" ");
                            //Si la persona desea crear algun curso se le pregunta el tipo de curso que desea crear
                            //caso contrario que no desee crear un curso tampoco, se cierra el programa.
                            if (crearCurso == "SI")
                            {
                                var miEscuela = new Escuela();
                                miEscuela.cursosEscuela = new List<CursoEscuela>();
                                while (crearCurso == "SI")
                                {
                                    Console.WriteLine("Vale indique por favor el nombre del curso que desea crear para la Escuela primaria");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde");
                                    var jornada = Console.ReadLine();
                                    if (jornada == "Diurno")
                                    {
                                        miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Diurno});
                                    }
                                    if (jornada == "Tarde")
                                    {
                                        miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Tarde});
                                    }
                                    Console.WriteLine("Desea crear otro curso \nSI/NO");
                                    crearCurso = Console.ReadLine().ToUpper();
                                    Console.WriteLine(" ");  
                                }
                                miEscuela.ImprimirCurso();
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                            }
                            if (crearCurso == "NO")
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                                return;
                            }                  
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

                    //Si desea crear una escuela secundaria se piden los datos para la escuela secundaria.
                    if (tipoEscuela == "Secundaria")
                    {
                        Console.WriteLine("Por favor indique el nombre de la escuela " + tipoEscuela);
                        nombre = Console.ReadLine();
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

                             // Una vez creada la escuela secundaria se le pregunta a la persona si desea crearle cursos a dicha escuela
                            Console.WriteLine("Desea crear algun curso para la escuela secundaria? \nSI/NO"); 
                            crearCurso = Console.ReadLine().ToUpper();
                            Console.WriteLine(" ");
                            //Si la persona desea crear algun curso se le pregunta el tipo de curso que desea crear
                            //caso contrario que no desee crear un curso tampoco, se cierra el programa.
                            if (crearCurso == "SI")
                            {
                                var miEscuela = new Escuela();
                                miEscuela.cursosEscuela = new List<CursoEscuela>();
                                while (crearCurso == "SI")
                                {
                                    Console.WriteLine("Vale indique por favor el nombre del curso que desea crear para la Escuela secundaria");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde");
                                    var jornada = Console.ReadLine();
                                    if (jornada == "Diurno")
                                    {
                                        miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Diurno});
                                    }
                                    if (jornada == "Tarde")
                                    {
                                        miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Tarde});
                                    }
                                    Console.WriteLine("Desea crear otro curso \nSI/NO");
                                    crearCurso = Console.ReadLine().ToUpper();
                                    Console.WriteLine(" ");  
                                }
                                miEscuela.ImprimirCurso();
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                            }
                            if (crearCurso == "NO")
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                                return;
                            }                               
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
                        nombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la ciudad: ");
                        var ciudad = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Por favor indique la dirección: ");
                        var direccion = Console.ReadLine();
                        Console.WriteLine(" ");
                        
                        Console.WriteLine("Desea agregar informacion adicional del preescolar? \nSI/NO");
                        var informacionAdicional= Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");
                        
                        if (informacionAdicional == "SI")
                        {
                            Console.WriteLine("Indique el año de fundación del preescolar: ");
                            añoFundacion = Console.ReadLine();
                            Console.WriteLine(" ");
                                               
                            Console.WriteLine("Indique el nombre del fundador del preescolar: ");
                            fundadorEscuela = Console.ReadLine();
                            Console.WriteLine(" ");
                            
                            Console.WriteLine("Cuantos alumnos pueden matricularse en el preescolar? ");
                            cantidadAlumnos = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            Console.WriteLine("Cuantos profesores posee el preescolar? ");
                            cantidadProfesores = Console.ReadLine();
                            Console.WriteLine(" ");   
                            
                            Console.WriteLine("Cuantas aulas posee el preescolar? ");
                            cantidadAulas = Console.ReadLine();
                            Console.WriteLine(" "); 
                            
                            var miEscuelaSecundaria = new Escuela(nombre,direccion,TiposEscuela.Preescolar, ciudad);
                            miEscuelaSecundaria.añoFundacion = Convert.ToInt32(añoFundacion);
                            miEscuelaSecundaria.fundadorEscuela = fundadorEscuela;
                            miEscuelaSecundaria.cantidadAlumnos = Convert.ToInt32(cantidadAlumnos);
                            miEscuelaSecundaria.cantidadProfesores = Convert.ToInt32(cantidadProfesores);
                            miEscuelaSecundaria.cantidadAulas = Convert.ToInt32(cantidadAulas);
                            Console.WriteLine(" ");
                            Console.WriteLine("Se muestra la informacion del preescolar: \n");
                            miEscuelaSecundaria.ImprimirInformacionEscuela();

                            // Una vez creada el preescolar se le pregunta a la persona si desea crearle cursos a dicha preescolar
                            Console.WriteLine("Desea crear algun curso para el preescolar? \nSI/NO"); 
                            crearCurso = Console.ReadLine().ToUpper();
                            Console.WriteLine(" ");
                            //Si la persona desea crear algun curso se le pregunta el tipo de curso que desea crear
                            //caso contrario que no desee crear un curso tampoco, se cierra el programa.
                            if (crearCurso == "SI")
                            {
                                var miEscuela = new Escuela();
                                miEscuela.cursosEscuela = new List<CursoEscuela>();
                                while (crearCurso == "SI")
                                {
                                    Console.WriteLine("Vale indique por favor el nombre del curso que desea crear para el preescolar");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde");
                                    var jornada = Console.ReadLine();
                                    if (jornada == "Diurno")
                                    {
                                        miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Diurno});
                                    }
                                    if (jornada == "Tarde")
                                    {
                                        miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Tarde});
                                    }
                                    Console.WriteLine("Desea crear otro curso \nSI/NO");
                                    crearCurso = Console.ReadLine().ToUpper();
                                    Console.WriteLine(" ");  
                                }
                                miEscuela.ImprimirCurso();
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                            }
                            if (crearCurso == "NO")
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                                return;
                            }               
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
                    nombre = Console.ReadLine();
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

                        Console.WriteLine(" ");
                        Console.WriteLine("==========================");
                        Console.WriteLine("Desea crear un curso para la universidad? \nSI/NO"); 
                        crearCurso = Console.ReadLine().ToUpper();
                        Console.WriteLine(" ");
                        //Si la persona desea crear algun curso se le pregunta el tipo de curso que desea crear,
                        //caso contrario que no desee crear un curso tampoco, se cierra el programa.
                        if (crearCurso == "SI")
                        {
                            var miUniversidadCurso = new Universidad();
                            miUniversidadCurso.cursosUniversidad = new List<CursoUniversidad>();
                            while (crearCurso == "SI")
                            {
                                Console.WriteLine("Vale indique por favor el nombre del curso que desea crear para la Universidad");
                                nombre = Console.ReadLine();
                                Console.WriteLine(" ");
                                Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde,Noche");
                                var jornada = Console.ReadLine();
                                if (jornada == "Diurno")
                                {
                                    miUniversidadCurso.cursosUniversidad.Add(new CursoUniversidad(){nombre = nombre, jornada = TiposJornadaUniversidad.Diurno});
                                }
                                if (jornada == "Tarde")
                                {
                                    miUniversidadCurso.cursosUniversidad.Add(new CursoUniversidad(){nombre = nombre, jornada = TiposJornadaUniversidad.Tarde});
                                }
                                if (jornada == "Noche")
                                {
                                    miUniversidadCurso.cursosUniversidad.Add(new CursoUniversidad(){nombre = nombre, jornada = TiposJornadaUniversidad.Noche});
                                }
                                Console.WriteLine("Desea crear otro curso \nSI/NO");
                                crearCurso = Console.ReadLine().ToUpper();
                                Console.WriteLine(" ");
                            }; 
                            miUniversidadCurso.ImprimirCurso();
                            Console.WriteLine(" ");
                            Console.WriteLine("==========================");
                            Console.WriteLine("Gracias por usar nuestro servicio!");
                        }
                        if (crearCurso == "NO")
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("==========================");
                                Console.WriteLine("Gracias por usar nuestro servicio!");
                                return;
                            }              
                    }
                    else
                    {
                        var miUniversidad = new Universidad(nombre,sede,pais);
                        Console.WriteLine(" ");
                        Console.WriteLine("Se muestra la informacion de la universidad: \n");
                        miUniversidad.ImprimirInformacionUniversidadBasica();
                    }
                }
                if (tipoInstituto != "Universidad" || tipoInstituto == "Escuela")
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
                
                //Si la persona desea crear algun curso se le pregunta el tipo de curso que desea crear,
                //caso contrario que no desee crear un curso tampoco, se cierra el programa.
                if (crearCurso == "SI")
                {
                    Console.WriteLine("Para que tipo de institucion te gustaria crear los cursos ?");
                    tipoInstituto = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (tipoInstituto == "Escuela")
                    {
                        var miEscuela = new Escuela();
                        miEscuela.cursosEscuela = new List<CursoEscuela>();
                        while (crearCurso == "SI")
                        {
                            Console.WriteLine("Vale indique por favor el nombre del curso que desea crear para la Escuela");
                            nombre = Console.ReadLine();
                            Console.WriteLine(" ");
                            Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde");
                            var jornada = Console.ReadLine();
                            if (jornada == "Diurno")
                            {
                                miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Diurno});
                            }
                            if (jornada == "Tarde")
                            {
                                miEscuela.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Tarde});
                            }
                            Console.WriteLine("Desea crear otro curso \nSI/NO");
                            crearCurso = Console.ReadLine().ToUpper();
                            Console.WriteLine(" ");  
                        }
                        miEscuela.ImprimirCurso();
                        Console.WriteLine(" ");
                        Console.WriteLine("==========================");
                        Console.WriteLine("Gracias por usar nuestro servicio!");   
                    }
                    else
                    {
                        var miUniversidad = new Universidad();
                        miUniversidad.cursosUniversidad = new List<CursoUniversidad>();
                        while (crearCurso == "SI")
                        {
                            Console.WriteLine("Vale indique por favor el nombre del curso que desea crear para la Universidad");
                            nombre = Console.ReadLine();
                            Console.WriteLine(" ");
                            Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde,Noche");
                            var jornada = Console.ReadLine();
                            if (jornada == "Diurno")
                            {
                                miUniversidad.cursosUniversidad.Add(new CursoUniversidad(){nombre = nombre, jornada = TiposJornadaUniversidad.Diurno});
                            }
                            if (jornada == "Tarde")
                            {
                                miUniversidad.cursosUniversidad.Add(new CursoUniversidad(){nombre = nombre, jornada = TiposJornadaUniversidad.Tarde});
                            }
                            if (jornada == "Noche")
                            {
                                miUniversidad.cursosUniversidad.Add(new CursoUniversidad(){nombre = nombre, jornada = TiposJornadaUniversidad.Noche});
                            }
                            Console.WriteLine("Desea crear otro curso \nSI/NO");
                            crearCurso = Console.ReadLine().ToUpper();
                            Console.WriteLine(" ");
                        }; 
                        miUniversidad.ImprimirCurso();
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
        }
    }
}
