﻿using System;

namespace D14_1_1_Länder
{
    internal class Program
    {
        // 8. Skapa en klass Land för länder med attributen namn, styrestyp, huvudstad, invånarantal. Skapa ett publikt github-repo Lander för programmet.
        class Land
        {
            string namn, styrestyp, huvudstad;
            int invånarantal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
//9. Instansiera tre länder sverige och tyskland och sanMarino och deras data med:
//Sverige monarki Stockholm 10512820
//Tyskland republik Berlin 83783902
//San Marino republik San Marino 33600
//Stagea, committa och pusha!
//10. Skapa en (vanlig) publik metod Print i Land som skriver ut landet. Skriv ut sverige och
//tyskland och sanMarino! Stagea, committa och pusha!
//11. Skapa en array av 7 länder, och tilldela 0 till 2 av arrayen värdena i sverige och tyskland
//och sanMarino! Direkt-tilldela de fyra övriga indexen i arrayen värdena:
//Danmark monarki Köpenhamn 5928364
//Italien republik Rom 58853482
//Tjekien republik San Marino 10551219
//Rumänien republik Bukarest 19760314
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
