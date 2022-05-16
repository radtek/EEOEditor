using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEditor
{
    public partial class Label : Form
    {
        public Point sz { get; set; }
        public string labelText { get; set; }
        public int labelWrap { get; set; }

        public string labelColor { get; set; }

        
        public Label()
        {
            InitializeComponent();
        }

        private void Label_Load(object sender, EventArgs e)
        {
            Font fnt = new Font(bdata.fontz().Families[1], 12, FontStyle.Regular, GraphicsUnit.Pixel);
            RectangleF rectf1 = new RectangleF(0, 0, labelWrap, labelWrap * 2);
            string text = "welcome to my awesome world for everyone that love my work this is nice";
            text = labelText;
            Bitmap bmp = new Bitmap(200, 200);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                for (int x = 0;x < labelWrap; x++)
                {
                    for (int y = 0;y < labelWrap; y++)
                    {
                        gr.DrawImage(MainForm.foregroundBMD.Clone(new Rectangle(0, 0, 16, 16), MainForm.foregroundBMD.PixelFormat), x * 16, y * 16);
                    }
                }

                gr.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                gr.DrawString(text, fnt, new SolidBrush(ColorTranslator.FromHtml(labelColor)), rectf1);
            }
            pictureBox1.Image = bmp;
            
        }

        private void Label_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
