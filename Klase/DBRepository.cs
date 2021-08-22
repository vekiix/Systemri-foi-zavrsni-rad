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

        internal static void DodijeliPopust(int br, Proizvod proizvod)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Proizvods.Attach(proizvod);
                proizvod.Popust = 1;
                proizvod.Postotak_popusta =(float) br / 100;
                db.SaveChanges();
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

        internal static void DodajKategorijuProizvoda(Kategorija_Proizvoda kategorija)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Kategorija_Proizvoda.Add(kategorija);
                db.SaveChanges();
            }
        }

        internal static void DodajDobavljaca(Dobavljac dobavljac)
        {
            using (var db = new SystemriDBEntities())
            {
                db.Dobavljacs.Add(dobavljac);
                db.SaveChanges();
            }
        }

        internal static void DodajProizvodaca(Proizvodac proizvodac)
        {
            using (var db = new SystemriDBEntities())
            {
                db.Proizvodacs.Add(proizvodac);
                db.SaveChanges();
            }
        }

        internal static void DodajMjernuJedinicu(Mjerna_Jedinica jedinica)
        {
            using (var db = new SystemriDBEntities())
            {
                db.Mjerna_Jedinica.Add(jedinica);
                db.SaveChanges();
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

        internal static List<Mjerna_Jedinica> DohvatiMjerneJedinice()
        {
            using (var db = new SystemriDBEntities()) 
            {
                return (from mj in db.Mjerna_Jedinica
                        select mj).ToList();
            }
        }

        internal static List<Proizvodac> DohvatiProizvodace()
        {
            using (var db = new SystemriDBEntities())
            {
                return (from p in db.Proizvodacs
                        select p).ToList();
            }
        }

        internal static void NapraviRacun(List<Proizvod> racun)
        {
            using (var db = new SystemriDBEntities()) 
            {
                Racun noviRacun = new Racun();
                DateTime datum = DateTime.Now;
                noviRacun.Korisnik_ID = PrijavljeniKorisnik.VratiIDKorisnika();
                noviRacun.Datum = datum.Date;
                noviRacun.Vrijeme = datum.TimeOfDay;

                db.Racuns.Add(noviRacun);
                db.SaveChanges();

                double ukupanIznos=0;
                foreach (var item in racun) 
                {
                    Stavka stavka = new Stavka();
                    stavka.Racun_ID = noviRacun.ID_racuna;
                    stavka.Kolicina = item.Kolicina_proizvoda;
                    stavka.Proizvod_ID = item.ID_proizvoda;
                    

                    Proizvod proizvod = db.Proizvods.FirstOrDefault(x => x.ID_proizvoda == item.ID_proizvoda);
                    proizvod.Kolicina_proizvoda -= item.Kolicina_proizvoda;

                    if (item.Popust == 0)
                    {
                        stavka.Ukupan_iznos = Math.Round(item.Cijena_proizvoda * item.Kolicina_proizvoda,2);
                    }
                    else 
                    {
                        stavka.Ukupan_iznos = Math.Round((double)((item.Cijena_proizvoda * (1- item.Postotak_popusta)) * item.Kolicina_proizvoda),2);
                    }
                    ukupanIznos += stavka.Ukupan_iznos;
                    db.Stavkas.Add(stavka);   

                }
                db.Racuns.Attach(noviRacun);
                noviRacun.Ukupan_iznos = Math.Round(ukupanIznos,2);
                
                db.SaveChanges();
            }
        }

        internal static List<Dobavljac> DohvatiDobavljace()
        {
            using (var db = new SystemriDBEntities())
            {
                return (from d in db.Dobavljacs
                        select d).ToList();
            }
        }

        internal static void ObrisiKategoriju(Kategorija_Proizvoda kategorija) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Kategorija_Proizvoda.Attach(kategorija);
                db.Kategorija_Proizvoda.Remove(kategorija);
                db.SaveChanges();
            }
        }

        internal static void DodajProizvod(Proizvod proizvod)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Proizvods.Add(proizvod);
                db.SaveChanges();
            }
        }

        internal static void ObrisiMjernuJedinicu(Mjerna_Jedinica mjerna)
        {
            using (var db = new SystemriDBEntities())
            {
                db.Mjerna_Jedinica.Attach(mjerna);
                db.Mjerna_Jedinica.Remove(mjerna);
                db.SaveChanges();
            }
        }

        internal static void ObrisiDobavljaca(Dobavljac dobavljac)
        {
            using (var db = new SystemriDBEntities())
            {
                db.Dobavljacs.Attach(dobavljac);
                db.Dobavljacs.Remove(dobavljac);
                db.SaveChanges();
            }
        }

        internal static void ObrisiProizvodaca(Proizvodac proizvodac)
        {
            using (var db = new SystemriDBEntities())
            {
                db.Proizvodacs.Attach(proizvodac);
                db.Proizvodacs.Remove(proizvodac);
                db.SaveChanges();
            }
        }

        internal static void AzurirajProizvod(Proizvod stariProizvod, Proizvod proizvod)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Proizvods.Attach(stariProizvod);
                stariProizvod.Naziv_proizvoda = proizvod.Naziv_proizvoda;
                stariProizvod.Kolicina_proizvoda = proizvod.Kolicina_proizvoda;
                stariProizvod.Cijena_proizvoda = proizvod.Cijena_proizvoda;
                stariProizvod.Kategorija_proizvoda_ID = proizvod.Kategorija_proizvoda_ID;
                stariProizvod.Dobavljac_ID = proizvod.Dobavljac_ID;
                stariProizvod.Proizvodac_ID = proizvod.Proizvodac_ID;
                stariProizvod.Mjerna_jedinica_ID = proizvod.Mjerna_jedinica_ID;
                db.SaveChanges();
            }
        }

        internal static void MakniPopust(Proizvod proizvod) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Proizvods.Attach(proizvod);
                proizvod.Popust = 0;
                proizvod.Postotak_popusta = 0;
                db.SaveChanges();
            }
        }
    }
}
