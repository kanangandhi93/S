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
    
    public partial class tblRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRoom()
        {
            this.tblAssets = new HashSet<tblAsset>();
        }
    
        public long RoomId { get; set; }
        public string RoomName { get; set; }
        public Nullable<long> StdId { get; set; }
        public Nullable<long> ClassTypeId { get; set; }
        public Nullable<int> BrId { get; set; }
        public Nullable<long> SchoolId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAsset> tblAssets { get; set; }
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblClassType tblClassType { get; set; }
        public virtual tblSchool tblSchool { get; set; }
        public virtual tblStd tblStd { get; set; }
    }
}
