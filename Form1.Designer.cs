namespace SimpleKeyDelete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblClickMeTxt = new Label();
            picBoxButton = new PictureBox();
            txtBoxREGPATH = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxButton).BeginInit();
            SuspendLayout();
            // 
            // lblClickMeTxt
            // 
            lblClickMeTxt.AutoSize = true;
            lblClickMeTxt.Location = new Point(186, 12);
            lblClickMeTxt.Name = "lblClickMeTxt";
            lblClickMeTxt.Size = new Size(265, 20);
            lblClickMeTxt.TabIndex = 0;
            lblClickMeTxt.Text = "*click Nanaya To Dissect Reset 30 Days";
            // 
            // picBoxButton
            // 
            picBoxButton.Image = Properties.Resources.nanaya;
            picBoxButton.Location = new Point(12, 12);
            picBoxButton.Name = "picBoxButton";
            picBoxButton.Size = new Size(168, 117);
            picBoxButton.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxButton.TabIndex = 1;
            picBoxButton.TabStop = false;
            picBoxButton.Click += pictureBox1_Click;
            // 
            // txtBoxREGPATH
            // 
            txtBoxREGPATH.Location = new Point(186, 74);
            txtBoxREGPATH.Name = "txtBoxREGPATH";
            txtBoxREGPATH.Size = new Size(314, 27);
            txtBoxREGPATH.TabIndex = 2;
            txtBoxREGPATH.Text = "HKEY_USERS\\<your PC Code>1001_Classes";
            txtBoxREGPATH.TextChanged += txtBoxREGPATH_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 51);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 3;
            label1.Text = "REGPATH Input on Start: (Modify Right Path)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 144);
            Controls.Add(label1);
            Controls.Add(txtBoxREGPATH);
            Controls.Add(lblClickMeTxt);
            Controls.Add(picBoxButton);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IDM Reset ";
            ((System.ComponentModel.ISupportInitialize)picBoxButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClickMeTxt;
        private PictureBox picBoxButton;
        private TextBox txtBoxREGPATH;
        private Label label1;
    }
}