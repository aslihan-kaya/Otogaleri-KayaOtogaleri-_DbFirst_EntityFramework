﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otogaleri_KayaOtogaleri__DbFirst_EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GaleriEntities2 : DbContext
    {
        public GaleriEntities2()
            : base("name=GaleriEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AracBilgileri> AracBilgileris { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
        public virtual DbSet<MusteriBilgileri> MusteriBilgileris { get; set; }
        public virtual DbSet<SubeBilgileri> SubeBilgileris { get; set; }
    }
}
