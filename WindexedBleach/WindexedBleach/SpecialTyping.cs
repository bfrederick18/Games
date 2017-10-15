using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace WindexedBleach
{
    public class SpecialTyping
    {
        public int line = 0;
        public int xx = 0;
        /// <summary>
        /// Magical draw function written by abe
        /// </summary>
        /// <param name="character">symbol that you want to draw</param>
        /// <param name="x">x location of the symbol</param>
        /// <param name="y">y location of the symbol</param>
        /// <param name="height">how many lines does the symbol take</param>
        public static void Draw(char character, int x, int y, int height, Color color)
        {
            for (int i = y; i < y + height; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = i;
                Console.Write(character, color);
            }
        }

        public void NextLine()
        {
            line++;
            xx = 0;
        }
        public void NextLine(int howManyLines)
        {
            line += howManyLines;
            xx = 0;
        }

        public void ScrollType(string word, int x, int y, int typingSpeed, Color color)
        {
            Console.CursorVisible = false;

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

                Draw(charList[i], newX, newY, 1, color);
                System.Threading.Thread.Sleep(typingSpeed);
                newX++;
            }
            Draw(' ', newX + 1, newY, 1, color);
            xx += charList.Count + 1;
            Console.CursorVisible = true;
        }
        public void ScrollType(string word, int x, int y, int typingSpeed, Color color, bool FaLsE)
        {
            Console.CursorVisible = false;

            List<char> charList = word.ToList<char>();
            int newX = x;
            int newY = y;

            for (int i = 0; i < charList.Count; i++)
            {
                if (newX >= 105 && charList[i - 1] == ' ')
                {
                    newX = x;
                    newY++;
                }

                Draw(charList[i], newX, newY, 1, color);
                System.Threading.Thread.Sleep(typingSpeed);
                newX++;
            }
            xx += charList.Count;
            Console.CursorVisible = true;
        }

        public void EraseScroll(string word, int x, int y, int typingSpeed, char eraseChar, Color color)
        {
            Console.CursorVisible = false;
            List<char> charList = word.ToList<char>();
            int newX = x;
            int newY = y;

            for (int i = 0; i < charList.Count; i++)
            {
                if (newX >= 105 && charList[i - 1] == ' ')
                {
                    newX = x;
                    newY++;
                }

                if (charList[i] == ' ')

                Draw(charList[i], newX, newY, 1, color);
                
                if (newX - 1 >= 0)
                {
                    if (charList[i - 1] == ' ')
                    {
                        Draw(' ', newX -1, newY, 1, color);
                    }

                    else
                    Draw(eraseChar, newX - 1, newY, 1, color);
                }


                System.Threading.Thread.Sleep(typingSpeed);
                newX++;
                Console.CursorVisible = true;
            }
        }
    }
}
