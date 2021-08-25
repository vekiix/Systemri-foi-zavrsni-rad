//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Systemri
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            this.Racuns = new HashSet<Racun>();
        }
    
        public int ID_korisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
        public string Mjesto_stanovanja { get; set; }
        public string OIB { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public System.DateTime Datum_rodenja { get; set; }
        public System.DateTime UgovorOd { get; set; }
        public Nullable<System.DateTime> UgovorDo { get; set; }
        public int Uloga_ID { get; set; }
        public int Podruznica_ID { get; set; }
    
        public virtual Podruznica Podruznica { get; set; }
        public virtual Uloga Uloga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
