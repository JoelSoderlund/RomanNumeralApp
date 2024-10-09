using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace RomanNumeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            var userInput = "";

            while (!isValidInput) //Kontrollerar så att endast skriv in romserska siffror
            {
                Console.Clear();
                Console.WriteLine("Ange ett Romerskt tal: ");
                userInput = Console.ReadLine().ToUpper();

                char[] checkInput = userInput.ToCharArray();

                foreach (char c in checkInput)
                {
                    if (userInput.Length <= 15 && c == 'I' || c == 'V' || c == 'X' || c == 'L' || c == 'C' || c == 'D' || c == 'M')
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        isValidInput = false;
                        Console.WriteLine("Felaktig användarinmatning! Försök igen LOOOOOSEEEEERRRRR");
                        Thread.Sleep(1500);
                        break;
                    }
                }
            }

            var romanNums = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (i + 1 < userInput.Length && romanNums[userInput[i]] < romanNums[userInput[i +1]])
                    result -= romanNums[userInput[i]];
                else
                    result += romanNums[userInput[i]];
            }
            Console.WriteLine($"Talet är {result}");
                 






            //Kontrollera max 15 tecken















        }
    }
}
