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
    
    public partial class Stavka
    {
        public int ID_stavke { get; set; }
        public int Kolicina { get; set; }
        public double Ukupan_iznos { get; set; }
        public int Proizvod_ID { get; set; }
        public int Racun_ID { get; set; }
    
        public virtual Proizvod Proizvod { get; set; }
        public virtual Racun Racun { get; set; }
    }
}
