using System; 

namespace Uppgift_6_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skri in ett tal som är större än ett för att undersöka om det är ett primtal");
            Console.WriteLine(Prim(int.Parse(Console.ReadLine())));
        }

        static bool Prim(int tal)
        {
            for (int i = 2; i < tal - 1; i++)
            {
                if (tal % i == 0) return false;
            }

            return true;
        }
    }
}