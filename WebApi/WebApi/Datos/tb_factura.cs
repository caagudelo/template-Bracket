//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_factura()
        {
            this.tb_detalle_factura = new HashSet<tb_detalle_factura>();
        }
    
        public int NumeroFactura { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<bool> Autoretenedor { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> ValorTotal { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_detalle_factura> tb_detalle_factura { get; set; }
        public virtual tb_estado tb_estado { get; set; }
    }
}