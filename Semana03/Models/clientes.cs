//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semana03.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel;
    
    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            this.pedidoscabe = new HashSet<pedidoscabe>();
        }
    
        [DisplayName("Código")]
        public string IdCliente { get; set; }

        [DisplayName("Nombre")]
        public string NomCliente { get; set; }

        [DisplayName("Dirección")]
        public string DirCliente { get; set; }

        public string idpais { get; set; }

        [DisplayName("Teléfono")]
        public string fonoCliente { get; set; }
    
        public virtual paises paises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidoscabe> pedidoscabe { get; set; }
    }
}
