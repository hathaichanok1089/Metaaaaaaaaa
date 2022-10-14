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
    public partial class fBooking : Form
    {
        public fBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S") {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A1").FirstOrDefault();
            fp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A2").FirstOrDefault();
            fp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A3").FirstOrDefault();
            fp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A4").FirstOrDefault();
            fp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }

            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A5").FirstOrDefault();
            fp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A6").FirstOrDefault();
            fp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A7").FirstOrDefault();
            fp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A8").FirstOrDefault();
            fp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A9").FirstOrDefault();
            fp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Globals.login.loginType == "S")
            {
                MessageBox.Show("ไม่สามารถจองได้ กรุณาลองอีกครั้ง");
                return;
            }
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "A10").FirstOrDefault();
            fp.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B1").FirstOrDefault();
            fp.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B2").FirstOrDefault();
            fp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B3").FirstOrDefault();
            fp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B4").FirstOrDefault();
            fp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B5").FirstOrDefault();
            fp.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B6").FirstOrDefault();
            fp.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B7").FirstOrDefault();
            fp.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B8").FirstOrDefault();
            fp.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B9").FirstOrDefault();
            fp.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fPayment fp = new fPayment();
            fp.seatInfo = Globals.seats.Where(s => s.SeatNo == "B10").FirstOrDefault();
            fp.Show();
        }

        private void fBooking_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
