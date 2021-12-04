using System.Drawing;
using System.Windows.Forms;

namespace VersenyFeladat2.Codes.Templates
{
    public class ButtonTemplate : Button
    {
        public int Id { get; set; }

        public ButtonTemplate()
        {
            Text = "Verseny";
            Size = new Size(170, 30);

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
