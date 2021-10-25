﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using SharpCompress.Archives;
using SharpCompress.Readers;
using System.Diagnostics;
namespace EEditor
{
    public partial class About : Form
    {
        MainForm Frm1;
        public About(MainForm F)
        {
            InitializeComponent();
            this.Text = "About EEOditor " + this.ProductVersion;
            Frm1 = F;
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.ForeColor = MainForm.themecolors.foreground;
            this.BackColor = MainForm.themecolors.background;
            for (int i = 0;i < this.Controls.Count;i++)
            {
                if (this.Controls[i].GetType() == typeof(GroupBox))
                {
                    this.Controls[i].ForeColor = MainForm.themecolors.foreground;
                    for (int a = 0;a < this.Controls[i].Controls.Count;a++)
                    {
                        if (this.Controls[i].Controls[a].GetType() == typeof(Label))
                        {
                            this.Controls[i].Controls[a].ForeColor = MainForm.themecolors.foreground;
                            this.Controls[i].Controls[a].BackColor = MainForm.themecolors.background;
                        }
                        if (this.Controls[i].Controls[a].GetType() == typeof(LinkLabel))
                        {
                            ((LinkLabel)this.Controls[i].Controls[a]).ForeColor = MainForm.themecolors.foreground;
                            ((LinkLabel)this.Controls[i].Controls[a]).BackColor = MainForm.themecolors.background;
                            ((LinkLabel)this.Controls[i].Controls[a]).LinkColor = MainForm.themecolors.link;
                            ((LinkLabel)this.Controls[i].Controls[a]).VisitedLinkColor = MainForm.themecolors.visitedlink;
                            ((LinkLabel)this.Controls[i].Controls[a]).ActiveLinkColor = MainForm.themecolors.activelink;
                            


                        }
                        if (this.Controls[i].Controls[a].GetType() == typeof(Button))
                        {
                            ((Button)this.Controls[i].Controls[a]).ForeColor = MainForm.themecolors.foreground;
                            ((Button)this.Controls[i].Controls[a]).BackColor = MainForm.themecolors.accent;
                            ((Button)this.Controls[i].Controls[a]).FlatStyle = FlatStyle.Flat;
                        }
                    }
                }
                //if (this.Controls[i].name)
            }
    }

        #region Main links
        private void Button_Click(object sender, EventArgs e)
        {
            string link1 = null;
            switch (((Button)sender).Name.ToString())
            {
                case "ForumButton":
                        link1 = "https://forums.everybodyedits.com/viewtopic.php?id=47253";
                    break;
                case "BugsOrFeatureButton":
                        link1 = "https://github.com/capasha/EEOEditor/issues";
                    break;
                case "CreditButton":
                        link1 = "https://github.com/capasha/EEOEditor/wiki/Credits";
                    break;
                case "WikiButton":
                        link1 = "https://github.com/capasha/EEOEditor/wiki";
                    break;
                case "HomepageButton":
                        link1 = "https://github.com/capasha/EEOEditor";
                    break;
            }
            DialogResult dgresult = MessageBox.Show($"Do you want to open {link1}\nin your webbrowser?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dgresult == DialogResult.Yes)
            {
                Process.Start(link1);
            }
        }
        #endregion

        #region Check version


        #endregion
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = null;
            switch (((LinkLabel)sender).Text)
            {
                case "font and text insertion":
                    link = "https://forums.everybodyedits.com/viewtopic.php?pid=515488#p515488";
                    break;
                case "Google":
                    link = "https://github.com/google/material-design-icons";
                    break;
                case "Material Design Icons contributors":
                    link = "https://materialdesignicons.com/";
                    break;
                case "Fatcow Icons":
                    link = "https://www.fatcow.com/free-icons";
                    break;
                case "Bresenham's Algorithm (Ellipse,Line)":
                    link = "http://members.chello.at/~easyfilter/bresenham.html";
                    break;
                case "Json.NET Newtonsoft":
                    link = "https://www.newtonsoft.com/json";
                    break;
                case "PlayerIO SDK":
                    link = "https://playerio.com/download/";
                    break;
                case "SharpCompress - ZIP tool":
                    link = "https://github.com/adamhathcock/sharpcompress";
                    break;
                case "Lukem's .eelvl parser":
                    link = "https://gitlab.com/LukeM212/EELVL/tree/legacy";
                    break;
            }
            DialogResult dr = MessageBox.Show($"Do you want to open {link}\nin your webbrowser?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Process.Start(link);
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            var file = $"{Directory.GetCurrentDirectory()}\\EEOditorUpdater.exe";
            if (File.Exists(file))
            {
                Process.Start(file);
            }
        }

        private void linkLabel_MouseHover(object sender, EventArgs e)
        {
            ((LinkLabel)sender).LinkColor = MainForm.themecolors.activelink;
        }

        private void linkLabel_MouseLeave(object sender, EventArgs e)
        {
            ((LinkLabel)sender).LinkColor = MainForm.themecolors.link;
        }
    }
}
