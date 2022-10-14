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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            Globals.seats.Add(new Seat { SeatNo="A1", price=500 });
            Globals.seats.Add(new Seat { SeatNo = "A2", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A3", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A4", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A5", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A6", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A7", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A8", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A9", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "A10", price = 1000 });
            Globals.seats.Add(new Seat { SeatNo = "B1", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B2", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B3", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B4", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B5", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B6", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B7", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B8", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B9", price = 500 });
            Globals.seats.Add(new Seat { SeatNo = "B10", price = 500 });
        }
    }
}
