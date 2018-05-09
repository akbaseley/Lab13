using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    class Validation
    {
        public static string GetUserName(string messsage)
        {
            Console.WriteLine(messsage);
            string UserName = Console.ReadLine();
            return UserName;
        }

        public static string UserInput(string message, string Answer1, string Answer2)
        {
            Console.WriteLine(message);
            string Response = Console.ReadLine().ToLower();

            while (Response != Answer1 && Response != Answer2)
            {
                Console.WriteLine("I didn't quite catch that. " + message);
                Response = Console.ReadLine().ToLower();
            }

            return Response;
        }

        public static Roshambo UserInput(string message, string Answer1, string Answer2, string Answer3)
        {
            Console.WriteLine(message);
            string Response = Console.ReadLine().ToLower();

            while (Response != Answer1 && Response != Answer2 && Response != Answer3)
            {
                Console.WriteLine("I didn't quite catch that. " + message);
                Response = Console.ReadLine().ToLower();
            }

            if (Response == Answer1)
            {
                return Roshambo.rock;
            }
            else if (Response == Answer2)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }
        }

    }
}
