using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WOOW.Data;

namespace ClientApp
{
    public partial class SignUp : UserControl
    {
        string VerificationCode = null;
        public SignUp()
        {
            InitializeComponent();
        }
        private void BtnVerificationCodeRequest_Click(object sender, EventArgs e)
        {
            //인증번호 요청
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //다음화면
        }

        private void TetNickName_Leave(object sender, EventArgs e)
        {
            string name = tetNickName.Text;
            if (name.Length < 2 || name.Length > 10)
                lbcCheckName.Text = "별명을 2~10자 이내로 설정하여 주십시오.";
            else if (DataRepository.Profile.IsUsedName(name))
                lbcCheckName.Text = "별명이 중복되었습니다.";
            else
                lbcCheckName.Text = "";
        }

        private void TetVerificationCode_Leave(object sender, EventArgs e)
        {
            if (VerificationCode == null)
                return;
            if (VerificationCode != tetVerificationCode.Text)
                lbcVerificationCode.Text = "인증번호가 일치하지 않습니다.";
            else
                lbcVerificationCode.Text = "";
        }

        private void TetPassword_Leave(object sender, EventArgs e)
        {
            if (tetPassword.Text.Length > 20)
                lbcPassword.Text = "암호를 20자리 이하로 설정해 주십시오.";
            else if (tetPassword.Text.Length < 10)
                lbcPassword.Text = "암호를 10자리 이상으로 설정해 주십시오.";
            else
                lbcPassword.Text = "";
            TetPasswordCheck_Leave(sender, e);
        }

        private void TetPasswordCheck_Leave(object sender, EventArgs e)
        {
            if(tetPassword.Text != tetPasswordCheck.Text)
                lbcPasswordCheck.Text = "암호가 일치하지 않습니다.";
            else
                lbcPasswordCheck.Text = "";
        }
    }
}
