using System;
using System.Collections.Generic;
namespace Entidades.Curso
{
    public class Curso
    {
        public string uniqueId { get; private set; }
        public string nombre { get; set; }
        public TiposJornada jornada { get; set; }
        
        public Curso()
        {
            uniqueId = Guid.NewGuid().ToString();
        }
    }
}