using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice5a
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    char c = Console.ReadKey().KeyChar;
                    Console.WriteLine(Char2Code(c));
                }
            }
        }

        public static void Print_a_2_z_v1()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }
        }

        public static int Char2Code(char c)
        {
            return (int)c;
        }

        public static bool IsUpper(char c)
        {
            if (c >= 65|| c <=90)
            {
                return true;
            }
            return false;
        }

        public static bool IsLower(char c)
        {
            return false;
        }

        public static char ToUpper(char c)
        {
            return c;
        }
    }
}
