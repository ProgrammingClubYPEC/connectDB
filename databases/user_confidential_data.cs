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
    
    public partial class user_confidential_data
    {
        public string login { get; set; }
        public int passport_series { get; set; }
        public int passport_id { get; set; }
        public string insurance_policy_number { get; set; }
        public long insurance_policy_type_code { get; set; }
        public long insurance_company_code { get; set; }
    
        public virtual insurance_company insurance_company { get; set; }
        public virtual policy_type policy_type { get; set; }
        public virtual user user { get; set; }
    }
}
