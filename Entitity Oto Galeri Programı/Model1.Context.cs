﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entitity_Oto_Galeri_Programı
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OtoGaleriOtomasyonuEntities1 : DbContext
    {
        public OtoGaleriOtomasyonuEntities1()
            : base("name=OtoGaleriOtomasyonuEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLARAÇLAR> TBLARAÇLAR { get; set; }
        public virtual DbSet<TBLKAYITLAR> TBLKAYITLAR { get; set; }
        public virtual DbSet<TBLKULLANICILAR> TBLKULLANICILAR { get; set; }
        public virtual DbSet<TBLMÜSTERİLER> TBLMÜSTERİLER { get; set; }
        public virtual DbSet<TBLPERSONELLER> TBLPERSONELLER { get; set; }
        public virtual DbSet<TBLŞUBELER> TBLŞUBELER { get; set; }
        public virtual DbSet<TBLSOZLESME> TBLSOZLESME { get; set; }
    
        public virtual ObjectResult<sozlesme_Result> sozlesme()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sozlesme_Result>("sozlesme");
        }
    
        public virtual ObjectResult<sözlesme2_Result> sözlesme2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sözlesme2_Result>("sözlesme2");
        }
    
        public virtual ObjectResult<string> araclar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("araclar");
        }
    
        public virtual ObjectResult<kiralıkaracprocedure_Result> kiralıkaracprocedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<kiralıkaracprocedure_Result>("kiralıkaracprocedure");
        }
    
        public virtual ObjectResult<kiralıkaraclartablosu_Result> kiralıkaraclartablosu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<kiralıkaraclartablosu_Result>("kiralıkaraclartablosu");
        }
    
        public virtual ObjectResult<satılıkaracprocedure_Result> satılıkaracprocedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<satılıkaracprocedure_Result>("satılıkaracprocedure");
        }
    }
}
