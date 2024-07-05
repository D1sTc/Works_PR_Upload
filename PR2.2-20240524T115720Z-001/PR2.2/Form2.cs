using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_1_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LinkMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkMail.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = "https://account.google.com", UseShellExecute = true }); // переход по ссылке
        }
    }
}
