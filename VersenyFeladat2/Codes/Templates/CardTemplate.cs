using System.Drawing;
using System.Windows.Forms;

namespace VersenyFeladat2.Codes.Templates
{
    public class CardTemplate : Button
    {
        public CardTemplate()
        {
            Text = "Card Template";

            Size = new Size(500, 30);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            BackColor = Color.CornflowerBlue;
            ForeColor = Color.White;

            FontFamily fontFamily = new FontFamily("Impact");
            Font font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Font = font;
        }
    }
}
