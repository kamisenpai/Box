using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxSmile
{
    class Program
    {
        static void Main(string[] args)
        {
            int alege;
            Console.Write(" 1. Patrat\n 2. PatratX\n 3. Smiley\n Alege o varianta: ");
            try
            {
                alege = int.Parse(Console.ReadLine());
                switch (alege)
                {
                    case 1:
                        patrat();
                        break;
                    case 2:
                        patratX();
                        break;
                    case 3:
                        smiley();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Eroare prinsa: \n {0}", e);
            }
        }

        public static void patrat()
        {
            int dp;
            Console.Write("Dimensiune pătrat: ");
            dp = int.Parse(Console.ReadLine());

            for (int i = 0; i < dp; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < dp; j++)
                {
                    //spatiul gol
                    if (i > 0 && j > 0 && i < dp - 1 && j < dp - 1)
                        Console.Write("  ");
                    //margini
                    if ((i == 0 || j == 0) && i != j)
                        Console.Write("# ");
                    if ((i == dp - 1 || j == dp - 1) && i != j)
                        Console.Write("# ");

                }
            }
            Console.WriteLine();
        }

        public static void patratX()
        {
            int dp;
            Console.Write("Dimensiune pătrat: ");
            dp = int.Parse(Console.ReadLine());

            for (int i = 0; i < dp; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < dp; j++)
                {
                    //diagonale
                    if ((i == j && i != 0 && j != 0 && i != dp - 1 && j != dp - 1) || (i + j == dp - 1 && i != dp - 1 && j != dp - 1))
                        Console.Write("# ");
                    //spatiul gol
                    if (i > 0 && j > 0 && i < dp - 1 && j < dp - 1 && i != j && i + j != dp - 1)
                        Console.Write("  ");
                    //margini
                    if ((i == 0 || j == 0) && i != j)
                        Console.Write("# ");
                    if ((i == dp - 1 || j == dp - 1) && i != j)
                        Console.Write("# ");
                }
            }
            Console.WriteLine();
        }

        public static void smiley()
        {
            int dp;
            Console.Write("Alege o dimensiune mai mare sau egala decat 6\nDimensiune pătrat: ");
            dp = int.Parse(Console.ReadLine());
            while (dp < 6)
            {
                Console.Write("Alege din nou: ");
                dp = int.Parse(Console.ReadLine());
            }

            //se adapteaza in functie de dimensiunea patratului din 10 in 10
            for (int i = 0; i < dp; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < dp; j++)
                {
                    //spatiul gol + smiley
                    if ((i > 0 && j > 0 && i < dp - 1 && j < dp - 1))
                    {
                        //ochii                      
                        if ((((i == 1 && j == 1) || (i == 1 && j == dp - 2)) && dp < 10) ||
                            //daca dimensiunea patratului e mai  mare sau egala cu 10 
                            (dp >= 10 &&
                            //ochiul stang
                            (i >= dp / 10 && i <= (dp / 10) * 2 && j >= dp / 10 && j <= (dp / 10) * 2) ||
                            //ochiul drept
                            (i >= dp / 10 && i <= (dp / 10) * 2 && j <= dp - 1 - dp / 10 && j >= dp - 1 - (dp / 10) * 2)))
                            Console.Write("# ");
                        //gura
                        else
                        //linia gurii
                        if ((i == dp - 2 && j >= 2 && j <= dp - 2 - 1 && dp < 10) || (dp >= 10 && (i == dp - ((dp / 10) + 2) && j >= ((dp / 10) + 2) && j <= dp - ((dp / 10) + 2) - 1)))
                            Console.Write("# ");
                        //maginea gurii
                        else if ((((i == dp - 3 && j == 1) || (i == dp - 3 && j == dp - 2)) && dp < 10) || (dp >= 10 && ((i == dp - ((dp / 10) + 4) && j == ((dp / 10))) || (i == dp - ((dp / 10) + 4) && j == dp - ((dp / 10) + 1)) || (i == dp - ((dp / 10) + 3) && j == ((dp / 10) + 1)) || (i == dp - ((dp / 10) + 3) && j == dp - ((dp / 10) + 2)))))
                            Console.Write("# ");
                        //spatiul gol
                        else
                            Console.Write("  ");
                    }
                    //margini patrat
                    if ((i == 0 || j == 0) && i != j)
                        Console.Write("# ");
                    if ((i == dp - 1 || j == dp - 1) && i != j)
                        Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
}
