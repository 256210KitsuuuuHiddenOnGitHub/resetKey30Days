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
            picBoxButton.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //IDM Default Key
            String rgpth = txtBoxREGPATH.Text.ToString();
            String ss = rgpth + @"\WOW6432Node\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7} /f";
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

        private void txtBoxREGPATH_TextChanged(object sender, EventArgs e)
        {
            //Disable when no text
            String placehold = txtBoxREGPATH.Text.ToString().Trim();
            if (placehold == "")
            {
                picBoxButton.Enabled = false;
            }
            else
            {
                picBoxButton.Enabled = true;
            }

        }

    }
}