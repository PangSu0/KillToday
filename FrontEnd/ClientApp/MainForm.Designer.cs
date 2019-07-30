namespace ClientApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login1 = new ClientApp.UserControls.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(12, 13);
            this.login1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(601, 498);
            this.login1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 919);
            this.Controls.Add(this.login1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WOOW";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Login login1;
    }
}

