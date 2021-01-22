using System;

namespace TP3_LeJeuDuPlusOuDuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour " + System.Environment.UserName + ", voulez vous jouer ? O/N ...");
            ConsoleKeyInfo choice = Console.ReadKey(true);

            if (choice.Key == ConsoleKey.O)
            {
                Console.WriteLine("Saisissez une valeur comprise entre 0 et 100 pour commencer.");

                int valeurATrouver = new Random().Next(0, 100);
                int i = 0 + 1;
                bool repValid = false;
                while (!repValid)
                {
                    string saisie = Console.ReadLine();
                    int rep = -1;
                    int.TryParse(saisie, out rep);
                    if (rep < valeurATrouver)
                    {
                        Console.WriteLine("C'est plus.");
                    }
                    else if (rep > valeurATrouver)
                    {
                        Console.WriteLine("C'est moins.");
                    }
                    else if (i <= 5)
                    {
                        Console.WriteLine("Woha la bête, solution trouvée en " + i + " coups.\nC'est impressionnant !");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Félicitations, vous avez trouvez la solution en " + i + " coups ! ");
                        break;
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Très bien utilisateur, passez votre chemin");
            }
        }
    }
}



