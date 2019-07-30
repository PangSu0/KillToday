namespace ClientApp.UserControls
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tetLoginId = new DevExpress.XtraEditors.TextEdit();
            this.tetLoginPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tetLoginId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetLoginPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tetLoginId
            // 
            this.tetLoginId.Location = new System.Drawing.Point(371, 136);
            this.tetLoginId.Name = "tetLoginId";
            this.tetLoginId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetLoginId.Properties.Appearance.Options.UseFont = true;
            this.tetLoginId.Size = new System.Drawing.Size(204, 36);
            this.tetLoginId.TabIndex = 0;
            // 
            // tetLoginPassword
            // 
            this.tetLoginPassword.Location = new System.Drawing.Point(371, 183);
            this.tetLoginPassword.Name = "tetLoginPassword";
            this.tetLoginPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetLoginPassword.Properties.Appearance.Options.UseFont = true;
            this.tetLoginPassword.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tetLoginPassword.Properties.PasswordChar = '*';
            this.tetLoginPassword.Size = new System.Drawing.Size(204, 36);
            this.tetLoginPassword.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(305, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 30);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "이메일";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(325, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 30);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "암호";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(371, 225);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(65, 29);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "회원가입";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(441, 225);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(65, 29);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "계정찾기";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(510, 225);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(65, 29);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "로그인";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tetLoginPassword);
            this.Controls.Add(this.tetLoginId);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(601, 498);
            ((System.ComponentModel.ISupportInitialize)(this.tetLoginId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetLoginPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tetLoginId;
        private DevExpress.XtraEditors.TextEdit tetLoginPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}
