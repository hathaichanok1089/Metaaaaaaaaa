using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaverseConcert
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("กรุณากรอกอีเมล์");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("กรุณากรอกรหัสผ่าน");
                return;
            }

            if (Globals.adults.Where(a => a.email == txtEmail.Text && a.password == txtPassword.Text).FirstOrDefault() == null)
            {

                if (Globals.students.Where(a => a.email == txtEmail.Text && a.password == txtPassword.Text).FirstOrDefault() == null)
                {
                    MessageBox.Show("อีเมล์หรือรหัสผ่านไม่ถูกต้อง กรุณาลองอีกครั้ง");
                    this.Close();
                    return;
                }
                else
                {
                    Globals.login.loginType = "S";
                }
            }
            else
            {
                Globals.login.loginType = "A";
            }

            fMain fm = new fMain();
            fm.Show();

        }
    }
}
