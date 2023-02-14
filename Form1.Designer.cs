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
            this.lblClickMeTxt = new System.Windows.Forms.Label();
            this.picBoxButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClickMeTxt
            // 
            this.lblClickMeTxt.AutoSize = true;
            this.lblClickMeTxt.Location = new System.Drawing.Point(12, 9);
            this.lblClickMeTxt.Name = "lblClickMeTxt";
            this.lblClickMeTxt.Size = new System.Drawing.Size(265, 20);
            this.lblClickMeTxt.TabIndex = 0;
            this.lblClickMeTxt.Text = "*click Nanaya To Dissect Reset 30 Days";
            // 
            // picBoxButton
            // 
            this.picBoxButton.Image = global::SimpleKeyDelete.Properties.Resources.nanaya;
            this.picBoxButton.Location = new System.Drawing.Point(3, 5);
            this.picBoxButton.Name = "picBoxButton";
            this.picBoxButton.Size = new System.Drawing.Size(168, 117);
            this.picBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxButton.TabIndex = 1;
            this.picBoxButton.TabStop = false;
            this.picBoxButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 134);
            this.Controls.Add(this.lblClickMeTxt);
            this.Controls.Add(this.picBoxButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDM Reset ";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblClickMeTxt;
        private PictureBox picBoxButton;
    }
}