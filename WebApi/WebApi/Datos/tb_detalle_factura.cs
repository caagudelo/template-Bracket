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
    
    public partial class tb_detalle_factura
    {
        public int Id { get; set; }
        public Nullable<int> IdFactura { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<double> ValorUnitario { get; set; }
        public Nullable<double> ValorTotal { get; set; }
    
        public virtual tb_factura tb_factura { get; set; }
    }
}