using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    static class Start
    {
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Login L1 = new Login();
     
            Application.Run(L1);
            Application.Exit();
        }

    }
}
