//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecondDay.DateBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ships
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ships()
        {
            this.Routes = new HashSet<Routes>();
        }
    
        public int RegNumber { get; set; }
        public string Name { get; set; }
        public string Skipper { get; set; }
        public int TypeID { get; set; }
        public decimal Capacity { get; set; }
        public decimal Year { get; set; }
        public byte[] Picture { get; set; }
        public int DockyardID { get; set; }
    
        public virtual Ports Ports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Routes> Routes { get; set; }
        public virtual ShipTypes ShipTypes { get; set; }
    }
}