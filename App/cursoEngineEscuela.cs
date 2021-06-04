using System.Runtime.InteropServices;
using System;
using InstitucionEngine;
using System.Collections.Generic;
using miEscuela.Entidades;

namespace cursoEngine
{
    public class cursoEducativoEscuela
    {
        public string crearCurso { get; set; }
        public string nombre { get; set; }
        public string tipoInstituto { get; set; }
        public string tipoEscuela { get; set; }
        
        
        public void crearCursoNuevo()
        {
            var miEscuelaCurso = new Escuela();
            miEscuelaCurso.cursosEscuela = new List<CursoEscuela>();
            while (crearCurso == "SI")
            {
                Console.WriteLine("Vale indique por favor el nombre del curso que desea crear");
                nombre = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Por favor indique la jornada del curso: \nDiurno,Tarde");
                var jornada = Console.ReadLine();
                if (jornada == "Diurno")
                {
                    miEscuelaCurso.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Diurno});
                }
                if (jornada == "Tarde")
                {
                    miEscuelaCurso.cursosEscuela.Add(new CursoEscuela(){nombre = nombre, jornada = TiposJornadaEscuela.Tarde});
                }
                Console.WriteLine("Desea crear otro curso \nSI/NO");
                crearCurso = Console.ReadLine().ToUpper();
                Console.WriteLine(" ");
            };
            miEscuelaCurso.ImprimirCurso();
            Console.WriteLine(tipoEscuela);
            if (tipoEscuela == "Primaria")
            {
                miEscuelaCurso.crearAsignaturaPrimaria();
            }
            if (tipoEscuela == "Secundaria")
            {
                miEscuelaCurso.crearAsignaturaSecundaria();
            }
            if (tipoEscuela == "Preescolar")
            {
                miEscuelaCurso.CrearAsignaturaPreescolar();
            }
        }
    }
}