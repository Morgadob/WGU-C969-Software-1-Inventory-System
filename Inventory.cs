using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandonMorgadoInventoryManagementSystem
{
    class Inventory
    {
        public static BindingList<Part> MyList = new BindingList<Part>();
        //public static List<Person> MyList { get; set; }
        public static BindingList<Product> ProductList = new BindingList<Product>();
        public static int CurrentIndex { get; set; }
        public static int CurrentProdIndex { get; set; }

        public static int CurrentAssocIndex { get; set; }

        public static Part CurrentPart { get; set; }

        public static Product CurrentProd { get; set; }

        public static Part CurrentAssocPart { get; set; }




        public static void add(Part part)
        {
            MyList.Add(part);
        }

        public static void deletePart(int PartIDIndex)
        {
            MyList.RemoveAt(PartIDIndex);
        }

        public static void swap(Part part, int PartIDIndex)
        {
            MyList.RemoveAt(PartIDIndex);
            MyList.Insert(PartIDIndex, part);
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in MyList)
            {
                if (partID == part.PartID)
                {
                    return part;
                }

            }

            return null;
        }

        public static void addProduct(Product product)
        {
            ProductList.Add(product);
        }

        public static bool removeProduct(int index)
        {
            ProductList.RemoveAt(index);
            return true;
        }

        public static void swapProduct(Product product, int productID)
        {
            Inventory.removeProduct(CurrentProdIndex);
            Inventory.addProduct(CurrentProd);
            
        }

    }
}
