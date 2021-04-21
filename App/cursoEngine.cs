using System;
using InstitucionEngine;
using System.Collections.Generic;
using miEscuela.Entidades;

namespace cursoEngine
{
    public class cursoEducativo
    {
        public string crearCurso { get; set; }
        public string nombre { get; set; }
        public void crearCursoNuevo()
        {
            var miUniversidadCurso = new Universidad();
            miUniversidadCurso.cursosUniversidad = new List<CursoUniversidad>();
            while (crearCurso == "SI")
            {
                Console.WriteLine("Vale indique por favor el nombre del curso que desea crear");
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
        }
    }
}