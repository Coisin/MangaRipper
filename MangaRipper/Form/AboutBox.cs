﻿using System;
using System.Windows.Forms;

namespace MangaRipper
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Text = string.Format("About {0}", Application.ProductName);
            labelProductName.Text = Application.ProductName;
            labelVersion.Text = string.Format("Version {0}", Application.ProductVersion);
            labelCopyright.Text = Application.CompanyName;
            labelCompanyName.Text = "Copyright ©  2011";
            textBoxDescription.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NguyenDanPhuong/MangaRipper");
        }
    }
}
