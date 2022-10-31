using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {

        long x = 0;
        long y = 1;
        Console.WriteLine("Wpisz ilość wyników:");
        int rep = Convert.ToInt32(Console.ReadLine());
        int n = 1;

        while (n < rep)
        {
            for (; x < y;)
            {
                n++;
                Console.WriteLine(x);
                x = x + y;
            }
            for (; x >= y;)
            {
                n++;
                Console.WriteLine(y);
                y = y + x;
            }


        }  
    }
}