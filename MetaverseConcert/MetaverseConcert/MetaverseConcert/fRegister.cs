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
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cboTitle.Enabled = true;
            txtFName.Enabled = true;
            txtLname.Enabled = true;
            txtAge.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtCpassword.Enabled = true;

            cboTitle1.Enabled = false;
            txtFname1.Enabled = false;
            txtLname1.Enabled = false;
            txtAge1.Enabled = false;
            txtEmail1.Enabled = false;
            txtStudentId.Enabled = false;
            txtPassword1.Enabled = false;
            txtCpassword1.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cboTitle.Enabled = false;
            txtFName.Enabled = false;
            txtLname.Enabled = false;
            txtAge.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtCpassword.Enabled = false;

            cboTitle1.Enabled = true;
            txtFname1.Enabled = true;
            txtLname1.Enabled = true;
            txtAge1.Enabled = true;
            txtEmail1.Enabled = true;
            txtStudentId.Enabled = true;
            txtPassword1.Enabled = true;
            txtCpassword1.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (rdoAdult.Checked) {
                //validate
                if (cboTitle.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกคำนำหน้า");
                    return;
                }
                if (txtFName.Text == "")
                {
                    MessageBox.Show("กรุณากรอกชื่อ");
                    return;
                }
                if (txtLname.Text == "")
                {
                    MessageBox.Show("กรุณากรอกนามสกุล");
                    return;
                }
                if (txtAge.Text == "")
                {
                    MessageBox.Show("กรุณากรอกอายุ");
                    return;
                }
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
                if (txtCpassword.Text == "")
                {
                    MessageBox.Show("กรุณากรอกยืนยันรหัสผ่าน");
                    return;
                }

                //check
                if (Globals.adults.Where(a => a.title == cboTitle.Text && a.Fname == txtFName.Text && a.Sname == txtLname.Text).FirstOrDefault() == null)
                {
                    MessageBox.Show("ผู้ใช้นี้มีอยู่แล้ว กรุณาลองอีกครั้ง");
                    return;
                }

                if (Globals.adults.Where(a => a.email == txtEmail.Text).FirstOrDefault()!=null)
                {
                    MessageBox.Show("อีเมล์ไม่ถูกต้อง กรุณาลองอีกครั้ง");
                    return;
                }

                if (txtPassword.Text != txtCpassword.Text)
                {
                    MessageBox.Show("รหัสผ่านไม่ตรงกัน กรุณาลองอีกครั้ง");
                    return;
                }

                Globals.adults.Add(new Adult {
                    title = cboTitle.Text,
                    Fname = txtFName.Text,
                    Sname = txtLname.Text,
                    age = Convert.ToInt16(txtAge.Text),
                    email = txtEmail.Text,
                    password = txtPassword.Text,
                    cpassword = txtCpassword.Text,

                });
            }
            else if (rdoStudent.Checked)
            {
                //validate
                if (cboTitle1.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกคำนำหน้า");
                    return;
                }
                if (txtFname1.Text == "")
                {
                    MessageBox.Show("กรุณากรอกชื่อ");
                    return;
                }
                if (txtLname1.Text == "")
                {
                    MessageBox.Show("กรุณากรอกนามสกุล");
                    return;
                }
                if (txtAge1.Text == "")
                {
                    MessageBox.Show("กรุณากรอกอายุ");
                    return;
                }
                if (txtEmail1.Text == "")
                {
                    MessageBox.Show("กรุณากรอกอีเมล์");
                    return;
                }
                if (txtStudentId.Text == "")
                {
                    MessageBox.Show("กรุณากรอกรหัสนักเรียน");
                    return;
                }
                if (txtPassword1.Text == "")
                {
                    MessageBox.Show("กรุณากรอกรหัสผ่าน");
                    return;
                }
                if (txtCpassword1.Text == "")
                {
                    MessageBox.Show("กรุณากรอกยืนยันรหัสผ่าน");
                    return;
                }

                //check
                if (Globals.students.Where(a => a.title == cboTitle.Text && a.Fname == txtFName.Text && a.Sname == txtLname.Text).FirstOrDefault() == null)
                {
                    MessageBox.Show("ผู้ใช้นี้มีอยู่แล้ว กรุณาลองอีกครั้ง");
                    return;
                }

                if (Globals.students.Where(a => a.email == txtEmail.Text).FirstOrDefault() != null)
                {
                    MessageBox.Show("อีเมล์ไม่ถูกต้อง กรุณาลองอีกครั้ง");
                    return;
                }

                if (txtPassword.Text != txtCpassword.Text)
                {
                    MessageBox.Show("รหัสผ่านไม่ตรงกัน กรุณาลองอีกครั้ง");
                    return;
                }

                Globals.students.Add(new Student
                {
                    title = cboTitle.Text,
                    Fname = txtFName.Text,
                    Sname = txtLname.Text,
                    age = Convert.ToInt16(txtAge.Text),
                    email = txtEmail.Text,
                    StudentId = txtStudentId.Text,
                    password = txtPassword.Text,
                    cpassword = txtCpassword.Text,

                });
            }

            this.Close();
        }
    }
}
