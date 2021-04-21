using System;
using InstitucionEngine;
using System.Collections.Generic;
using miEscuela.Entidades;

namespace EscuelaPreescolarEngine
{
    public class EscuelaPreescolar
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

        public void crearEscuelaPreescolar()
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
                        
            Console.WriteLine("Desea agregar informacion adicional del preescolar? \nSI/NO");
            informacionAdicional= Console.ReadLine().ToUpper();
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
                            
                var miEscuelaPreescolar = new Escuela(nombre,direccion,TiposEscuela.Preescolar, ciudad);
                miEscuelaPreescolar.añoFundacion = Convert.ToInt32(añoFundacion);
                miEscuelaPreescolar.fundadorEscuela = fundadorEscuela;
                miEscuelaPreescolar.cantidadAlumnos = Convert.ToInt32(cantidadAlumnos);
                miEscuelaPreescolar.cantidadProfesores = Convert.ToInt32(cantidadProfesores);
                miEscuelaPreescolar.cantidadAulas = Convert.ToInt32(cantidadAulas);
                Console.WriteLine(" ");
                Console.WriteLine("Se muestra la informacion del preescolar: \n");
                miEscuelaPreescolar.ImprimirInformacionEscuela();

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
                var miEscuelaPreescolar = new Escuela(nombre,direccion,TiposEscuela.Preescolar, ciudad);
                Console.WriteLine(" ");
                Console.WriteLine("Se muestra la informacion del preescolar: \n");
                miEscuelaPreescolar.ImprimirInformacionEscuelaBasica();
            }                  
        }

    }
}