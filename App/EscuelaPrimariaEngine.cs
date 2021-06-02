using System;
using InstitucionEngine;
using System.Collections.Generic;
using miEscuela.Entidades;
using cursoEngine;

namespace EscuelaPrimariaEngine
{
    public class escuelaPrimaria
    {
        public string nombre { get; set; }

        public string ciudad { get; set; }

        public string informacionAdicional { get; set; }

        public string direccion { get; set; }

        public string añoFundacion { get; set; }

        public string fundadorEscuela { get; set; }

        public string cantidadAlumnos { get; set; }

        public string cantidadProfesores { get; set; }

        public string cantidadAulas { get; set; }

        public string crearCurso { get; set; }

        public string tipoEscuela { get; set; }   
        
        public void crearEscuelaPrimaria()
        {
            Console.WriteLine("Por favor indique el nombre de la escuela " + tipoEscuela);
            nombre = Console.ReadLine();
            Console.WriteLine(" ");
                        
            Console.WriteLine("Por favor indique la ciudad: ");
            ciudad = Console.ReadLine();
            Console.WriteLine(" ");
                        
            Console.WriteLine("Por favor indique la dirección: ");
            direccion = Console.ReadLine();
            Console.WriteLine(" ");
                        
            Console.WriteLine("Desea agregar informacion adicional de la escuela " + tipoEscuela + " ? \nSI/NO");
            informacionAdicional= Console.ReadLine().ToUpper();
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
                    var miCurso = new cursoEducativoEscuela();
                    miCurso.crearCurso = crearCurso;
                    miCurso.tipoEscuela = TiposEscuela.Primaria.ToString();
                    miCurso.crearCursoNuevo();
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
                var miEscuelaPrimaria = new Escuela(nombre,direccion,TiposEscuela.Primaria, ciudad);
                //var timbreEscuela = new Melodia();
                Console.WriteLine(" ");
                Console.WriteLine("Se muestra la informacion de la escuela " + tipoEscuela + " : \n");
                miEscuelaPrimaria.ImprimirInformacionEscuelaBasica();
                Console.WriteLine("Timbre de recreo!");
            }
        }
    }
}