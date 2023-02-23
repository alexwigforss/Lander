using System.Diagnostics;

namespace D14_1_1_Länder
{
    internal class Program
    {
        // 8. Skapa en klass Land för länder med attributen namn, styrestyp, huvudstad, invånarantal.
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånarantal;
            public Land(string n, string s, string h, int i) { namn = n; styrestyp = s; huvudstad = h; invånarantal = i; }
            // 10. Skapa en (vanlig) publik metod Print i Land som skriver ut landet.
            public void Print()
            {
                Console.Write($"Land: {namn}\n" +
                    $"    Styre: {styrestyp}\n    " +
                    $"Hufvudstad: {huvudstad}\n    " +
                    $"Invånare: {invånarantal}\n\n");
            }
            public void PrintOnly(string what, int i = -1)
            {
                if (i >= 0)
                {
                    Console.Write($"Index: {i} ");
                }
                switch (what)
                {
                    case "Land":
                        Console.Write($"{namn} ");
                        break;
                    case "Styre":
                        Console.Write($"{styrestyp} ");
                        break;
                    case "Hufvudstad":
                        Console.Write($"{huvudstad} ");
                        break;
                    case "Invånare":
                        Console.Write($"{invånarantal} ");
                        break;
                    default:
                        Console.Write($"Ej godkänd parameter");
                        break;
                }
                if (i >= 0)
                {
                    Console.Write($"\n");
                }
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

            // 12 Skapa en foreach-loop som går igenom alla element i arrayen och skriver ut länderna en
            foreach (var item in countries)
            {
                item.Print();
            }

            // Avstickare. Ville testa Array.Foreach varianten med som någon nämnde på tidigare lektion
            // https://learn.microsoft.com/en-us/dotnet/api/system.array.foreach?view=net-7.0
            // Fick skriva en statisk metod i bas-klassen för att få detta att funka
            // Action<Land> action = new Action<Land>(Print);
            // Array.ForEach(countries, action);

            // 13 Skapa en for-loop som listar alla republiker (d.v.s. skriver ut endast namnet på dem).
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-clause

            var republics = (from l in countries where l.styrestyp == "republik" select l).ToArray();
            foreach (Land item in republics)
            {
                item.PrintOnly("Land");
            }
            Console.WriteLine("\när alla republiker.\n");
            // 14. Ändra loopen så att den även listar indexet.
            // Hoppsan... det skulle visst va en vanlig forloop ovan
            // Nåväl, gör en nu ist. Behåller ovan som exempel på filter

            for (int i = 0; i < countries.Length; i++)
            {
                if (countries[i].styrestyp == "republik")
                    countries[i].PrintOnly("Land", i);
            }
            Console.WriteLine("\när alla republiker.\n");
            
            // 15. Gör en for-loop som letar reda på republiken med minsta och största invånarantal och
            // Ok, då, jag gör väl en for-loop men filtrerar först så den blir så kort som möjligt

            Land[] minmax = MinMaxPopulation(countries);
            for (int i = 0; i < minmax.Length; i++)
            {
                string? x = i == 0 ? "==== Republik med minsta invånarantal ====" : "==== Republik med största invånarantal ====";
                minmax.ToString();
                Console.WriteLine(x);
                Print(minmax[i]);
                // Så använder jag den statiska print-metoden så jag får använda den också
            }
        }

        private static Land[] MinMaxPopulation(Land[] lands)
        {
            Land[] sorted = lands.OrderBy(l => l.invånarantal).ToArray();
            Land[] maxmin = new Land[] { sorted[0], sorted.Last() };
            return maxmin;
        }

        private static void Print(Land p)
        {
            Console.Write($"Land: {p.namn}\n" +
                $"  Styre: {p.styrestyp}\n  " +
                $"Hufvudstad: {p.huvudstad}\n  " +
                $"Invånare: {p.invånarantal}\n\n");
        }
    }
}