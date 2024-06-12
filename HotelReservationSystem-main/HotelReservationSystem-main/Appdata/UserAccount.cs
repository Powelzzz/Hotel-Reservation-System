//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservationSystem.Appdata
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAccount()
        {
            this.GuestInformation = new HashSet<GuestInformation>();
            this.PaymentInfo = new HashSet<PaymentInfo>();
            this.ReservationInfo = new HashSet<ReservationInfo>();
            this.StaffInfo = new HashSet<StaffInfo>();
        }
    
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userStatus { get; set; }
        public Nullable<System.DateTime> userDateCreated { get; set; }
        public Nullable<System.DateTime> userDateUpdated { get; set; }
        public Nullable<int> roleId { get; set; }
        public Nullable<int> createdById { get; set; }
        public string createdByUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuestInformation> GuestInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentInfo> PaymentInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationInfo> ReservationInfo { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffInfo> StaffInfo { get; set; }
    }
}
