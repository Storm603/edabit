using System;
using System.Text;

namespace T03._Find_the_Characters_Counterpart_Char_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            char symb = char.Parse(Console.ReadLine());

            Console.WriteLine(CounterpartCharCode(symb));
        }

        private static int CounterpartCharCode(char symbol)
        {

            if (symbol >= 65 && symbol <= 90)
            {
                string lowered = symbol.ToString().ToLower();
                return char.Parse(lowered);
            }
            else if (symbol >= 97 && symbol <= 122)
            {
                string upped = symbol.ToString().ToUpper();
                return char.Parse(upped);
            }
            else if(symbol > 127)
            {
                byte[] arr = new [symbol]{}
                return Encoding.Convert(Encoding.Convert(Encoding.Unicode, symbol));
            }
            return (int)symbol;
        }
    }
}
