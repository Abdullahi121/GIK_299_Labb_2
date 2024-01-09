namespace GIK_299_Labb_2
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Eventing.Reader;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int FamilyMemberCount;
                Console.WriteLine("Ange antal familjemedlemmar");
                FamilyMemberCount = int.Parse(Console.ReadLine());
                string[] names = new string[FamilyMemberCount];
                double[] age = new double[FamilyMemberCount];
                double totalAge = 0;
                double averageAge = 0;

                int menuSelector = 0;
                int userInput = 0;

                while (menuSelector != 5)
                {
                    Console.WriteLine(
                        "\n---------------------------------------------" +
                        "\nVälj ett alternativ" +
                        "\n1.) Lägg till familjemedlem" +
                        "\n2.) Visa alla familjemedlemmar" +
                        "\n3.) Visa summan av åldrarna" +
                        "\n4.) Visa medelåldern" +
                        "\n5.) Avsluta programmet" +
                        "\n-----------------------------------------------"
                        );
                    menuSelector = int.Parse(Console.ReadLine());
                    switch (menuSelector)
                    {
                        case 1:
                            if (userInput < FamilyMemberCount)
                            {
                                Console.WriteLine("Ange namn på familjemedlemmar");
                                names[userInput] = Console.ReadLine();

                                Console.WriteLine("Ange ålder på familjemedlemmarna");
                                age[userInput] = Double.Parse(Console.ReadLine());
                                totalAge += age[userInput];
                                userInput++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Tyvärr, det är fullt");
                            }
                            break;

                        case 2:
                            for (int i = 0; i < userInput; i++)
                            {
                                Console.WriteLine(names[i] + " är " + age[i]);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Summan är " + totalAge.ToString("0.00"));
                            break;

                        case 4:
                            averageAge = totalAge / FamilyMemberCount;
                            Console.WriteLine("Medelåldern är " + averageAge.ToString("0.00"));
                            break;

                        case 5:
                            Console.WriteLine("Avsluta");
                            break;

                        default:
                            Console.WriteLine("Felaktig indata, vänligen välj ett nummer mellan 1 - 5\n");
                            break;
                    }
                }
            }
        }


    }

}