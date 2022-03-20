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
    public partial class ModifyProductForm : Form
    {
        MainForm mainform = new MainForm();

        public ModifyProductForm()
        {
            InitializeComponent();

            modifyProductGrid1.DataSource = Inventory.MyList;
            modifyProductGrid2.DataSource = Inventory.CurrentProd.AssociatedParts;

            formatDGV(modifyProductGrid1);
            formatDGV(modifyProductGrid2);
        }

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
            this.modifyProductGrid1.ReadOnly = true;
            this.modifyProductGrid2.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdName.Text) || int.TryParse(modProdName.Text, out int i))
            {
                modProdName.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                modProdName.BackColor = Color.White;
                buttonSave.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdInv.Text) || !(int.TryParse(modProdInv.Text, out int i)))
            {
                modProdInv.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                modProdInv.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdPrice.Text) || !(decimal.TryParse(modProdPrice.Text, out decimal i)))
            {
                modProdPrice.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                modProdPrice.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdMax.Text) || !(decimal.TryParse(modProdMax.Text, out decimal i)))
            {
                modProdMax.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                modProdMax.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdMin.Text) || !(decimal.TryParse(modProdMin.Text, out decimal i)))
            {
                modProdMin.BackColor = Color.Salmon;
                buttonSave.Enabled = false;

            }
            else
            {
                modProdMin.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            modifyProductGrid1.ClearSelection();
            bool found = false;
            if (!int.TryParse(searchBoxModProd.Text, out int searchID))
            {
                MessageBox.Show("Please make sure Product ID is numeric");
                return;
            }
            foreach (DataGridViewRow row in modifyProductGrid1.Rows)
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

        private void searchBoxModProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyProductGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyProductGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProd.addAssocPart(Inventory.CurrentPart);
            modifyProductGrid2.DataSource = Inventory.CurrentProd.AssociatedParts;
            modifyProductGrid1.DataSource = Inventory.MyList;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("Please confirm that you want to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Inventory.CurrentProd.deleteAssocPart(Inventory.CurrentAssocIndex);
            }
            else
            {
                //breaks method
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if ((Convert.ToInt32(modProdMin.Text) < Convert.ToInt32(modProdMax.Text))
              && (Convert.ToInt32(modProdMin.Text) <= Convert.ToInt32(modProdInv.Text))
              && (Convert.ToInt32(modProdInv.Text) <= Convert.ToInt32(modProdMax.Text)))
            {
                Inventory.CurrentProd.ProductID = Convert.ToInt32(modProdID.Text);
                Inventory.CurrentProd.Name = modProdName.Text;
                Inventory.CurrentProd.InStock = Convert.ToInt32(modProdInv.Text);
                Inventory.CurrentProd.Price = Convert.ToDecimal(modProdPrice.Text);
                Inventory.CurrentProd.Min = Convert.ToInt32(modProdMin.Text);
                Inventory.CurrentProd.Max = Convert.ToInt32(modProdMax.Text);

                Inventory.swapProduct(Inventory.CurrentProd, Inventory.CurrentProdIndex);
                this.Close();
                mainform.Show();
            }
            else
            {
                Exception exception = new Exception("Please make sure that minimum is less than maximum and that inventory is between them both");
                MessageBox.Show(exception.Message);
            }


            

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
            mainform.Show();
        }

        private void modifyProductGrid1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            modifyProductGrid1.ClearSelection();
            modifyProductGrid2.ClearSelection();
        }

        private void modifyProductGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.MyList[Inventory.CurrentIndex];
        }

        private void modifyProductGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentAssocIndex = e.RowIndex;
            Inventory.CurrentAssocPart = Inventory.CurrentProd.AssociatedParts[Inventory.CurrentAssocIndex];
        }
    }
}
