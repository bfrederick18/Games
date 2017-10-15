using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Xml.Linq;

namespace WindexedBleach
{
    class Program
    {
        static void Main(string[] args)
        {
            Dialogue DialogueType = new Dialogue();
            SpecialTyping SpecialType = new SpecialTyping();
            string username;

            string xmlFile = "C:\\Users\\Brandon\\Documents\\Github\\Games\\WindexedBleach\\WindexedBleach\\Data.xml";

            XDocument doc = new XDocument();
            doc = XDocument.Load("Data.xml");

            #region Welcomes&Stuff

            SpecialType.NextLine();
            DialogueType.NoUserDialogue("user", false);
            username = Console.ReadLine();


            DialogueType.WriteDialogue("Welcome to Windexed Bleach a.k.a *Death* (Thad 10/15)", "trust");

            #endregion
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