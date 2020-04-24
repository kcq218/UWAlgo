using System;
using System.Text;

namespace UWAlgorithms
{

    /**
     * Notes:
     * 3 hours of lecture.
    base 10
    two digits how many number can you produce
    100
    with 3 its 1000

    in base 2 you only have 2 numbers
    0 and 1 
    2 x 2 = 4
    32 bit = 2 ^ 32
    maximum value = 2^32 - 1
    hexadecimal is base 16
    F = 15
    when shifitng left in in base 2 number is multiplied by 2
    shifting left in base 10 is multiplied by 10. 

    multiplication = shift by left
    division = shift by right

    1000 bytes = 1 kb
    1000 kb = 1 mb 
    1000 mb = 1 gb 10^9
    1000 gb = tb 10^12


    when you new up an instance you use heap 
    and when you use primitive you use stack

    heap cause fragmentation in memory(restaurants guest come and go, takes up space and free up space)
    stack memory is contigous(whoever comes in last will leave first) no fragmentation. 
     * 
     * **/
    class NumberConversion
    {
        static void Main(string[] args)
        {

            printBase10(1000000000);
        }


        public static void factorial()
        { 
        
        }
        //30
        public static void PrintBase2(int n)
        {
            var printed = 0;
            int index = 1;
            while (index < n)
            {
                Console.WriteLine(index);
                index = index * 2;
                printed++;
            }
            Console.WriteLine(printed);
            Console.ReadLine();
        }

        //9
        public static void printBase10(int n)
        {
            var printed = 0;
            int index = 1;
            while (index < n)
            {
                Console.WriteLine(index);
                index = index * 10;
                printed++;
            }
            Console.WriteLine(printed);
            Console.ReadLine();
        }

        // Assumes number >= 0 and base > 0; Does no validation of input
        public static string Convert(int number, int baseValue)
        {
            // Lets not worry about bases > 16, or any negative numbers.
            if ((number < 0) || (baseValue < 0) || (baseValue > 16))
                return "";

            int numBits = sizeof(int) * 8;
            StringBuilder bitString = new StringBuilder(numBits); // optional to pass in capacity.. just being efficient to prevent reallocations
            for (int ii = 0; ii < numBits; ++ii)
            {
                bitString.Append("0");
            }
            int index = 0;
            while (number > 0)
            {
                int lsb = number % baseValue;  // lsb will have values from 0 to (baseValue - 1)

                bitString[numBits - index - 1] = GetChar((uint)lsb);

                number /= baseValue;   // number = number / baseValue;

                ++index;
            }

            return bitString.ToString();
        }

        private static char GetChar(uint number)
        {
            char ch = '0';
            if (number <= 9)
                ch = (char)(((int)'0') + number);
            else
                ch = (char)(((int)'A') + (number - 10));

            return ch;
        }

        // Assumes number >= 0. Does no validation of input
        public static string ConvertToBinary(uint number)
        {
            int numBits = sizeof(uint) * 8;
            StringBuilder bitString = new StringBuilder(numBits); // optional to pass in capacity.. just being efficient to prevent reallocations
            for (uint ii = 0; ii < numBits; ++ii)
            {
                bitString.Append("0");
            }
            for (int ii = 0; ii < numBits; ++ii)
            {
                uint lsb = ((number >> ii) & 0x1);
                if (lsb == 0)
                    bitString[numBits - ii - 1] = '0';
                else
                    bitString[numBits - ii - 1] = '1';

                /**
                 * Or could say:  bitString[numBits - ii - 1] = (lsb == 0) ? "0" : "1");
                 * or bitString[numBits - ii - 1] = (((number >> ii) & 0x1) == 0 ? "0" : "1");   Not preferable, as harder to understand
                 * */
            }

            return bitString.ToString();
        }
    }
}
