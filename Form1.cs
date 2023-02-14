//Import
using System.Diagnostics;

namespace SimpleKeyDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //IDM Default Key
            String ss = @"HKEY_USERS\S-1-5-21-1916947559-3214827233-3418797966-1001_Classes\WOW6432Node\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7} /f";
            Process cmd = new Process();
            cmd.StartInfo.FileName = @"C:\WINDOWS\system32\CMD.exe";
            cmd.StartInfo.Arguments = @"/C reg delete " + ss;  // <-- This will execute the command and wait to close

            //Start Execution
            cmd.Start();
            cmd.WaitForExit();

            //Show Key
            successForm suc = new successForm();
            suc.ShowDialog();

            //Full Exit
            Environment.Exit(0);
        }
    }
}