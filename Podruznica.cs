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
    
    public partial class Podruznica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Podruznica()
        {
            this.Korisniks = new HashSet<Korisnik>();
            this.Proizvods = new HashSet<Proizvod>();
        }
    
        public int ID_podruznica { get; set; }
        public string Adresa_podruznice { get; set; }
        public int Poduzece_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual Poduzece Poduzece { get; set; }
        public virtual Podruznica Podruznica1 { get; set; }
        public virtual Podruznica Podruznica2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proizvod> Proizvods { get; set; }

        public override string ToString()
        {
            return ID_podruznica.ToString();
        }
    }
}
