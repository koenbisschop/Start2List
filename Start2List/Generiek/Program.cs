using System;
using System.Collections.Generic;

namespace Generiek
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.declaratie
            List<string> namenRij;
            //2.constructie (maken - Bob de Bouwer)
            namenRij = new List<string>();
            //3.gebruiken: voeg een naam toe
            namenRij.Add("Jan");
            namenRij.Add("Piet");
            namenRij.Add("Ann");
            namenRij.Add("Joris");
            namenRij.Add("Korneel");
            //3b. gebruiken, of: een naam verwijderen
            //namenRij.RemoveAt(1);
            string p = namenRij[1]; //Piet
            namenRij.Remove(p);
            //print alle namen in namenRij
            Console.WriteLine("Afdrukken van de namen met for int i");
            for (int i=0; i< namenRij.Count; i++)
            {
                Console.WriteLine(namenRij[i]);
            }
            //toon wie verwijderd is:
            Console.WriteLine("Deze naam is afgezonderd:");
            Console.WriteLine(p);
            Console.ReadLine();
            //nog enkele mogelijkheden...
            //namenRij.RemoveAt(1);
            if (namenRij.Contains("Piet"))
            {
                Console.WriteLine("Piet is nog steeds in de namenRij");
            }
            else
                Console.WriteLine("Piet is not in the house");
            namenRij.Sort();
            //print alle namen op slimme manier
            Console.WriteLine("Of.... handiger met foreach");
            foreach (string naam in namenRij)
            {
                Console.WriteLine(naam);
            }
            Console.ReadLine();
            Console.WriteLine("We maken er een array van!");
            string[] namen = namenRij.ToArray();
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
            Console.WriteLine();
            //4. maak van een array een list<string>
            List<string> namenRij2 = new List<string>(namen);

        }
    }
}
