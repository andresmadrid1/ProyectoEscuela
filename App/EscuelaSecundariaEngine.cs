using System;
using InstitucionEngine;
using System.Collections.Generic;
using miEscuela.Entidades;
using cursoEngine;

namespace EscuelaSecundariaEngine
{
    public class EscuelaSecundaria
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

        public void crearEscuelaSecundaria()
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
                    //tipoEscuela = TiposEscuela.Secundaria.ToString();
                    var miCurso = new cursoEducativoEscuela();
                    miCurso.crearCurso = crearCurso;
                    miCurso.tipoEscuela = TiposEscuela.Secundaria.ToString();
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
                var miEscuelaSecundaria = new Escuela(nombre,direccion,TiposEscuela.Secundaria, ciudad);
                Console.WriteLine(" ");
                Console.WriteLine("Se muestra la informacion de la escuela: \n");
                miEscuelaSecundaria.ImprimirInformacionEscuelaBasica();
            }  
        }
    }
}