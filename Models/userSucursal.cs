//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yamy_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class userSucursal
    {
        public int UserSucursalId { get; set; }
        public string userName { get; set; }
        public int SucursalId { get; set; }
    
        public virtual sucursal sucursal { get; set; }
    }
}
