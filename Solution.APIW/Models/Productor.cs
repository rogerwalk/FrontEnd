using System;
using System.Collections.Generic;

namespace Solution.APIW.Models
{
    public partial class Productor
    {
        public Productor()
        {
            Cafe = new HashSet<Cafe>();
        }

        public int IdProductor { get; set; }
        public string NombreProductor { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Cafe> Cafe { get; set; }
    }
}
