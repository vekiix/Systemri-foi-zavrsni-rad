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

        

        
    }
}
