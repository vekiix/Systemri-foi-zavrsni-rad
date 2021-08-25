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
                Korisnik korisnik = (from k in db.Korisniks
                                     where k.Korisnicko_ime == korime && k.Lozinka == lozinka
                                     select k).FirstOrDefault();
                if (korisnik != null) return korisnik;
                else return null;
            }
        }

        internal static double IzracunajTjedniPromet()
        {
            using (var db = new SystemriDBEntities())
            {
                int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                DateTime datum = DateTime.Now.AddDays(-7);
                return (double)(from r in db.Racuns
                                join k in db.Korisniks
                                on r.Korisnik_ID
                                equals k.ID_korisnik
                                join p in db.Podruznicas
                                on k.Podruznica_ID
                                equals p.ID_podruznica
                                where p.ID_podruznica == idPodruznice && r.Datum > datum
                                select r.Ukupan_iznos).Sum();
            }
        }

        internal static double IzracunajDnevniPromet() 
        {
            using (var db = new SystemriDBEntities())
            {
                int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                DateTime datum = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                return (double)(from r in db.Racuns
                                join k in db.Korisniks
                                on r.Korisnik_ID
                                equals k.ID_korisnik
                                join p in db.Podruznicas
                                on k.Podruznica_ID
                                equals p.ID_podruznica
                                where p.ID_podruznica == idPodruznice && r.Datum.Day == datum.Date.Day
                                                                      && r.Datum.Month == datum.Month
                                                                      && r.Datum.Year == datum.Year
                                select r.Ukupan_iznos).Sum();
            }
        }

        internal static double IzracunajMjesecniPromet() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                DateTime datum = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                return (double)(from r in db.Racuns
                                join k in db.Korisniks
                                on r.Korisnik_ID
                                equals k.ID_korisnik
                                join p in db.Podruznicas
                                on k.Podruznica_ID
                                equals p.ID_podruznica
                                where p.ID_podruznica == idPodruznice 
                                                                      && r.Datum.Month == datum.Month
                                                                      && r.Datum.Year == datum.Year
                                select r.Ukupan_iznos).Sum();
            }
        }

        internal static List<Racun> DohvatiRacune()
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from r in db.Racuns
                        where r.Korisnik.Podruznica_ID == id
                        orderby r.ID_racuna descending
                        select r).ToList();          
            }
        }

        internal static void ObrisiRacun(Racun racun)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Racuns.Attach(racun);
                db.Racuns.Remove(racun);
                db.SaveChanges();
            }
        }

        internal static List<Uloga> DohvatiUloge()
        {
            using (var db = new SystemriDBEntities()) 
            {
                return (from u in db.Ulogas
                        select u).ToList();
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

        internal static List<Podruznica> DohvatiPodruznice() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                string naziv = DohvatiImePoduzeca();
                return (from p in db.Podruznicas
                        where p.Poduzece.Naziv_poduzeca == naziv
                        select p).ToList();
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

        internal static void ObrisiKorisnika(Korisnik korisnik)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Korisniks.Attach(korisnik);
                db.Korisniks.Remove(korisnik);
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

        internal static bool ProvjeriKorisnickoIme(string text)
        {
            using (var db = new SystemriDBEntities()) 
            {

                int br = (from k in db.Korisniks
                          where k.Korisnicko_ime == text
                          select k).Count();
                if (br != 0) return false;
                return true;
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
                        where p.Popust == 1 && p.Podruznica_ID == id 
                        select p).ToList();
            }
        }

        internal static void IzmijeniKorisnika(Korisnik stariKorisnik, Korisnik noviKorisnik)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Korisniks.Attach(stariKorisnik);
                stariKorisnik.Ime = noviKorisnik.Ime;
                stariKorisnik.Prezime = noviKorisnik.Prezime;
                stariKorisnik.Email = noviKorisnik.Email;
                stariKorisnik.Korisnicko_ime = noviKorisnik.Korisnicko_ime;
                stariKorisnik.Mjesto_stanovanja = noviKorisnik.Mjesto_stanovanja;
                stariKorisnik.OIB = noviKorisnik.OIB;
                stariKorisnik.Kontakt = noviKorisnik.Kontakt;
                stariKorisnik.Datum_rodenja = noviKorisnik.Datum_rodenja;
                stariKorisnik.UgovorOd = noviKorisnik.UgovorOd;
                stariKorisnik.UgovorDo = noviKorisnik.UgovorDo;
                stariKorisnik.Uloga_ID = noviKorisnik.Uloga_ID;
                stariKorisnik.Podruznica_ID = noviKorisnik.Podruznica_ID;
                db.SaveChanges();
            }
        }

        internal static void DodajKorisnika(Korisnik noviKorisnik)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Korisniks.Add(noviKorisnik);
                db.SaveChanges();
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
                noviRacun.Vrijeme = new TimeSpan(datum.Hour, datum.Minute, datum.Second);
                noviRacun.Ukupan_iznos = 0;
                db.Racuns.Add(noviRacun);
                db.SaveChanges();

                double ukupanIznos=0;
                foreach (var item in racun) 
                {
                    Stavka stavka = new Stavka
                    {
                        Racun_ID = noviRacun.ID_racuna,
                        Kolicina = item.Kolicina_proizvoda,
                        Proizvod_ID = item.ID_proizvoda
                    };


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

        internal static List<Korisnik> DohvatiKorisnike() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                int idKorisnik = PrijavljeniKorisnik.VratiIDKorisnika();
                return (from k in db.Korisniks
                       where k.Podruznica_ID == id && k.ID_korisnik != idKorisnik
                       select k).ToList();
            }
        }

        internal static List<Korisnik> DohvatiSveKorisnike()
        {
            using (var db = new SystemriDBEntities())
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                int idKorisnik = PrijavljeniKorisnik.VratiIDKorisnika();
                return (from k in db.Korisniks
                        where k.Podruznica_ID == id
                        select k).ToList();
            }
        }

        internal static List<Korisnik> DohvatiPretrazeneKorisnike(string text) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int idKorisnik = PrijavljeniKorisnik.VratiIDKorisnika();
                return (from k in db.Korisniks
                        where k.Ime.Contains(text) && k.ID_korisnik != idKorisnik || k.Prezime.Contains(text) && k.ID_korisnik != idKorisnik || k.Korisnicko_ime.Contains(text) && k.ID_korisnik != idKorisnik
                        select k).ToList();
            }
        }
    }
}
