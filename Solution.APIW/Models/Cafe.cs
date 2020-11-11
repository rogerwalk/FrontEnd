using System;
using System.Collections.Generic;

namespace Solution.APIW.Models
{
    public partial class Cafe
    {
        public int IdCafe { get; set; }
        public int IdMarca { get; set; }
        public int IdProductor { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public bool? Activo { get; set; }

        public virtual Marcas IdMarcaNavigation { get; set; }
        public virtual Productor IdProductorNavigation { get; set; }
    }
}
