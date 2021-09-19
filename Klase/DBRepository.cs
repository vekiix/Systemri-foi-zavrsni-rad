using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systemri.Klase;

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

        internal static Korisnik DohvatiPrijavljenogKorisnika()
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDKorisnika();
                return (from k in db.Korisniks
                        where k.ID_korisnik == id
                        select k).FirstOrDefault();
            }
        }

        internal static double IzracunajTjedniPromet()
        {
            using (var db = new SystemriDBEntities())
            {
                try 
                {
                    int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                    DateTime datum = DateTime.Now.AddDays(-7);
                    var lista = (from r in db.Racuns
                                    join s in db.Stavkas
                                    on r.ID_racuna
                                    equals s.Racun_ID
                                    join p in db.Proizvods
                                    on s.Proizvod_ID
                                    equals p.ID_proizvoda
                                    where p.Podruznica_ID == idPodruznice && r.Datum>datum
                                    select r).Distinct().ToList();
                    return (double)lista.Sum(x => x.Ukupan_iznos);
                }
                catch(Exception)
                {
                    return 0;
                } 
            }
        }

        internal static List<Stavka> DohvatiStavke(Racun racun)
        {
            using (var db = new SystemriDBEntities()) 
            {
                return (from s in db.Stavkas
                        where s.Racun_ID == racun.ID_racuna
                        orderby s.Proizvod_ID descending
                        select s).ToList();
            }
        }

        internal static void PromijeniLozinku(string text)
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDKorisnika();
                Korisnik korisnik = (from k in db.Korisniks
                                     where k.ID_korisnik == id
                                     select k).FirstOrDefault();
                db.Korisniks.Attach(korisnik);
                korisnik.Lozinka = PrijavljeniKorisnik.SHA(text);
                db.SaveChanges();
            }
        }

        internal static string VratiAdresuPodruznice() 
        {
            int id = PrijavljeniKorisnik.VratiIDPodruznice();
            using (var db = new SystemriDBEntities()) 
            {
                return (from p in db.Podruznicas
                       where p.ID_podruznica == id
                       select p.Adresa_podruznice).FirstOrDefault();
            }
        }
        internal static List<Klase.PodaciGrafikon> DohvatiKategorijeIBrojProdanihProizvodaZaProteklaTriMjeseca() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                DateTime datum = DateTime.Now.AddMonths(-3);
                var list = (from s in db.Stavkas
                                     join p in db.Proizvods
                                     on s.Proizvod_ID
                                     equals p.ID_proizvoda
                                     join kp in db.Kategorija_Proizvoda
                                     on p.Kategorija_proizvoda_ID
                                     equals kp.ID_kategorije_proizvoda
                                     where p.Podruznica_ID == id && s.Racun.Datum > datum
                                     group s by kp.Naziv_kategorije_proizvoda into g
                                     select new Klase.PodaciGrafikon()
                                        {
                                         Kolicina = g.Sum(s => s.Kolicina),
                                         Naziv_kategorije = g.Key,
                                        }
                                     );
                list.GroupBy(x => x.Naziv_kategorije);
                if (list != null) return list.ToList();
                else return null;
            }
        }

        internal static List<PodaciGrafikon> DohvatiKategorijeIBrojProizvodaNaPopustu()
        {
            using (var db = new SystemriDBEntities()) 
            {
                var id = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from kp in db.Kategorija_Proizvoda
                        join p in db.Proizvods
                        on kp.ID_kategorije_proizvoda equals p.Kategorija_proizvoda_ID
                        where p.Podruznica_ID == id && p.Popust == 1
                        group p by kp.Naziv_kategorije_proizvoda into g
                        select new Klase.PodaciGrafikon
                        {
                            Kolicina = g.Count(p => p.Popust == 1),
                            Naziv_kategorije = g.Key
                        }).ToList();
            }
        }

        internal static List<Klase.PodaciGrafikon> DohvatiKategorijeIKolicinuDostupnihProizvoda()
        {
            using (var db = new SystemriDBEntities())
            {
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                var list = (from kp in db.Kategorija_Proizvoda
                            join p in db.Proizvods
                            on kp.ID_kategorije_proizvoda equals p.Kategorija_proizvoda_ID
                            where p.Podruznica_ID == id
                            group p by kp.Naziv_kategorije_proizvoda into g
                            select new Klase.PodaciGrafikon()
                            {
                                Kolicina = g.Sum(p => p.Kolicina_proizvoda),
                                Naziv_kategorije = g.Key,
                            });
                list.GroupBy(x => x.Naziv_kategorije);
                if (list != null) return list.ToList();
                else return null;
            }
        }

        internal static void DodajPodruznicu(Podruznica podruznica)
        {
            using (var db = new SystemriDBEntities()) 
            {
                string naziv = PrijavljeniKorisnik.VratiImePoduzeca();
                podruznica.Poduzece_ID = db.Poduzeces.FirstOrDefault(x => x.Naziv_poduzeca == naziv).ID_poduzeca;
                db.Podruznicas.Add(podruznica);
                db.SaveChanges();
            }
        }

        internal static List<Podruznica> DohvatiPretrazenePodruznice(string text)
        {
            using (var db = new SystemriDBEntities()) 
            {
                   return (from p in db.Podruznicas
                           where p.Adresa_podruznice.Contains(text)
                           select p).ToList();
                
            }
        }

        internal static double IzracunajDnevniPromet() 
        {
            using (var db = new SystemriDBEntities())
            {
                int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                DateTime datum = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                try
                {
                    var lista = (from r in db.Racuns
                                               join s in db.Stavkas
                                               on r.ID_racuna
                                               equals s.Racun_ID
                                               join p in db.Proizvods
                                               on s.Proizvod_ID
                                               equals p.ID_proizvoda
                                               where p.Podruznica_ID == idPodruznice && r.Datum.Day == datum.Date.Day
                                                                                     && r.Datum.Month == datum.Month
                                                                                     && r.Datum.Year == datum.Year
                                               select r).Distinct().ToList();
                    return (double)lista.Sum(x => x.Ukupan_iznos);
                }
                catch(Exception) 
                {
                    return 0;
                }
            }
        }


        internal static void ObrisiPodruznicu(Podruznica podruznica)
        {
            using (var db = new SystemriDBEntities()) 
            {
                db.Podruznicas.Attach(podruznica);
                db.Podruznicas.Remove(podruznica);
                db.SaveChanges();
            }
        }

        internal static double IzracunajMjesecniPromet() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                try
                {
                    int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                    DateTime datum = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                    var lista = (from r in db.Racuns
                                         join s in db.Stavkas
                                         on r.ID_racuna
                                         equals s.Racun_ID
                                         join p in db.Proizvods
                                         on s.Proizvod_ID
                                         equals p.ID_proizvoda
                                         where p.Podruznica_ID == idPodruznice && r.Datum.Month == datum.Month
                                                                               && r.Datum.Year == datum.Year
                                         select r).Distinct().ToList();
                    return (double)lista.Sum(x => x.Ukupan_iznos);
                }
                catch(Exception) 
                {
                    return 0;
                }
                
            }
        }

        internal static List<Racun> DohvatiRacune()
        {
            List<Racun> returnMe = new List<Racun>();
            using (var db = new SystemriDBEntities()) 
            {
                db.Configuration.LazyLoadingEnabled = false;
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                List<int> lista = (from r in db.Racuns
                             join s in db.Stavkas
                             on r.ID_racuna equals s.Racun_ID
                             join p in db.Proizvods
                             on s.Proizvod_ID equals p.ID_proizvoda
                             where p.Podruznica_ID == id
                             select r.ID_racuna).Distinct().ToList();

                foreach (int item in lista) 
                {
                    Racun racun = db.Racuns.FirstOrDefault(x => x.ID_racuna == item);
                    returnMe.Add(racun);
                }

            }
            return returnMe;
        }

        internal static List<Proizvod> DohvatiProizvodeSaRacuna(Racun racun) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                List<Stavka> stavkas = db.Stavkas.Where(x => x.Racun_ID == racun.ID_racuna).ToList();
                List<Proizvod> returnMe = new List<Proizvod>();
                foreach (Stavka item in stavkas) 
                {
                    returnMe.Add(db.Proizvods.FirstOrDefault(x => x.ID_proizvoda == item.Proizvod_ID));
                }
                returnMe.OrderByDescending(x => x.ID_proizvoda);
                return returnMe;
            }
        }

        internal static List<Racun> DohvatiStvoreneRacune() 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int id = PrijavljeniKorisnik.VratiIDKorisnika();
                return (from r in db.Racuns
                        where r.Korisnik_ID == id
                        orderby r.ID_racuna descending
                        select r).ToList();
            }
        }

        internal static void AzurirajProizvodeNakonBrisanja(Racun racun) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                var lista = (from s in db.Stavkas
                             where s.Racun_ID == racun.ID_racuna
                             select s).ToList();
                foreach (var item in lista) 
                {
                    Proizvod proizvod = db.Proizvods.FirstOrDefault(x => x.ID_proizvoda == item.Proizvod_ID);
                    db.Proizvods.Attach(proizvod);
                    proizvod.Kolicina_proizvoda += item.Kolicina;
                }
                db.SaveChanges();
            }
        }

        internal static void ObrisiRacun(Racun racun)
        {
            using (var db = new SystemriDBEntities()) 
            {
                AzurirajProizvodeNakonBrisanja(racun);
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
                int id = PrijavljeniKorisnik.VratiIDPodruznice();
                IEnumerable<Kategorija_Proizvoda> kategorije = (from p in db.Proizvods
                                  join kp in db.Kategorija_Proizvoda
                                  on p.Kategorija_proizvoda_ID
                                  equals kp.ID_kategorije_proizvoda
                                  where p.Podruznica_ID == id
                                  select kp);
                
                if (kategorije != null) return kategorije.ToList();
                else return null;
            }  
        }

        internal static List<Kategorija_Proizvoda> DohvatiSveKategorijeProizvoda() 
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

        internal static Racun NapraviRacun(List<Proizvod> racun)
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
                return noviRacun;
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
                int uloga = UpravljanjePodacima.VratiIDUloge(PrijavljeniKorisnik.VratiUlogu());
                return (from k in db.Korisniks
                        where k.Podruznica_ID == id && k.ID_korisnik != idKorisnik && k.Uloga_ID < uloga
                        select k).ToList();
            }
        }

        internal static List<Korisnik> DohvatiSveKorisnike()
        {
            using (var db = new SystemriDBEntities())
            {
                string id = PrijavljeniKorisnik.VratiImePoduzeca();
                return (from k in db.Korisniks
                        where k.Podruznica.Poduzece.Naziv_poduzeca == id
                        select k).ToList();
            }
        }

        internal static List<Korisnik> DohvatiPretrazeneKorisnike(string text) 
        {
            using (var db = new SystemriDBEntities()) 
            {
                int idUloge = UpravljanjePodacima.VratiIDUloge(PrijavljeniKorisnik.VratiUlogu());
                int idKorisnik = PrijavljeniKorisnik.VratiIDKorisnika();
                int idPodruznice = PrijavljeniKorisnik.VratiIDPodruznice();
                return (from k in db.Korisniks
                        where k.Ime.Contains(text) && k.ID_korisnik != idKorisnik && k.Podruznica_ID == idPodruznice && k.Uloga_ID < idUloge
                        || k.Prezime.Contains(text) && k.ID_korisnik != idKorisnik && k.Podruznica_ID == idPodruznice && k.Uloga_ID < idUloge
                        || k.Korisnicko_ime.Contains(text) && k.ID_korisnik != idKorisnik && k.Podruznica_ID == idPodruznice && k.Uloga_ID < idUloge
                        select k).ToList();
            }
        }
    }
}
