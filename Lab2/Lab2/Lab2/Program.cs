using Lab2.Part3;
using System;

namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileParserWeather.GetMinDifference(FileParserWeather.GetDailyWeathers());
            FileParserFootball.GetMinDifference(FileParserFootball.GetTeams());

            FileParser.SetFilePath("D:/facultate 2/SEM5C/Lab2/Lab2/weather.dat");
            FileParser.GetMinDifference(0, 1, 2);

            FileParser.SetFilePath("D:/facultate 2/SEM5C/Lab2/Lab2/football.dat");
            FileParser.GetMinDifference(1, 6, 7);
        }
    }
}

/* Part 4:
 * 1.To what extent did the design decisions you made when writing the original 
 * programs make it easier or harder to factor out common code?
 * 
 * Intr-o mare masura ,modul de a scrie primele doua parti ne-a facut sa vedem partile comune dintre ele si sa 
 * le proiectam asemanator astfel incat , partea de scriere a codului comun a fost usor de proiectat.
 * 
 * 2.Was the way you wrote the second program influenced by writing the first?
 * 
 * Vazand asemanarile , mai exact faptul ca in esenta se cerea acelasi lucru( afisarea atributului prin care se identifica un obiect in functie de diferenta 
 * dintre doua valori corespunzatoare acestuia ) , rezolvarea primului exercitiu a influentat modul de a gandi si a-l coda pe cel 
 * de-al doilea
 * 
 * 3.Is factoring out as much common code as possible always a good thing? Did the readability of the programs suffer because of
 * this requirement? How about the maintainability?
 * 
 * Atunci cand scriem un program care contine mai mult cod , factorizarea poate fi atat un lucru bun pentru ca putem uni parti din 
 * cerinta sub acelasi cod , insa uneori poate fi greu de inteles din exterior si usor de a vedea micile exceptii care se produc si 
 * nu se potrivesc in totalitate cu codul nostru , astfel corectitudinea poate avea de suferit .
 * 
 * Referitor la acest aspect , mentenanta este o practica buna care ne poate ajuta in verificarea corectitudinii codului ,
 * dar si a intelegerii pe deplina functionalitatii acestuia.
 * 
 * 4.Ce ati invatat din acest Kata ?
 * 
 * Acest kata ne-a ajutat in sa exersam scrierea codului , dar si sa invatam aspecte importante cum ar fi utilitatea scrierii 
 * unui cod comun si observarea aspectelor comune in esenta a anumitor cerinte.
 * 
  */