using System;

/*
 Nel progetto csharp-geometria creare le seguenti classi
1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. 
Aggiungere un opportuno costruttore con parametri. Aggiungere due metodi: calcolaArea 
e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, 
i valori di base e di altezza con cui istanziare un nuovo Rettangolo. 
Dopo averlo istanziato, stampate a video il perimetro e l’area.
3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) 
e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo 
ad esempio cosi:

—— Rettangolo1 —— 
base: 20 cm 
altezza: 10 cm 
Perimetro: 60 cm 
Area: 200 cm2

BONUS 
Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, 
ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/

namespace csharp_geometria 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRect, altezzaRect;
            LeggiNumeri.ReadNum("Inserisci base di un rettangolo:", out baseRect);
            LeggiNumeri.ReadNum("Inserisci altezza di un rettangolo:", out altezzaRect);

            Rettangolo r1 = new Rettangolo(baseRect, altezzaRect);

            Console.WriteLine("Area: {0}", r1.CalcolaArea());
            Console.WriteLine("Perimetro: {0}", r1.CalcolaPerimetro());

            Rettangolo r2 = new Rettangolo(10, 20, "Rett 1");
            Rettangolo r3 = new Rettangolo(110, 320, "Rett 2");
            Rettangolo r4 = new Rettangolo(210, 540, "Rett 3");

            r2.StampaRettangolo();
            r3.StampaRettangolo();
            r4.StampaRettangolo();

            r2.Disegna();
            r3.Disegna();
            r4.Disegna();
        }  
    }
}
