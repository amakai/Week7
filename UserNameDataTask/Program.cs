using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab ühte, siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib kahte, siis kuvatakse kasutaja eesnime esmiest tähte
            //kui kasutaja valib kolme, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("sisesta enda eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("vali number 1,2 või 3");
            char userNumber = Convert.ToChar(Console.ReadLine());

            

            switch (userNumber)
            {
                case '1':
                    GetUserNameData2(userName);
                    break;
                case '2':
                    GetUserNameData1(userName);
                    break;
                case '3': GetUserNameData(userName);
                    break;
                


            }


        }
        
        public static void GetUserNameData(string userInput)

        {
            Console.WriteLine($"sinu nimi on {userInput.Length} sümbolit pikk");
            
        } 
        public static void GetUserNameData1(string userInput)
        {
            Console.WriteLine($"sinu eesnime esimene täht on {userInput[0]}");

            
        }
        public static void GetUserNameData2(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
