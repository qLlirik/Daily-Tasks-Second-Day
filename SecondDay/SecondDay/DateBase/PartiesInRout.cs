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
    
    public partial class PartiesInRout
    {
        public int ID { get; set; }
        public decimal PartyCustomValue { get; set; }
        public int RoutID { get; set; }
    
        public virtual Party Party { get; set; }
        public virtual Routes Routes { get; set; }
    }
}
