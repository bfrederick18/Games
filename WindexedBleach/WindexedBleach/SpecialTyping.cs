using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindexedBleach
{
    public class SpecialTyping
    {
        public int line = 0;
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

        public void ScrollType(string word, int x, int y, int typingSpeed)
        {
            List<char> charList = word.ToList<char>();
            int newX = x;
            int newY = y;

            for (int i = 0; i < charList.Count; i++)
            {
                if (newX >= 105 && charList[i-1] == ' ')
                {
                    newX = x;
                    newY++;
                }

                Draw(charList[i], newX, newY, 1);
                System.Threading.Thread.Sleep(typingSpeed);
                newX++;
            }
            line++;
        }


    }
}
