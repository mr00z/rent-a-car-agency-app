//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ORDERS_ARCHIVE
    {
        public int ID_ORDER { get; set; }
        public Nullable<int> ID_CLIENT { get; set; }
        public Nullable<int> ID_CAR { get; set; }
        public Nullable<System.DateTime> ORDER_DATE { get; set; }
        public Nullable<System.DateTime> RENT_START_DATE { get; set; }
        public Nullable<System.DateTime> RENT_END_DATE { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
    
        public virtual CAR CAR { get; set; }
        public virtual CLIENTS CLIENTS { get; set; }
    }
}