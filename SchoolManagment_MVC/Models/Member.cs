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
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public int memberID { get; set; }
        public string memberTC { get; set; }
        public string memberName { get; set; }
        public string memberSurname { get; set; }
        public System.DateTime memberBirthDate { get; set; }
        public string memberSex { get; set; }
        public Nullable<System.DateTime> membershipStartDate { get; set; }
        public Nullable<System.DateTime> memberShipEndDate { get; set; }
        public Nullable<bool> memberState { get; set; }
        public int memberWeight { get; set; }
        public int memberHeight { get; set; }
        public string memberBloodGroup { get; set; }
        public string membereMail { get; set; }
        public Nullable<int> planID { get; set; }
    
        public virtual membershipPlan membershipPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
