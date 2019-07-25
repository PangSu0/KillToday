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
            this.signUp1 = new ClientApp.SignUp();
            this.SuspendLayout();
            // 
            // signUp1
            // 
            this.signUp1.Location = new System.Drawing.Point(12, 13);
            this.signUp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(669, 523);
            this.signUp1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 919);
            this.Controls.Add(this.signUp1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WOOW";
            this.ResumeLayout(false);

        }

        #endregion

        private SignUp signUp1;
    }
}

