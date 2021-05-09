using NawDomein;
using System;

namespace NawUI
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine("button : start actie nawgegevens opslaan");

            Persoon pers = new Persoon(voornaam: string.Empty, achternaam:"", emailadress: "");

            pers.ChangeNaw(voornaam: string.Empty, achternaam: "", emailadress: "");


            Console.WriteLine("button: einde actie nawgegevens opslaan");
        }
    }
}
