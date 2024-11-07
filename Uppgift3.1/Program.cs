using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int Ålder = int.Parse(Console.ReadLine());

            if (Ålder == 16)
            {
                Console.WriteLine("Du är tillräckligt gammal för att vara med");
            }
            else if (Ålder == 17)
            {
                Console.WriteLine("Du är tillräckligt gammal för att vara med");
            }
            else if (Ålder == 18)
            {
                Console.WriteLine("Du är tillräckligt gammal för att vara med");
            }
            else if (Ålder == 19)
            {
                Console.WriteLine("Du är tillräckligt gammal för att vara med");
            }
            else if (Ålder < 16)
            {
                Console.WriteLine("Du är inte tillräckligt gammal nog för att vara med");
            }
            else if (Ålder > 19)
            {
                Console.WriteLine("Du är för gammal för att vara med");
            }

            Console.ReadKey();

        }
    }
}