﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindexedBleach
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecialTyping SpecialType = new SpecialTyping();

            #region Welcome
            SpecialType.ScrollType("@@@", 0, SpecialType.line, 50);


            Console.ReadKey();
        }

        /// <summary>
        /// Magical draw function written by abe
        /// </summary>
        /// <param name="character">symbol that you want to draw</param>
        /// <param name="x">x location of the symbol</param>
        /// <param name="y">y location of the symbol</param>
        /// <param name="height">how many lines does the symbol take</param>
        public static void Draw(char character, int x, int y, int height)
        {
            for (int i = y; i < y + height; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = i;
                Console.Write(character);
            }
        }
    }
}
