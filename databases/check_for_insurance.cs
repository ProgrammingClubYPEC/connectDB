//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace connectDB.databases
{
    using System;
    using System.Collections.Generic;
    
    public partial class check_for_insurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public check_for_insurance()
        {
            this.issued_invoices = new HashSet<issued_invoices>();
        }
    
        public long check_code { get; set; }
        public decimal sum { get; set; }
        public string service_list { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<issued_invoices> issued_invoices { get; set; }
    }
}
