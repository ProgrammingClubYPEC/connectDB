﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<analyzer> analyzer { get; set; }
        public virtual DbSet<biomaterials_tube> biomaterials_tube { get; set; }
        public virtual DbSet<check_for_insurance> check_for_insurance { get; set; }
        public virtual DbSet<insurance_company> insurance_company { get; set; }
        public virtual DbSet<login> login { get; set; }
        public virtual DbSet<login_history> login_history { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<order_status> order_status { get; set; }
        public virtual DbSet<policy_type> policy_type { get; set; }
        public virtual DbSet<rendered> rendered { get; set; }
        public virtual DbSet<rendered_type> rendered_type { get; set; }
        public virtual DbSet<service> service { get; set; }
        public virtual DbSet<service_status> service_status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<user_confidential_data> user_confidential_data { get; set; }
        public virtual DbSet<user_contact> user_contact { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }
        public virtual DbSet<issued_invoices> issued_invoices { get; set; }
    }
}
