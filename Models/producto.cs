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
    
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.detalleFactura = new HashSet<detalleFactura>();
            this.stock = new HashSet<stock>();
        }
    
        public int ProductoId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precioUnitario { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public double porcentajeRentabilidad { get; set; }
        public string talle { get; set; }
        public string color { get; set; }
        public string marca { get; set; }
        public int ProveedorId { get; set; }
        public string codigo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleFactura> detalleFactura { get; set; }
        public virtual personaJuridica personaJuridica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stock> stock { get; set; }
    }
}
