//using System.Collections.Generic;
using Ukol4CetnostZnaku;

/* 
 * Zadání:
 * Vytvoř program, který nad zadaným textem provede statistiku znaků.
 * Tedy spočítej kolikrát se který znak v textu vyskytuje. Nejlépe využij pro tento program listu, kde typem listu bude tvůj vlastní typ obsahující samotný znak a počet jeho výskytů. (Ano, pro znalejší v podstatě vytváříš typ dictionary, o kterém se budeme bavit příště :) )
 * Pokud si budeš chtít vyhrát můžeš spočítat i kolik je bílých znaků, kolik písmen je velkých, kolik malých apod. (tedy využití funkcí typu char) 
*/

Console.WriteLine("Zadej text pro provedení statistiky: ");
string zadanyText = Console.ReadLine();

List<StatistikaZnaku> statistikaTextu = new List<StatistikaZnaku>();

StatistikaZnaku zadaneZnaky = new StatistikaZnaku();
int pocet = 0;

foreach (char znak in zadanyText)
{
    pocet = 0;
    for(int i=0; i<zadanyText.Length;i++)
    {
        if (znak == zadanyText[i])
        {
            pocet = pocet + 1;
        }
        //Console.WriteLine(znak + "-" + zadanyText[i] + "-" + pocet);

    }
    //Console.WriteLine("Konec cyklu");
    zadaneZnaky.Znak = znak;
    zadaneZnaky.PocetVyskytu = pocet;
    //Console.WriteLine(zadaneZnaky.Znak+"-"+zadaneZnaky.PocetVyskytu);
    if (!statistikaTextu.Contains(zadaneZnaky))
    {
    statistikaTextu.Add(zadaneZnaky);
    //Console.WriteLine("ULOŽENO");
    }

}

foreach (StatistikaZnaku item in statistikaTextu)
{
    Console.WriteLine(item.Znak+" - "+item.PocetVyskytu);
}
