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
    
    public partial class FacultyAllotmentDetail
    {
        public int ID { get; set; }
        public Nullable<int> SessionID { get; set; }
        public int FacultyAllotmentID { get; set; }
        public int SubjectIDL1 { get; set; }
        public int SubjectIDL2 { get; set; }
        public int SubjectIDL3 { get; set; }
        public byte BranchID { get; set; }
        public byte CompID { get; set; }
    }
}
