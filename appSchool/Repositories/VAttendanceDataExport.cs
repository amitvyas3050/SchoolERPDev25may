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
    
    public partial class VAttendanceDataExport
    {
        public int ClassAttendanceID { get; set; }
        public int ClassSetupID { get; set; }
        public string ClassSetupName { get; set; }
        public System.DateTime AttendanceDate { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public int SessionID { get; set; }
        public int StudentAttendanceID { get; set; }
        public int StudentID { get; set; }
        public string Attendance { get; set; }
        public string Description { get; set; }
        public string EnrollmentNo { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string SMSMobileNo { get; set; }
        public Nullable<int> RollNo { get; set; }
        public Nullable<byte> CompID { get; set; }
        public Nullable<byte> BranchID { get; set; }
    }
}
