//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace logindemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class MSTUSER
    {
        public long RID { get; set; }

        [DisplayName("Username")]        
        [Required(ErrorMessage ="Username in Required")]
        public string USERNAME { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password in Required")]
        public string PASSWORD { get; set; }
    }
}
