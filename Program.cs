using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonMorgadoInventoryManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inventory.MyList.Add(new Inhouse(1, "Wheel", 15, 12, 16, 1, 100));
            Inventory.MyList.Add(new Inhouse(2, "Pedal", 11, 8, 17, 1, 200));
            Inventory.MyList.Add(new Outsourced(3, "Chain", 6, 9, 10, 1, "Morgado Corp" ));
            Inventory.MyList.Add(new Outsourced(4, "Seat", 8, 4, 22, 1, "Morgado Corp"));

            Inventory.ProductList.Add(new Product(1, "Red Bike", 15, 11, 25, 1));
            Inventory.ProductList.Add(new Product(2, "Blue Bike", 5, 12, 25, 1));
            Inventory.ProductList.Add(new Product(3, "Yellow Bike", 19, 9, 20, 1));

            Application.Run(new MainForm());
        }
    }
}
