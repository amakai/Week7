using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnime
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem kui kolm rida koodi

            Console.WriteLine("sisesta enda eesnimi:");
            string userName = Console.ReadLine();

            

            GetUserNameData(userName);

            


        }

        public static void GetUserNameData(string userInput)

        {
            Console.WriteLine($"sinu nimi on {userInput.Length} sümbolit pikk");
            Console.WriteLine($"sinu eesnime esimene täht on {userInput[0]}");

            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
