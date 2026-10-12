using System;
using System.Windows.Forms;
using TiendaParcial;

namespace parcial2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Aquí le decimos que inicie tu Form1
            Application.Run(new Form1());
        }
    }
}