﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorSystem.SysData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCntxt1 : DbContext
    {
        public DbCntxt1()
            : base("name=DbCntxt1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VStorOrdrsOnly> VStorOrdrsOnlies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<std_actvties> std_actvties { get; set; }
        public virtual DbSet<StorOrderDetail> StorOrderDetails { get; set; }
        public virtual DbSet<storOrder> storOrders { get; set; }
        public virtual DbSet<StorProduct> StorProducts { get; set; }
        public virtual DbSet<Stor> Stors { get; set; }
        public virtual DbSet<SysFlag> SysFlags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VOrdrProduct> VOrdrProducts { get; set; }
        public virtual DbSet<VStorProduct> VStorProducts { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<trnr> trnrs { get; set; }
    }
}