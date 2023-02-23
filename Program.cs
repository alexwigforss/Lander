using System;
using System.Xml.Linq;

namespace D14_1_1_Länder
{
    internal class Program
    {
        // 8. Skapa en klass Land för länder med attributen namn, styrestyp, huvudstad, invånarantal.
        class Land
        {
            string namn, styrestyp, huvudstad;
            int invånarantal;
            public Land(string n, string s, string h, int i) { namn = n; styrestyp = s; huvudstad = h; invånarantal = i; }
            // 10. Skapa en (vanlig) publik metod Print i Land som skriver ut landet.
            public void Print()
            {
                Console.Write($"Land: {namn}\n" +
                    $"    Styre: {styrestyp}\n    " +
                    $"Hufvudstad: {huvudstad}\n    " +
                    $"Invånare: {invånarantal}\n\n");
            }
        }
        static void Main(string[] args)
        {
            //9. Instansiera tre länder sverige och tyskland och sanMarino och deras data med:
            Land sv = new Land("Sverige", "monarki", "Stockholm", 10512820);
            Land ty = new Land("Tyskland", "republik", "Berlin", 83783902);
            Land sm = new Land("San Marino", "republik", "San Marino", 33600);

            // 10_b Skriv ut sverige, tyskland och sanMarino! Stagea, committa och pusha!
            sv.Print();
            ty.Print();
            sm.Print();

            //11. Skapa en array av 7 länder, och tilldela 0 till 2 av arrayen värdena i sverige och tyskland
            Land[] countries = new Land[7];
            countries[0] = sv;
            countries[1] = ty;
            countries[2] = sm;
            countries[3] = new Land("Danmark", "monarki", "Köpenhamn", 5928364);
            countries[4] = new Land("Italien", "republik", "Rom", 58853482);
            countries[5] = new Land("Tjekien", "republik", "Prag", 10551219);
            countries[6] = new Land("Rumänien", "republik", "Bukarest", 19760314);
        }
    }
}

//Stagea, committa och pusha!
//12. Skapa en foreach-loop som går igenom alla element i arrayen och skriver ut länderna en
//efter en. Stagea, committa och pusha!
//13. Skapa en for-loop som listar alla republiker (d.v.s. skriver ut endast namnet på dem).
//Stagea, committa och pusha!
//14. Ändra loopen så att den även listar indexet. Stagea, committa och pusha!
//15. Gör en for-loop som letar reda på republiken med minsta och största invånarantal och
//skriver ut endast dessa, med en utskrift likt:

/*==== Republik med minsta invånarantal ====
Land: San Marino
 styrestyp: republik
 huvudstad: San Marino
 invånarantal: 33600
==== Republik med största invånarantal ====
Land: Tyskland
 styrestyp: republik
 huvudstad: Berlin
 invånarantal: 83783902*/

//Stagea, committa och pusha!
//Nu bör du ha 8 commits till github.
