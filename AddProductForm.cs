using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonMorgadoInventoryManagementSystem
{
    public partial class AddProductForm : Form
    {


        BindingList<Part> partsToAdd = new BindingList<Part>();

        public AddProductForm()
        {

            Product newProd = new Product();
            Inventory.CurrentProd = newProd;

            InitializeComponent();
            

            addProductGrid1.DataSource = Inventory.MyList;
            addProductGrid2.DataSource = Inventory.CurrentProd.AssociatedParts;



            formatDGV(addProductGrid1);
            formatDGV(addProductGrid2);
        }

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
            this.addProductGrid1.ReadOnly = true;
            this.addProductGrid2.ReadOnly = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm newMain = new MainForm();
            newMain.Show();
        }

        public void AddProductScreenLoad()
        {
          
        }

      

        private void buttonSave_Click(object sender, EventArgs e)
        {
           if ((Convert.ToInt32(addProdMin.Text) < Convert.ToInt32(addProdMax.Text))
               && (Convert.ToInt32(addProdMin.Text) <= Convert.ToInt32(addProdInv.Text))
               && (Convert.ToInt32(addProdInv.Text) <= Convert.ToInt32(addProdMax.Text)))
            {
                Inventory.CurrentProd.ProductID = Inventory.ProductList.Count + 1;
                Inventory.CurrentProd.Name = addProdName.Text;
                Inventory.CurrentProd.InStock = Int32.Parse(addProdInv.Text);
                Inventory.CurrentProd.Price = Decimal.Parse(addProdPrice.Text);
                Inventory.CurrentProd.Max = Int32.Parse(addProdMax.Text);
                Inventory.CurrentProd.Min = Int32.Parse(addProdMin.Text);

                Inventory.addProduct(Inventory.CurrentProd);

                this.Close();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                Exception exception = new Exception
                ("Please make sure that minimum is less than maximum and that inventory is between them both");
                MessageBox.Show(exception.Message);

            }

            



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
      
            Inventory.CurrentProd.addAssocPart(Inventory.CurrentPart);
            addProductGrid2.DataSource = Inventory.CurrentProd.AssociatedParts;
            addProductGrid1.DataSource = Inventory.MyList;
        }

        private void addProductGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.MyList[Inventory.CurrentIndex];
        }

        private void addProductGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentAssocIndex = e.RowIndex;
            Inventory.CurrentAssocPart = Inventory.CurrentProd.AssociatedParts[Inventory.CurrentAssocIndex];
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            //oops
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please confirm that you want to delete this part?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Inventory.CurrentProd.deleteAssocPart(Inventory.CurrentAssocIndex);
            }
            else
            {
                //breaks method
            }
           
        }

        private void addProductGrid1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addProductGrid1.ClearSelection();
            addProductGrid2.ClearSelection();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            addProductGrid1.ClearSelection();
            bool found = false;
            if (!int.TryParse(searchBoxAddProd.Text, out int searchID))
            {
                MessageBox.Show("Please make sure Product ID is numeric");
                return;
            }
            foreach (DataGridViewRow row in addProductGrid1.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == searchID)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Cannot find Part ID");
            }
        }

        private void addProdName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdName.Text) || int.TryParse(addProdName.Text, out int i))
            {
                addProdName.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                addProdName.BackColor = Color.White;
                buttonSave.Enabled = true;
            }
        }

        private void addProdInv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdInv.Text) || !(int.TryParse(addProdInv.Text, out int i)))
            {
                addProdInv.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                addProdInv.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void addProdPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdPrice.Text) || !(decimal.TryParse(addProdPrice.Text, out decimal i)))
            {
                addProdPrice.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                addProdPrice.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void addProdMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdMax.Text) || !(decimal.TryParse(addProdMax.Text, out decimal i)))
            {
                addProdMax.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                addProdMax.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void addProdMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdMin.Text) || !(decimal.TryParse(addProdMin.Text, out decimal i)))
            {
                addProdMin.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                addProdMin.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }
    }
}
