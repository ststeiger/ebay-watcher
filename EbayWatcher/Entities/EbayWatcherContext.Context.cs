﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EbayWatcher.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EbayWatcherContext : DbContext
    {
        public EbayWatcherContext()
            : base("name=EbayWatcherContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WishlistItemHistoricalItem> WishlistItemHistoricalItems { get; set; }
        public virtual DbSet<WishlistItemIgnoreItem> WishlistItemIgnoreItems { get; set; }
        public virtual DbSet<WishlistItem> WishlistItems { get; set; }
    }
}
