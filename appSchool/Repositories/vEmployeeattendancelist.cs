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
    
    public partial class vEmployeeattendancelist
    {
        public int TeacherID { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string Status { get; set; }
        public string EmployeeCode { get; set; }
        public string MobileNo { get; set; }
        public string FatherName { get; set; }
        public string StatusCode { get; set; }
        public Nullable<decimal> Present { get; set; }
        public Nullable<decimal> Absent { get; set; }
        public int SessionID { get; set; }
        public byte BranchID { get; set; }
        public byte CompID { get; set; }
        public string TimeStatus { get; set; }
        public int AttendanceLogId { get; set; }
    }
}
