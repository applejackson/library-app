﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryPri
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbLibraryEntities : DbContext
    {
        public dbLibraryEntities()
            : base("name=dbLibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<bilet> bilet { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<manInfo> manInfo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}