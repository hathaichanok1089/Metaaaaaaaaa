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
    public partial class fPayment : Form
    {
        public Seat seatInfo;

        public fPayment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdobank_CheckedChanged(object sender, EventArgs e)
        {
            txtAname.Enabled = true;
            txtANumber.Enabled = true;

            txtCname.Enabled = false;
            txtCno.Enabled = false;
            txtExpired.Enabled = false;
            txtcvv.Enabled = false;
        }

        private void rdoCreditcard_CheckedChanged(object sender, EventArgs e)
        {
            txtAname.Enabled = false;
            txtANumber.Enabled = false;

            txtCname.Enabled = true;
            txtCno.Enabled = true;
            txtExpired.Enabled = true;
            txtcvv.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdobank.Checked)
            {
                //validate
                if (txtAname.Text == "")
                {
                    MessageBox.Show("กรุณากรอกชื่อบัญชี");
                    return;
                }
                if (txtANumber.Text == "")
                {
                    MessageBox.Show("กรุณากรอกหมายบัญชี");
                    return;
                }
               

                Globals.bookings.Add(new Booking
                {
                   SeatNo = seatInfo.SeatNo,
                   paymentBy="0",
                   aName = txtAname.Text,
                   cardNo = txtANumber.Text,
                    

                });
            }
            else if (rdoCreditcard.Checked)
            {
                //validate
                if (txtCname.Text == "")
                {
                    MessageBox.Show("กรุณากรอกหมายเลขบัตรเครดิต");
                    return;
                }
                if (txtCno.Text == "")
                {
                    MessageBox.Show("กรุณากรอกชื่อเจ้าของบัตร");
                    return;
                }
                if (txtExpired.Text == "")
                {
                    MessageBox.Show("กรุณากรอกวันหมดอายุ");
                    return;
                }
                if (txtcvv.Text == "")
                {
                    MessageBox.Show("กรุณากรอกหมายเลข CVV ");
                    return;
                }


                Globals.bookings.Add(new Booking
                {
                    SeatNo = seatInfo.SeatNo,
                    paymentBy = "1",
                    aName = txtCname.Text,
                    cardNo = txtCno.Text,
                    expireDate = txtExpired.Text,
                    cvv = txtcvv.Text,
                });
            }

            this.Close();
        }
    }
}
