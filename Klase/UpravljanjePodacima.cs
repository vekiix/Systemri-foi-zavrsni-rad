using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemri
{
    public static class UpravljanjePodacima
    {
        public static List<Proizvod> FiltrirajProizvodePoKategoriji(string txt, List<Proizvod> proizvodi) 
        {
            int id = int.Parse(txt.Split('-')[0]);
            List<Proizvod> returnMe = new List<Proizvod>();
            foreach (Proizvod proizvod in proizvodi) 
            {
                if (proizvod.Kategorija_proizvoda_ID == id) 
                {
                    returnMe.Add(proizvod);
                }
            }
            return returnMe;
        }

        
    }
}
