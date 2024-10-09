using System.Text.RegularExpressions;

namespace RomanNumeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex("[^IVXLCDM.$ ]$");

            while (true) //Kontrollerar så att endast skriv in romserska siffror
            {
                Console.WriteLine("Ange ett Romerskt tal: ");
                var userInput = Console.ReadLine().ToUpper();

                if (r.IsMatch(userInput))
                    break;
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
