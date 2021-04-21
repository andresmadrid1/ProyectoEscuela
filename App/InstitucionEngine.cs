using System;
using miEscuela.Entidades;
using cursoEngine;
using EscuelaPrimariaEngine;
using EscuelaSecundariaEngine;
using EscuelaPreescolarEngine;
using System.Collections.Generic;

namespace InstitucionEngine
{
    public class Institucion
    {
        public string tipoInstituto { get; set; }
        public string tipoEscuela { get; set; }
        public string nombre { get; set; }
        public string sede { get; set; }
        public string pais { get; set; }
        public string informacionAdicional { get; set; }
        public string añoFundacion { get; set; }
        public string decano { get; set; }
        public string cantidadEstudiantes { get; set; }
        public string cantidadProfesores { get; set; }
        public string cantidadCarreras { get; set; }
        public string cantidadAulas { get; set; }
        public string crearCurso { get; set; }
        
        
        public void CrearInstitucion()
        {
            Console.WriteLine(" ");
            Console.WriteLine("==========================");
            Console.WriteLine("Genial! Que tipo de institucion te gustaria crear?");
            Console.WriteLine("Escuela/Universidad");
            Console.WriteLine(" ");
            tipoInstituto = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("El instituto que se desea crear es una " + tipoInstituto + " : ");

            if (tipoInstituto == "Escuela")
                {
                    CrearEscuela();
                    return;
                    
                }
                if (tipoInstituto == "Universidad")
                {
                    CrearUniversidad();
                    return;
                }
                if (tipoInstituto != "Universidad" || tipoInstituto != "Escuela")
                {
                    Console.WriteLine("Lo sentimos pero solo se permiten crear escuela o universidades");
                    return;
                }
        }

        public void CrearEscuela()
        {
            Console.WriteLine(" ");
            Console.WriteLine("==========================");
            Console.WriteLine("Que tipo de escuela quiere crear? \nPrimaria, Secundaria o Preescolar");
            tipoEscuela = Console.ReadLine();
            Console.WriteLine(" ");

            if (tipoEscuela == "Primaria")
            {
                var NuevaEscuelaPrimaria = new escuelaPrimaria();
                NuevaEscuelaPrimaria.tipoEscuela = "Primaria";
                NuevaEscuelaPrimaria.crearEscuelaPrimaria();
            }
            if (tipoEscuela == "Secundaria")
            {
                var NuevaEscuelaSecundaria = new EscuelaSecundaria();
                NuevaEscuelaSecundaria.tipoEscuela = "Secundaria";
                NuevaEscuelaSecundaria.crearEscuelaSecundaria();
            }
            if (tipoEscuela == "Preescolar")
            {
                var NuevaEscuelaPreescolar = new EscuelaPreescolar();
                NuevaEscuelaPreescolar.tipoEscuela = "Preescolar";
                NuevaEscuelaPreescolar.crearEscuelaPreescolar();
            }
        }



        public void CrearUniversidad()
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
                    var nuevoCurso = new cursoEducativo();
                    nuevoCurso.crearCurso = "SI";
                    nuevoCurso.crearCursoNuevo();
                    Console.WriteLine(" ");
                    Console.WriteLine("==========================");
                    Console.WriteLine("Gracias por usar nuestro servicio!");
                    return;
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
                return;
            }
        }

    }   
}