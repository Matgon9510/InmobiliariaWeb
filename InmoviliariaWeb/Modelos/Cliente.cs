//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InmoviliariaWeb.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente : Base
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public int tipo_tel { get; set; }
        public string telefono { get; set; }
        public int genero { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
    }
}
