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
    
    public partial class issued_invoices
    {
        public string login { get; set; }
        public long check_code { get; set; }
        public long insurance_company_code { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual check_for_insurance check_for_insurance { get; set; }
        public virtual insurance_company insurance_company { get; set; }
        public virtual user user { get; set; }
    }
}
