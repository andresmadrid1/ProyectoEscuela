using System;

namespace Entidades.Escuela
{
    class Escuela
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int añoFundacion { get; set; }
        public string fundadorEscuela { get; set; }
        public int cantidadAlumnos { get; set; }
        public int cantidadProfesores { get; set; }  
        public int cantidadAulas { get; set;}
        public TiposEscuela TipoEscuela{get; set;}
        public string ciudad { get; set; }
        

        public Escuela(string nombre, string direccion, TiposEscuela TipoEscuela, string ciudad=" ")
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.TipoEscuela = TipoEscuela;
        }

        public void ImprimirInformacionEscuela()
        {
            Console.WriteLine("Nombre de escuela: " + nombre);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Año de fundacion: " + añoFundacion);
            Console.WriteLine("Cantidad de alumnos: " + cantidadAlumnos);
            Console.WriteLine("Cantidad de Profesores: " + cantidadProfesores);
            Console.WriteLine("Cantidad de aulas: " + cantidadAulas);
            Console.WriteLine("Fundador: " + fundadorEscuela);
            Console.WriteLine("Tipo de escuela: " + TipoEscuela);
        }

        public void ImprimirInformacionEscuelaBasica()
        {
            Console.WriteLine("Nombre de escuela: " + nombre);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Tipo de escuela: " + TipoEscuela);
        }
    }
}