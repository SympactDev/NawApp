using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawDomein
{
    public class Persoon
    {
        public string Voornaam { get; private set; }
        public string Achternaam { get; private set; }
        public string EmailAdress { get; private set; }
        public Adres Adress;

        public Persoon(string voornaam, string achternaam, string emailadress)
        {
            MijnInterneMethod(voornaam, achternaam, emailadress);
        }

        public void ChangeNaw(string voornaam, string achternaam, string emailadress)
        {
            MijnInterneMethod(voornaam, achternaam, emailadress);
        }

        private void MijnInterneMethod(string voornaam, string achternaam, string emailadress)
        {
            if (string.IsNullOrEmpty(voornaam)) throw new ArgumentException("voornaam kan niet null zijn! piemel!");
            if (string.IsNullOrEmpty(achternaam)) throw new ArgumentException("achternaam kan niet null zijn! piemel!");
            if (string.IsNullOrEmpty(emailadress)) throw new ArgumentException("emailadress kan niet null zijn! piemel!");

            Voornaam = voornaam;
            Achternaam = achternaam;
            EmailAdress = emailadress;
        }
    }
}
