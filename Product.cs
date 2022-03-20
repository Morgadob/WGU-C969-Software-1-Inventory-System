using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrandonMorgadoInventoryManagementSystem
{
    class Product
    {
        
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public Product() 
        {
            //empty used for addproduct empty object
        }
        public Product(int productID, string name, int inStock, decimal price, int max, int min)
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

        public Product(string name, int inStock, decimal price, int max, int min)
        {
            AssociatedParts = new BindingList<Part>();
          
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

        public void addAssocPart(Part partObject)
        {
            AssociatedParts.Add(partObject);
        }

        public bool deleteAssocPart(int assocPart)
        {
            try
            {
                AssociatedParts.RemoveAt(assocPart);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void lookupAssocPart(int assocPartID)
        {
            //foreach (Part part in assocPartID)
            //{
            //    if (assocPartID == part.PartID)
            //    {
            //        return part;
            //    }
            //}

            //return null;
        }


    }
}
