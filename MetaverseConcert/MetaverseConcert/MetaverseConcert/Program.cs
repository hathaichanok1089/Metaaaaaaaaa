using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaverseConcert
{
    static class Globals {
        public static List<Adult> adults;
        public static List<Student> students;
        public static List<Seat> seats;
        public static List<Booking> bookings;
        public static Login login;
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fStart());
        }
    }
}
