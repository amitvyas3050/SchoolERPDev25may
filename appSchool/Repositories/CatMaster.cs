//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appSchool.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatMaster
    {
        public byte MCatCode { get; set; }
        public byte GCatCode { get; set; }
        public short CatCode { get; set; }
        public string CatName { get; set; }
        public string DebitBal { get; set; }
        public string CreditBal { get; set; }
        public string Type { get; set; }
        public Nullable<byte> UIdAdd { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<byte> UIdMod { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<byte> UIdDel { get; set; }
        public Nullable<System.DateTime> DelDate { get; set; }
        public Nullable<bool> uploadflag { get; set; }
    }
}
