//using System.Collections.Generic;
using System.Collections.Generic;
using Ukol4CetnostZnaku;
using static System.Net.Mime.MediaTypeNames;

/* 
 * Zadání:
 * Vytvoř program, který nad zadaným textem provede statistiku znaků.
 * Tedy spočítej kolikrát se který znak v textu vyskytuje. Nejlépe využij pro tento program listu, kde typem listu bude tvůj vlastní typ obsahující samotný znak a počet jeho výskytů. (Ano, pro znalejší v podstatě vytváříš typ dictionary, o kterém se budeme bavit příště :) )
 * Pokud si budeš chtít vyhrát můžeš spočítat i kolik je bílých znaků, kolik písmen je velkých, kolik malých apod. (tedy využití funkcí typu char) 
*/

Console.WriteLine("Zadej text pro provedení statistiky: ");
string zadanyText = Console.ReadLine();

var statistikaTextu = new List<StatistikaZnaku>();
bool nutnoPridat = true;

foreach (var znak in zadanyText)
{ 
    if (statistikaTextu.Any()) 
    {
        nutnoPridat = true;
        for (int i = 0; i < statistikaTextu.Count; i++)
        { 
            if (statistikaTextu[i].Znak == znak)
            {
                statistikaTextu[i].PocetVyskytu++;
                nutnoPridat = false;

            } 
        } 
        if(nutnoPridat)
        {
            statistikaTextu.Add(new StatistikaZnaku() { Znak = znak, PocetVyskytu = 1 });
        }
    } 
    else 
    {
        statistikaTextu.Add(new StatistikaZnaku() { Znak = znak, PocetVyskytu=1 }); 
    }

}   
foreach (StatistikaZnaku item in statistikaTextu)
{
    Console.WriteLine(item.Znak+" - "+item.PocetVyskytu);
}
