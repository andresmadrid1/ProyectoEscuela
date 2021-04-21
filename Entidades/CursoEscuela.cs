using System;
using System.Collections.Generic;
namespace miEscuela.Entidades
{
    public class CursoEscuela
    {
        public string uniqueId { get; private set; }
        public string nombre { get; set; }
        public TiposJornadaEscuela jornada { get; set; }

        public CursoEscuela()
        {
            uniqueId = Guid.NewGuid().ToString();
        }              
    }
}