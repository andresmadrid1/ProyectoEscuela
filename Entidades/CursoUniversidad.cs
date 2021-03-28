using System;
using System.Collections.Generic;
namespace Entidades.Universidad
{
    public class CursoUniversidad
    {
        public string uniqueId { get; private set; }
        public string nombre { get; set; }
        public TiposJornadaUniversidad jornada { get; set; }
        
        public CursoUniversidad()
        {
            uniqueId = Guid.NewGuid().ToString();
        }
    }
}