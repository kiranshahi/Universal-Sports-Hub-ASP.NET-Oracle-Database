//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2016_17_S_CC6001NI_14046931_Kiran_Shahi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM()
        {
            this.SESSIONS = new HashSet<SESSION>();
        }
        [DisplayName("Room ID")]
        public int ROOM_ID { get; set; }
        [DisplayName("Room Name")]
        public string ROOM_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSION> SESSIONS { get; set; }
    }
}
