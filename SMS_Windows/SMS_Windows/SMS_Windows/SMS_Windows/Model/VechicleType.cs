//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS_Windows.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VechicleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VechicleType()
        {
            this.tblVehiclePrevillages = new HashSet<tblVehiclePrevillage>();
        }
    
        public long VechicleTypeId { get; set; }
        public string VechicleType1 { get; set; }
        public Nullable<int> BrId { get; set; }
        public Nullable<long> SchoolId { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblSchool tblSchool { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVehiclePrevillage> tblVehiclePrevillages { get; set; }
    }
}