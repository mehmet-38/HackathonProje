//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HackathonProje.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKuponlarim
    {
        public long kuponKod { get; set; }
        public long kullaniciId { get; set; }
        public long isletmeId { get; set; }
        public decimal indirim { get; set; }
    
        public virtual tblIsletme tblIsletme { get; set; }
        public virtual tblKullanici tblKullanici { get; set; }
    }
}
