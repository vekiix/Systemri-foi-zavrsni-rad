using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemri
{
    public static class DBRepository
    {
        internal static Korisnik DohvatiKorisnika(string korime, string lozinka) 
        {
            using (var db = new SystemriDBEntities())
            {
                var lozinka1 = PrijavljeniKorisnik.SHA(lozinka);
                Korisnik korisnik = (from k in db.Korisniks
                                     where k.Korisnicko_ime == korime && k.Lozinka == lozinka1
                                     select k).FirstOrDefault();
                if (korisnik != null) return korisnik;
                else return null;
            }
        }

        internal static List<Proizvod> DohvatiProizvode() 
        {
            List<Proizvod> proizvodi;
            int podruznica = PrijavljeniKorisnik.VratiIDPodruznice();
            using (var db = new SystemriDBEntities()) 
            {
                proizvodi = (from p in db.Proizvods
                            where p.Podruznica_ID == podruznica
                            select p).ToList();
                return proizvodi;
            }
            
        }

        internal static string DohvatiImePoduzeca() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                string naziv = (from p in db.Poduzeces
                                    join po in db.Podruznicas
                                    on p.ID_poduzeca 
                                    equals po.Poduzece_ID
                                    where po.ID_podruznica == id
                                    select p.Naziv_poduzeca).FirstOrDefault();
                return naziv;
            }
        }

        internal static List<Proizvod> DohvatiProizvodeSaSmanjenomZalihomINaPopustu()
        {
            using (var db = new SystemriDBEntities())
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from p in db.Proizvods
                        where p.Kolicina_proizvoda <= 5 && p.Popust == 1 && p.Podruznica_ID == id
                        select p).ToList();
            }
        }

        internal static List<Proizvod> DohvatiProizvodeSaSmanjenomZalihom() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from p in db.Proizvods
                        where p.Kolicina_proizvoda <= 5 && p.Podruznica_ID == id
                        select p).ToList();
            }
            
        }

        internal static List<Kategorija_Proizvoda> DohvatiKategorijeProizvoda() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                return (from kp in db.Kategorija_Proizvoda
                        select kp).ToList();
            }
            
        }
        

        internal static List<Proizvod> DohvatiProizvodeNaPopustu() 
        {
            using (var db = new SystemriDBEntities())
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from p in db.Proizvods 
                        where p.Popust == 1 && p.Podruznica_ID == id && p.Podruznica_ID == id 
                        select p).ToList();
            }
        }

        internal static List<Proizvod> DohvatiPretrazeneProizvode(string txt) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from p in db.Proizvods
                        where p.Podruznica_ID == id && p.Naziv_proizvoda.Contains(txt)
                        select p).ToList();
            }
            
        }

        internal static string DohvatiImeDobavljaca(int id) 
        {
            using (var db = new SystemriDBEntities())
            {
                return (from d in db.Dobavljacs
                        where d.ID_dobavljaca == id
                        select d.Naziv_dobavljaca).FirstOrDefault();
            }
        }

        internal static string DohvatiImeProizvodaca(int id) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                return (from p in db.Proizvodacs
                       where p.ID_proizvodaca == id
                       select p.Naziv_proizvodaca).FirstOrDefault();
            }
        }

        internal static string DohvatiImeKategorije(int id) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                return (from kp in db.Kategorija_Proizvoda
                        where kp.ID_kategorije_proizvoda == id
                        select kp.Naziv_kategorije_proizvoda).FirstOrDefault();
            }
        }

        internal static string DohvatiImeMjerneJedinice(string id)
        {
            using (var db = new SystemriDBEntities())
            {
                return (from mj in db.Mjerna_Jedinica
                        where mj.ID_mjerne_jedinice == id
                        select mj.Naziv_mjerne_jedinice).FirstOrDefault();
            }
        }

        internal static void ObrisiProizvod(Proizvod proizvod)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Proizvods.Attach(proizvod);
                db.Proizvods.Remove(proizvod);
                db.SaveChanges();
            }
        }
    }
}
