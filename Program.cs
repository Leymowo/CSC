using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    static class Program
    {
        /*

        Program Author: Khalid Alghamdi

        Assignment: Program 3: Lenny's Car Wash

        Description:

        A Program where you can Choose which tier you want to pay for,
        with a real time updating Total price and Optional Addons. This is the Main

        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
