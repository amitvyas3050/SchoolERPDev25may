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
    
    public partial class AssessmentGroupMaster
    {
        public int AssessmentID { get; set; }
        public string AssessmentName { get; set; }
        public Nullable<int> TotalPercent { get; set; }
        public Nullable<int> AssessmentOrder { get; set; }
        public Nullable<int> SessionID { get; set; }
        public Nullable<byte> UIDAdd { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<byte> UIDMod { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public byte BranchID { get; set; }
        public byte CompID { get; set; }
    }
}
