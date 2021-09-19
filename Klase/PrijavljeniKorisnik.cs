using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Systemri
{
    public static class PrijavljeniKorisnik
    {
        private static int ID_korisnik { get; set; }
        private static string korisnicko_ime { get; set; }
        private  static int podruznica_ID { get; set; }
        private  static int uloga_ID { get; set; }
        private static string ime_poduzeca { get; set; }

        

        public static string SHA(string data)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        internal static void PohraniPodatke(Korisnik korisnik) 
        {
            ID_korisnik = korisnik.ID_korisnik;
            korisnicko_ime = korisnik.Korisnicko_ime;
            podruznica_ID = korisnik.Podruznica_ID;
            uloga_ID = korisnik.Uloga_ID;
            ime_poduzeca = DBRepository.DohvatiImePoduzeca();
        }

        public static bool Prijava(string korime, string lozinka) 
        {
            Korisnik korisnik = DBRepository.DohvatiKorisnika(korime, SHA(lozinka));
            if (korisnik != null) 
            {
                PohraniPodatke(korisnik);
                return true;         
            }
            else throw new Exception("Neispravno korisnicko ime ili lozinka!");
        }

        public static string VratiKorIme() 
        {
            return korisnicko_ime;
        }

        public static void PromijeniIDPodruznice(int id) 
        {
            podruznica_ID = id;
        }

        public static string VratiUlogu()
        {
            switch (uloga_ID) 
            {
                case 1: return "Skladistar";
                case 2: return "Blagajnik";
                case 3: return "Upravitelj";
                case 4: return "Administrator";
                default: return null;
            }
        }

        public static int VratiIDPodruznice() 
        {
            return podruznica_ID;
        }

        public static string VratiImePoduzeca() 
        {
            return ime_poduzeca;
        }

        public static void Odjava() 
        {
            ID_korisnik = default;
            korisnicko_ime = default;
            podruznica_ID = default;
            uloga_ID = default;
        }

        internal static int VratiIDKorisnika()
        {
            return ID_korisnik;
        }
    }
}
