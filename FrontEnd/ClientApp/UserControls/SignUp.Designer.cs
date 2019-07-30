namespace ClientApp
{
    partial class SignUp
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tetNickName = new DevExpress.XtraEditors.TextEdit();
            this.tetEmail = new DevExpress.XtraEditors.TextEdit();
            this.tetVerificationCode = new DevExpress.XtraEditors.TextEdit();
            this.tetPassword = new DevExpress.XtraEditors.TextEdit();
            this.tetPasswordCheck = new DevExpress.XtraEditors.TextEdit();
            this.btnVerificationCodeRequest = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.lbcCheckName = new DevExpress.XtraEditors.LabelControl();
            this.lbcPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbcPasswordCheck = new DevExpress.XtraEditors.LabelControl();
            this.lbcVerificationCode = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tetNickName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetVerificationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetPasswordCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "별명";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 30);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "이메일";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 198);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 30);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "암호";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 258);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 30);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "암호 확인";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 138);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 30);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "인증번호";
            // 
            // tetNickName
            // 
            this.tetNickName.Location = new System.Drawing.Point(110, 15);
            this.tetNickName.Name = "tetNickName";
            this.tetNickName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetNickName.Properties.Appearance.Options.UseFont = true;
            this.tetNickName.Size = new System.Drawing.Size(159, 36);
            this.tetNickName.TabIndex = 0;
            this.tetNickName.Leave += new System.EventHandler(this.TetNickName_Leave);
            // 
            // tetEmail
            // 
            this.tetEmail.Location = new System.Drawing.Point(110, 75);
            this.tetEmail.Name = "tetEmail";
            this.tetEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetEmail.Properties.Appearance.Options.UseFont = true;
            this.tetEmail.Size = new System.Drawing.Size(159, 36);
            this.tetEmail.TabIndex = 2;
            // 
            // tetVerificationCode
            // 
            this.tetVerificationCode.Location = new System.Drawing.Point(110, 135);
            this.tetVerificationCode.Name = "tetVerificationCode";
            this.tetVerificationCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetVerificationCode.Properties.Appearance.Options.UseFont = true;
            this.tetVerificationCode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tetVerificationCode.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tetVerificationCode.Size = new System.Drawing.Size(159, 36);
            this.tetVerificationCode.TabIndex = 4;
            this.tetVerificationCode.Leave += new System.EventHandler(this.TetVerificationCode_Leave);
            // 
            // tetPassword
            // 
            this.tetPassword.Location = new System.Drawing.Point(110, 195);
            this.tetPassword.Name = "tetPassword";
            this.tetPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetPassword.Properties.Appearance.Options.UseFont = true;
            this.tetPassword.Properties.PasswordChar = '*';
            this.tetPassword.Size = new System.Drawing.Size(159, 36);
            this.tetPassword.TabIndex = 5;
            this.tetPassword.Leave += new System.EventHandler(this.TetPassword_Leave);
            // 
            // tetPasswordCheck
            // 
            this.tetPasswordCheck.Location = new System.Drawing.Point(110, 255);
            this.tetPasswordCheck.Name = "tetPasswordCheck";
            this.tetPasswordCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tetPasswordCheck.Properties.Appearance.Options.UseFont = true;
            this.tetPasswordCheck.Properties.PasswordChar = '*';
            this.tetPasswordCheck.Size = new System.Drawing.Size(159, 36);
            this.tetPasswordCheck.TabIndex = 6;
            this.tetPasswordCheck.Leave += new System.EventHandler(this.TetPasswordCheck_Leave);
            // 
            // btnVerificationCodeRequest
            // 
            this.btnVerificationCodeRequest.Location = new System.Drawing.Point(275, 78);
            this.btnVerificationCodeRequest.Name = "btnVerificationCodeRequest";
            this.btnVerificationCodeRequest.Size = new System.Drawing.Size(93, 29);
            this.btnVerificationCodeRequest.TabIndex = 3;
            this.btnVerificationCodeRequest.Text = "인증번호 요청";
            this.btnVerificationCodeRequest.Click += new System.EventHandler(this.BtnVerificationCodeRequest_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Location = new System.Drawing.Point(516, 310);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 45);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "다음";
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lbcCheckName
            // 
            this.lbcCheckName.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbcCheckName.Appearance.Options.UseForeColor = true;
            this.lbcCheckName.Location = new System.Drawing.Point(275, 28);
            this.lbcCheckName.Name = "lbcCheckName";
            this.lbcCheckName.Size = new System.Drawing.Size(0, 18);
            this.lbcCheckName.TabIndex = 8;
            // 
            // lbcPassword
            // 
            this.lbcPassword.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbcPassword.Appearance.Options.UseForeColor = true;
            this.lbcPassword.Location = new System.Drawing.Point(275, 208);
            this.lbcPassword.Name = "lbcPassword";
            this.lbcPassword.Size = new System.Drawing.Size(0, 18);
            this.lbcPassword.TabIndex = 9;
            // 
            // lbcPasswordCheck
            // 
            this.lbcPasswordCheck.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbcPasswordCheck.Appearance.Options.UseForeColor = true;
            this.lbcPasswordCheck.Location = new System.Drawing.Point(275, 268);
            this.lbcPasswordCheck.Name = "lbcPasswordCheck";
            this.lbcPasswordCheck.Size = new System.Drawing.Size(0, 18);
            this.lbcPasswordCheck.TabIndex = 10;
            // 
            // lbcVerificationCode
            // 
            this.lbcVerificationCode.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbcVerificationCode.Appearance.Options.UseForeColor = true;
            this.lbcVerificationCode.Location = new System.Drawing.Point(275, 148);
            this.lbcVerificationCode.Name = "lbcVerificationCode";
            this.lbcVerificationCode.Size = new System.Drawing.Size(0, 18);
            this.lbcVerificationCode.TabIndex = 11;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbcVerificationCode);
            this.Controls.Add(this.lbcPasswordCheck);
            this.Controls.Add(this.lbcPassword);
            this.Controls.Add(this.lbcCheckName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnVerificationCodeRequest);
            this.Controls.Add(this.tetPasswordCheck);
            this.Controls.Add(this.tetPassword);
            this.Controls.Add(this.tetVerificationCode);
            this.Controls.Add(this.tetEmail);
            this.Controls.Add(this.tetNickName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(701, 472);
            ((System.ComponentModel.ISupportInitialize)(this.tetNickName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetVerificationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetPasswordCheck.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tetNickName;
        private DevExpress.XtraEditors.TextEdit tetEmail;
        private DevExpress.XtraEditors.TextEdit tetVerificationCode;
        private DevExpress.XtraEditors.TextEdit tetPassword;
        private DevExpress.XtraEditors.TextEdit tetPasswordCheck;
        private DevExpress.XtraEditors.SimpleButton btnVerificationCodeRequest;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.LabelControl lbcCheckName;
        private DevExpress.XtraEditors.LabelControl lbcPassword;
        private DevExpress.XtraEditors.LabelControl lbcPasswordCheck;
        private DevExpress.XtraEditors.LabelControl lbcVerificationCode;
    }
}
