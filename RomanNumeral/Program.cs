using System.Text.RegularExpressions;

namespace RomanNumeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;

            while (!isValidInput) //Kontrollerar så att endast skriv in romserska siffror
            {

                Console.WriteLine("Ange ett Romerskt tal: ");
                var userInput = Console.ReadLine().ToUpper();

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





            //Kontrollera max 15 tecken















        }
    }
}
