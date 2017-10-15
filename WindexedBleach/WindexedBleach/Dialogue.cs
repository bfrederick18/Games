using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace WindexedBleach
{
    public class Dialogue
    {
        SpecialTyping SpecialType = new SpecialTyping();

        List<Color> colorScheme1 = new List<Color>
        {
            Color.FromArgb(45,45,42),
            Color.FromArgb(53,56,49),
            Color.FromArgb(56,66,59),
            Color.FromArgb(63,94,90),
            Color.FromArgb(32,252,143)
        };

        List<Color> colorScheme2 = new List<Color>
        {
            Color.FromArgb(46,129,107),
            Color.FromArgb(46,131,134),
            Color.FromArgb(47,108,139),
            Color.FromArgb(47,83,143),
            Color.FromArgb(47,54,148)
        };

        public void WriteDialogue(string text, string user)
        {
            int lineNum = SpecialType.line + 1;
            SpecialType.ScrollType(lineNum.ToString(), 0, SpecialType.line, 30, colorScheme2[0]);

            if (user == "trust")
                SpecialType.ScrollType("0000", SpecialType.xx, SpecialType.line, 30, colorScheme2[1]);

            else
                SpecialType.ScrollType("1111", SpecialType.xx, SpecialType.line, 30, colorScheme2[1]);

            SpecialType.ScrollType(user, SpecialType.xx, SpecialType.line, 30, colorScheme2[2], false);

            SpecialType.ScrollType(":", SpecialType.xx, SpecialType.line, 30, colorScheme2[0]);

            SpecialType.ScrollType(text, SpecialType.xx, SpecialType.line, 30, colorScheme2[3]);

            SpecialType.NextLine();
        }
        public void WriteDialogue(string text, string user, int y, char eChar, int tSpeed)
        {
            int lineNum = SpecialType.line + 1;
            SpecialType.ScrollType(lineNum.ToString(), 0, SpecialType.line, 30, colorScheme2[0]);

            if (user == "trust")
                SpecialType.ScrollType("0000", SpecialType.xx, SpecialType.line, 30, colorScheme2[1]);

            else
                SpecialType.ScrollType("1111", SpecialType.xx, SpecialType.line, 30, colorScheme2[1]);

            SpecialType.ScrollType(user, SpecialType.xx, SpecialType.line, 30, colorScheme2[2], false);

            SpecialType.ScrollType(":", SpecialType.xx, SpecialType.line, 30, colorScheme2[0]);

            SpecialType.EraseScroll(text, SpecialType.xx, SpecialType.line, tSpeed, '#', colorScheme2[3]);

            SpecialType.NextLine();
        }

        public void NoUserDialogue(string text, bool LiNeNuM)
        {
            int lineNum = SpecialType.line + 1;
            if (LiNeNuM)
            SpecialType.ScrollType(lineNum.ToString(), 0, SpecialType.line, 30, colorScheme2[0]);
            else

            SpecialType.ScrollType(text, SpecialType.xx, SpecialType.line, 30, colorScheme2[2], false);

            SpecialType.ScrollType(":", SpecialType.xx, SpecialType.line, 30, colorScheme2[0]);

            SpecialType.NextLine();
        }
    }
}
