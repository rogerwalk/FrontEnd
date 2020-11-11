using System;
using System.Collections.Generic;

namespace Solution.APIW.Models
{
    public partial class UsuariosRoles
    {
        public int IdUsuarioRol { get; set; }
        public int IdRol { get; set; }
        public int? IdUsuario { get; set; }
    }
}
