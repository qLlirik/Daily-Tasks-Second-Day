﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Costumers> Costumers { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderInParty> OrderInParty { get; set; }
        public virtual DbSet<PartiesInRout> PartiesInRout { get; set; }
        public virtual DbSet<Party> Party { get; set; }
        public virtual DbSet<Ports> Ports { get; set; }
        public virtual DbSet<PortsInRout> PortsInRout { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<Ships> Ships { get; set; }
        public virtual DbSet<ShipTypes> ShipTypes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Units> Units { get; set; }
    }
}
