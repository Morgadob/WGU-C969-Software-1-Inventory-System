using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandonMorgadoInventoryManagementSystem
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, int inStock, decimal price, int max, int min, string companyName)
       : base(partID, name, inStock, price, max, min)
        {
            CompanyName = companyName;
        }

        public Outsourced(string name, int inStock, decimal price, int max, int min, string companyName)
            : base(name, inStock, price, max, min)
        {
            CompanyName = companyName;
        }




    }
}
