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
    public partial class fBookedResult : Form
    {
        public fBookedResult()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            if (Globals.login.loginType == "0")
            {
                txtUserType.Text = "บุคคลทั่วไป";
            }
            else
            {
                txtUserType.Text = "นักเรียน";
            }

            var abook = Globals.bookings.Where(b => b.SeatNo.Contains("A")).ToList();
            var bbook = Globals.bookings.Where(b => b.SeatNo.Contains("B")).ToList();

            txtAqty.Text = abook.Count.ToString();
            txtAprice.Text =( abook.Count * 5235.25).ToString();

            txtBQty.Text = bbook.Count.ToString();
            txtBPrice.Text = (bbook.Count * 1200.50).ToString();

            if (abook[0].paymentBy == "0")
            {
                txtPayment.Text = "หักบัญชีธนาคาร";
            }
            else
            {
                txtPayment.Text = "หักบัตรเครดิต";
            }

            txtName.Text = abook[0].aName;
            txtCardno.Text = abook[0].cardNo;
            txtExpire.Text = abook[0].expireDate;
            txtCVV.Text = abook[0].cvv;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
