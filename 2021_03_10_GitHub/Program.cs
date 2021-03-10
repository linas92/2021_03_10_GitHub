using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021_03_10_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadIntNumber();
        }
        static void ReadIntNumber()
        {
            Console.WriteLine("Type in a whole number");
            string SveikasSkaicius = string.Empty;
            bool ArSkaiciusTinkamas = false;

            while (!ArSkaiciusTinkamas)
            {
                SveikasSkaicius = Console.ReadLine();
                ArSkaiciusTinkamas = int.TryParse(SveikasSkaicius, out _);

                if (!ArSkaiciusTinkamas) Console.WriteLine("The number is wrong so try again buddy!");
            }
            Console.WriteLine($"Wtf, how did you do that !? HACKER! REPORT TO POLICE! = {SveikasSkaicius}");





            Console.WriteLine("---END OF THE LINE BUDDY---");
            Console.ReadKey();
        }
        static void SentenceAnalysis()
        {
            Console.WriteLine("Banana!");
        }
    }
}



/*Sukurti metodą ReadIntNumber, 
            kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina. 
           Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
           įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
           neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
           (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.



 Sukurti metodą SentenceAnalysis 
            Paduodama simbolių eilutė (sakinys). 
Metodas išanalizuoja, kiek ir kokių simbolių yra sakinyje.
            - Visa analizės informacija turi būti išsaugota žodyne(simbolis, pasikartojimai).
            - Tarpų neskaičiuoti ir į žodyną nedėti.
            1 Atspausdinti gautus rezultatus.
            2 Atspausdinti dažniausiai pasikartojantį simbolį.
              Jeigu yra keletas simbolių tiek pat pasikartojančių, atspausdinti juos visus.
            3 Atspausdinti rečiausiai pasikartojantį simbolį.
              Jeigu yra keletas simbolių tiek pat pasikartojančių, atspausdinti juos visus.

 keletas if, keletas list ir dictionary
keleta metodu
*/