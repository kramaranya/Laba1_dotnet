using Laba1_dotnet;
using System;

class Program
{
    static void Main(string[] args)
    {
        int choose;
        bool isSuccessful;
        do
        {
            Console.WriteLine("\nChoose: \n1 - Print collections \n2 - Print Queries \n3 - Exit");
            isSuccessful = int.TryParse(Console.ReadLine(), out choose);
            switch (choose)
            {
                case 1:
                    PrintCollections.PrintAllCollections();
                    break;
                case 2:
                    PrintQueries.PrintAllQueries();
                    break;
            }
        } while (isSuccessful && choose != 3);
    }
}