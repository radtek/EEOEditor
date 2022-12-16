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

        Font fnt = new Font(bdata.fontz().Families[1], 12, FontStyle.Regular, GraphicsUnit.Pixel);

        public Label()
        {
            InitializeComponent();
            this.BackColor = MainForm.themecolors.background;
           
            foreach (Control cntr in this.Controls)
            {
                if (cntr.GetType() == typeof(Button))
                {
                    ((Button)cntr).ForeColor = MainForm.themecolors.foreground;
                    ((Button)cntr).BackColor = MainForm.themecolors.accent;
                    ((Button)cntr).FlatStyle = FlatStyle.Flat;
                }
                if (cntr.GetType() == typeof(TextBox))
                {
                    ((TextBox)cntr).ForeColor = MainForm.themecolors.foreground;
                    ((TextBox)cntr).BackColor = MainForm.themecolors.accent;
                }
                if (cntr.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)cntr).ForeColor = MainForm.themecolors.foreground;
                    ((NumericUpDown)cntr).BackColor = MainForm.themecolors.accent;
                }
            }
        }

        private void Label_Load(object sender, EventArgs e)
        {
            if (labelWrap >= 4 && labelWrap <= 200)
            {
            }
            else
            {
                labelWrap = 200;
            }
            nupdWrap.Value = labelWrap;
            txtbText.Text = labelText;
            this.txtbText.Select(txtbText.Text.Length, txtbText.Text.Length - 1);
            UpdateText(labelText, labelWrap, labelColor);
            
        }

        private void UpdateText(string text, int wrap, string color = "#FFFFFF")
        {
            var size = TextRenderer.MeasureText(text, fnt, new Size(wrap, 12));
            RectangleF rectf1 = new RectangleF(0, 0, wrap, size.Height * 7 - 7);
            Bitmap bmp = new Bitmap(labelWrap, size.Height * 7 - 7);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                
                gr.Clear(GetContrastColor(ColorTranslator.FromHtml(color)));
                gr.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                gr.DrawString(text, fnt, new SolidBrush(ColorTranslator.FromHtml(color)), rectf1);
            }
            pictureBox1.Image = bmp;
            pictureBox1.Width = wrap;
            labelText = text;
            labelWrap = wrap;
            labelColor = color;

        }

        private void Label_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtbText_TextChanged(object sender, EventArgs e)
        {
            labelText = txtbText.Text;
            UpdateText(labelText, labelWrap, labelColor);
        }

        private void nupdWrap_ValueChanged(object sender, EventArgs e)
        {
            labelWrap = Convert.ToInt32(nupdWrap.Value);
            UpdateText(labelText, labelWrap, labelColor);
        }

        private Color GetContrastColor(Color color)
        {
            return (color.R * 0.299M) + (color.G * 0.587M) + (color.B * 0.114M) > 149 ?
                Color.FromArgb(100, 100, 100) :
                Color.White;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                labelColor = ColorTranslator.ToHtml(cd.Color);
                UpdateText(labelText, labelWrap, labelColor);
            }
        }
    }
}
