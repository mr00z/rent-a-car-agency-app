﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarAgency
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RentACarEntities : DbContext
    {
        public RentACarEntities()
            : base("name=RentACarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENTS> AGENTS { get; set; }
        public virtual DbSet<BASE> BASE { get; set; }
        public virtual DbSet<CAR> CAR { get; set; }
        public virtual DbSet<CLIENTS> CLIENTS { get; set; }
        public virtual DbSet<MECHANICS> MECHANICS { get; set; }
        public virtual DbSet<ORDERS> ORDERS { get; set; }
        public virtual DbSet<ORDERS_ARCHIVE> ORDERS_ARCHIVE { get; set; }
        public virtual DbSet<REPAIRS> REPAIRS { get; set; }
    
        public virtual int ADD_CLIENT(string nAME, string sURNAME, Nullable<int> pHONE_NR, string aDDRESS)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var sURNAMEParameter = sURNAME != null ?
                new ObjectParameter("SURNAME", sURNAME) :
                new ObjectParameter("SURNAME", typeof(string));
    
            var pHONE_NRParameter = pHONE_NR.HasValue ?
                new ObjectParameter("PHONE_NR", pHONE_NR) :
                new ObjectParameter("PHONE_NR", typeof(int));
    
            var aDDRESSParameter = aDDRESS != null ?
                new ObjectParameter("ADDRESS", aDDRESS) :
                new ObjectParameter("ADDRESS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ADD_CLIENT", nAMEParameter, sURNAMEParameter, pHONE_NRParameter, aDDRESSParameter);
        }
    
        public virtual int EDIT_CLIENT(Nullable<int> iD_C, string nAME, string sURNAME, Nullable<int> pHONE_NR, string aDDRESS)
        {
            var iD_CParameter = iD_C.HasValue ?
                new ObjectParameter("ID_C", iD_C) :
                new ObjectParameter("ID_C", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var sURNAMEParameter = sURNAME != null ?
                new ObjectParameter("SURNAME", sURNAME) :
                new ObjectParameter("SURNAME", typeof(string));
    
            var pHONE_NRParameter = pHONE_NR.HasValue ?
                new ObjectParameter("PHONE_NR", pHONE_NR) :
                new ObjectParameter("PHONE_NR", typeof(int));
    
            var aDDRESSParameter = aDDRESS != null ?
                new ObjectParameter("ADDRESS", aDDRESS) :
                new ObjectParameter("ADDRESS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EDIT_CLIENT", iD_CParameter, nAMEParameter, sURNAMEParameter, pHONE_NRParameter, aDDRESSParameter);
        }
    
        public virtual int REMOVE_CLIENT(Nullable<int> iD_CLIENT)
        {
            var iD_CLIENTParameter = iD_CLIENT.HasValue ?
                new ObjectParameter("ID_CLIENT", iD_CLIENT) :
                new ObjectParameter("ID_CLIENT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("REMOVE_CLIENT", iD_CLIENTParameter);
        }
    }
}