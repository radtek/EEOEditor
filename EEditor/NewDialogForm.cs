using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlayerIOClient;
using System.Threading;

namespace EEditor
{
    public partial class NewDialogForm : Form
    {
        public int SizeWidth { get; private set; }
        public int SizeHeight { get; private set; }
        public Frame MapFrame { get; private set; }
        public bool RealTime { get; }
        public bool notsaved { get; set; }
        public MainForm MainForm { get; set; }
        public MainForm mainform { get; set; }
        private Dictionary<string, string> data = new Dictionary<string, string>();
        private Semaphore s = new Semaphore(0, 1);
        private Semaphore s1 = new Semaphore(0, 1);
        //private bool errors = false;
        public NewDialogForm(MainForm mainForm)
        {
            InitializeComponent();
            //levelPassTextBox.Text = EEditor.Properties.Settings.Default.LevelPass;
            MainForm = mainForm;
            mainform = mainForm;
            CheckForIllegalCrossThreadCalls = false;
            notsaved = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int calc = Convert.ToInt32(nUWidth.Value) * 16 + Convert.ToInt32(nUHeight.Value) * 16;
            if (calc > Math.Round(Math.Sqrt(2147483648 / 16)))
            {
                MessageBox.Show("Can't load this world. It's too big.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                MainForm.SetPenTool();
                if (Clipboard.ContainsData("EEBrush")) Clipboard.Clear();
                MainForm.userdata.thisColor = Color.Transparent;
                MainForm.userdata.useColor = false;
                ToolPen.undolist.Clear();
                ToolPen.redolist.Clear();
                ToolPen.rotation.Clear();
                //Clipboard.Clear();
                MainForm.tsc.Items.Clear();
                MainForm.tsc.Items.Add("Background");
                MainForm.tsc.Text = "Background";
                var title = tbtitle.Text;
                var name = tbowner.Text;
                if (string.IsNullOrEmpty(title)) title = "Untitled World";
                if (string.IsNullOrEmpty(name)) name = "Player";
                MainForm.Text = $"({title}) [{name}] ({nUWidth.Value}x{nUHeight.Value}) EEOditor { MainForm.ProductVersion}";
                #region Listbox selection
                SizeWidth = Convert.ToInt32(nUWidth.Value);
                SizeHeight = Convert.ToInt32(nUHeight.Value);
                MainForm.EEONickname = name;
                MainForm.EEOTitle = title;
                #endregion
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dg = new ColorDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                MainForm.userdata.useColor = true;
                MainForm.userdata.thisColor = dg.Color;
            }
            else
            {
                MainForm.userdata.useColor = false;
                MainForm.userdata.thisColor = Color.Transparent;
            }
            Graphics g = Graphics.FromImage(MainForm.editArea.Back);
            for (int y = 0; y < MainForm.editArea.Frames[0].Height; y++)
            {
                for (int x = 0; x < MainForm.editArea.Frames[0].Width; x++)
                {
                    if (x == 0 || y == 0 || x == MainForm.editArea.Frames[0].Width - 1 || y == MainForm.editArea.Frames[0].Height - 1)
                    {
                        MainForm.editArea.Draw(x, y, g, Color.Transparent);
                    }
                    else
                    {
                        MainForm.editArea.Draw(x, y, g, MainForm.userdata.thisColor);
                    }
                }
            }
            MainForm.editArea.Invalidate();
            //Properties.Settings.Default.usecolor = false;
            //Properties.Settings.Default.Save();
        }


        private Color UIntToColor(uint color)
        {
            byte a = (byte)(color >> 24);
            byte r = (byte)(color >> 16);
            byte g = (byte)(color >> 8);
            byte b = (byte)(color >> 0);
            return Color.FromArgb(a, r, g, b);
        }


        private void NewDialogForm_Load(object sender, EventArgs e)
        {
            this.ForeColor = MainForm.themecolors.foreground;
            this.BackColor = MainForm.themecolors.background;

            foreach (Control cntr in this.Controls)
            {
                if (cntr.GetType() == typeof(Button))
                {
                    ((Button)cntr).ForeColor = MainForm.themecolors.foreground;
                    ((Button)cntr).BackColor = MainForm.themecolors.accent;
                    ((Button)cntr).FlatStyle = FlatStyle.Flat;
                }
                if (cntr.GetType() == typeof(GroupBox))
                {
                    cntr.ForeColor = MainForm.themecolors.foreground;
                    cntr.BackColor = MainForm.themecolors.background;
                    foreach (Control cntrl in cntr.Controls)
                    {
                        if (cntrl.GetType() == typeof(Button))
                        {
                            ((Button)cntrl).ForeColor = MainForm.themecolors.foreground;
                            ((Button)cntrl).BackColor = MainForm.themecolors.accent;
                            ((Button)cntrl).FlatStyle = FlatStyle.Flat;
                        }
                        if (cntrl.GetType() == typeof(TextBox))
                        {
                            cntrl.ForeColor = MainForm.themecolors.foreground;
                            cntrl.BackColor = MainForm.themecolors.accent;
                        }
                        if (cntrl.GetType() == typeof(NumericUpDown))
                        {
                            cntrl.ForeColor = MainForm.themecolors.foreground;
                            cntrl.BackColor = MainForm.themecolors.accent;
                        }
                    }
                }
            }
        }
    }
}
