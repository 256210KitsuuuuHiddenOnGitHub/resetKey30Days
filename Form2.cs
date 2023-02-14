using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleKeyDelete
{
    public partial class successForm : Form
    {
        public successForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Visit Coder's Link
            //Visit Link
            Process lnk = new Process();
            lnk.StartInfo.UseShellExecute = true;
            lnk.StartInfo.FileName = "https://github.com/256210KitsuuuuHiddenOnGitHub";
            lnk.Start();
        }
    }
}
