namespace RomanNumeral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ange ett Romerskt tal: ");
            var userInput = Console.ReadLine().ToUpper();




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



            //HEJ!


            //Ta emot sträng
            //Kontrollera max 15 tecken
            //Kontrollera att den innehåller endast I V X L C D M (Regex?)














        }
    }
}
