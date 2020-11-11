using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public class Cafe
    {
        [Key]
        public int? Id_Cafe { get; set; }
        public int? Id_Marca { get; set; }
        public int? Id_Productor { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public bool? Activo { get; set; }

       
    }
}
