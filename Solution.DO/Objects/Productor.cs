using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
  public  class Productor
    {
        [Key]
        public int? Id_Productor { get; set; }
        public string Nombre_Productor { get; set; }
        public bool? Activo { get; set; }
    }
}
