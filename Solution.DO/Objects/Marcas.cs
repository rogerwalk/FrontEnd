using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
   public class Marcas 
    {
        [Key]
        public int? Id_Marca { get; set; }
        public string Nombre_Marca { get; set; }
        public bool? Activo { get; set; }
    }
}
