using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemri
{
    public static class UpravljanjePodacima
    {
        public static List<Proizvod> FiltrirajProizvodePoKategoriji(Kategorija_Proizvoda kategorija, List<Proizvod> proizvodi) 
        {
            List<Proizvod> returnMe = new List<Proizvod>();
            foreach (Proizvod proizvod in proizvodi) 
            {
                if (proizvod.Kategorija_proizvoda_ID == kategorija.ID_kategorije_proizvoda) 
                {
                    returnMe.Add(proizvod);
                }
            }
            return returnMe;
        }

        internal static int VratiIDKategorije(Kategorija_Proizvoda kategorija) 
        {
            return kategorija.ID_kategorije_proizvoda;
        }

        internal static string VratiIDMjerneJedinice(Mjerna_Jedinica jedinica) 
        {
            return jedinica.ID_mjerne_jedinice;
        }

        internal static int VratiIDDobavljaca(Dobavljac dobavljac) 
        {
            return dobavljac.ID_dobavljaca;
        }

        internal static int VratiIDProizvodaca(Proizvodac proizvodac) 
        {
            return proizvodac.ID_proizvodaca;
        }

        internal static Proizvod SmanjiKolicinu(Proizvod proizvod, int kolicina) 
        {
            proizvod.Kolicina_proizvoda -= kolicina;
            return proizvod;
        }
        internal static Proizvod PovecajKolicinu(Proizvod proizvod, int kolicina)
        {
            proizvod.Kolicina_proizvoda += kolicina;
            return proizvod;
        }

        internal static Proizvod PrebaciUNovi(Proizvod proizvod)
        {
            Proizvod novi = new Proizvod();

            novi.ID_proizvoda = proizvod.ID_proizvoda;
            novi.Naziv_proizvoda = proizvod.Naziv_proizvoda;
            novi.Cijena_proizvoda = proizvod.Cijena_proizvoda;
            novi.Kolicina_proizvoda = proizvod.Kolicina_proizvoda;
            novi.Popust = proizvod.Popust;
            novi.Postotak_popusta = proizvod.Postotak_popusta;
            novi.Kategorija_proizvoda_ID = proizvod.Kategorija_proizvoda_ID;
            novi.Dobavljac_ID = proizvod.Dobavljac_ID;
            novi.Proizvodac_ID = proizvod.Proizvodac_ID;
            novi.Mjerna_jedinica_ID = proizvod.Mjerna_jedinica_ID;
            novi.Podruznica_ID = proizvod.Podruznica_ID;

            return novi;
        }

        internal static void DodajNaRacun(Proizvod odabrani, List<Proizvod> proizvodi, List<Proizvod> racun, int unos) 
        {
            if (odabrani.Kolicina_proizvoda >= unos)
            {
                UpravljanjePodacima.SmanjiKolicinu(odabrani, unos);
                Proizvod stari = racun.FirstOrDefault(x => x.ID_proizvoda == odabrani.ID_proizvoda);
                if (stari != null)
                {
                    UpravljanjePodacima.PovecajKolicinu(stari, unos);
                }
                else
                {
                    Proizvod novi = UpravljanjePodacima.PrebaciUNovi(odabrani);
                    novi.Kolicina_proizvoda = unos;
                    racun.Add(novi);
                }
            }
            else
            {
                throw new Exception("Nedostupna kolicina proizvoda!");
            }
        }

        internal static void OduzmiKolicinuSaProizvoda(List<Proizvod> proizvodi, List<Proizvod> racun) 
        {
            foreach (Proizvod item in racun) 
            {
                Proizvod proizvodZaSmanjenje = proizvodi.FirstOrDefault(x => x.ID_proizvoda == item.ID_proizvoda);
                if(proizvodZaSmanjenje != null) proizvodZaSmanjenje.Kolicina_proizvoda -= item.Kolicina_proizvoda;

            }
        }

        internal static void DodajKolicinuProizodaNaProizvode(List<Proizvod> proizvods, Proizvod proizvod)
        {
           Proizvod proizvodZaPovecanje = proizvods.FirstOrDefault(x => x.ID_proizvoda == proizvod.ID_proizvoda);
            if (proizvodZaPovecanje != null) proizvodZaPovecanje.Kolicina_proizvoda += proizvod.Kolicina_proizvoda;
        }

        internal static void DodajJedanProizodaNaProizvode(List<Proizvod> proizvods, Proizvod proizvod)
        {
            Proizvod proizvodZaPovecanje = proizvods.FirstOrDefault(x => x.ID_proizvoda == proizvod.ID_proizvoda);
            if (proizvodZaPovecanje != null) proizvodZaPovecanje.Kolicina_proizvoda += 1;
        }

    }
}
