using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class UI
    {
        public static void PrintUI(int width, int height)
        {
            Console.Write('╔');
            for (int c = 0; c < width; c++)
            {
                Console.Write('═');
            }
            Console.Write('╗');
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.Write('║');
                for (int j = 0; j < width; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('║');
                Console.WriteLine();
            }
            Console.Write('╚');
            for (int c = 0; c < width; c++)
            {
                Console.Write('═');
            }
            Console.Write('╝');
            Console.WriteLine();
        }
    }
}
