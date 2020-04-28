using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spielautomat");
            int zahl1, zahl2, zahl3, guthaben = 5, einsatz, gewinn, auswahl;
            Random rnd = new Random();

            do
            {
                Console.WriteLine("Das aktuelle Guthaben beträgt: " + guthaben);
                Console.WriteLine("1: Spielen");
                Console.WriteLine("2: Aufhören");
                auswahl = Convert.ToInt32( Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Einsatz festlegen:");
                            einsatz = Convert.ToInt32(Console.ReadLine());
                            if (einsatz > guthaben)
                            {
                                Console.WriteLine("Nicht genug Guthaben.");
                            }
                        } while (einsatz > guthaben);
                        guthaben -= einsatz;//guthaben = guthaben - einsatz

                        zahl1 = rnd.Next(1, 8);
                        zahl2 = rnd.Next(1, 8);
                        zahl3 = rnd.Next(1, 8);

                        Console.WriteLine(zahl1 + " " + zahl2 + " " + zahl3);
                        
                        if (zahl1==zahl2 && zahl2==zahl3)
                        {
                            gewinn = 3 * einsatz;
                            guthaben += gewinn;
                            Console.WriteLine("Hauptgewinn: " + gewinn);
                        }
                        else if (zahl1==zahl2 || zahl2==zahl3 || zahl1==zahl3)
                        {
                            gewinn = 3 + einsatz;
                            guthaben += gewinn;
                            Console.WriteLine("Gewonnen: " + gewinn);
                        }
                        else
                        {
                            Console.WriteLine("Leider kein Gewinn.");
                        }

                        if (guthaben == 0)
                        {
                            Console.WriteLine("Spiel vorbei...");
                            auswahl = 2;
                        }

                        break;

                    case 2:
                        Console.WriteLine("Der Gewinn beträgt: " + guthaben);
                        break;

                    default:
                        Console.WriteLine("Falsche Eingabe!");
                        break;
                }

            } while (auswahl!=2);
            Console.ReadKey();
        }
    }
}
