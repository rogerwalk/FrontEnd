using System;
using System.Collections.Generic;

namespace Solution.APIW.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            Cafe = new HashSet<Cafe>();
        }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Cafe> Cafe { get; set; }
    }
}
