//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gym_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int staffID { get; set; }
        public string staffTC { get; set; }
        public string staffName { get; set; }
        public string staffSurname { get; set; }
        public System.DateTime staffbirthDate { get; set; }
        public string staffGSM { get; set; }
        public Nullable<System.DateTime> staffstartDate { get; set; }
        public Nullable<System.DateTime> staffendDate { get; set; }
        public int staffCategory { get; set; }
        public string staffuserName { get; set; }
        public string staffPassword { get; set; }
        public bool staffState { get; set; }
        public string staffeMail { get; set; }
    
        public virtual StaffCategory StaffCategory1 { get; set; }
    }
}
