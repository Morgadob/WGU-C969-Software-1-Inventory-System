using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandonMorgadoInventoryManagementSystem
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
            : base(partID, name, inStock, price, max, min)
        {
            MachineID = machineID;
        }

        public Inhouse(string name, int inStock, decimal price, int max, int min, int machineID)
           : base(name, inStock, price, max, min)
        {
            MachineID = machineID;
        }

    }
        

}

