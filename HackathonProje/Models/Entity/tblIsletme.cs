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
    
    public partial class tblIsletme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblIsletme()
        {
            this.tblIsletmeKullanici = new HashSet<tblIsletmeKullanici>();
            this.tblKuponlar = new HashSet<tblKuponlar>();
            this.tblKuponlarim = new HashSet<tblKuponlarim>();
            this.tblPuanDetay = new HashSet<tblPuanDetay>();
        }
    
        public long isletmeId { get; set; }
        public string isletmeAdi { get; set; }
        public short puan { get; set; }
        public string adres { get; set; }
        public string aciklama { get; set; }
        public string telefon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIsletmeKullanici> tblIsletmeKullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKuponlar> tblKuponlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKuponlarim> tblKuponlarim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuanDetay> tblPuanDetay { get; set; }
    }
}
