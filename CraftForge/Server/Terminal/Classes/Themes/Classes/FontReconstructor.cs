using System.Drawing;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Themes.Classes
{
    internal class FontReconstructor
    {
        public static Font convertFromString(string font)
        {
            string[] fontSplit = font.Split(',');

            if (fontSplit.Length >= 2)
            {
                string fontName = fontSplit[0].Trim();
                float fontSize;
                if (float.TryParse(fontSplit[1].Trim(), out fontSize))
                {
                    FontStyle fontStyle = FontStyle.Regular;
                    for (int i = 2; i < fontSplit.Length; i++)
                    {
                        string stylePart = fontSplit[i].Trim().ToLower();
                        if (stylePart == "bold")
                        {
                            fontStyle |= FontStyle.Bold;
                        }
                        else if (stylePart == "italic")
                        {
                            fontStyle |= FontStyle.Italic;
                        }
                        else if (stylePart == "underline")
                        {
                            fontStyle |= FontStyle.Underline;
                        }
                        else if (stylePart == "strikeout")
                        {
                            fontStyle |= FontStyle.Strikeout;
                        }
                    }

                    Font returnedFont = new Font(fontName, fontSize, fontStyle);
                    return returnedFont;
                    // Use the font object as needed
                }
                else
                {
                    MessageBox.Show("Invalid font size format.");
                }
            }
            else
            {
                MessageBox.Show("Invalid font string format.");
            }
            return null;
        }
    }
}
