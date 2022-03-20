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
    public partial class MainForm : Form
    {

        public int currPart { get; set; }

        public MainForm()
        {
            InitializeComponent();
            

            dataGridView1.DataSource = Inventory.MyList;
            dataGridView2.DataSource = Inventory.ProductList;

            dataGridView1.Columns["PartID"].HeaderText = "Part ID";
            dataGridView1.Columns["Name"].HeaderText = "Part Name";
            dataGridView1.Columns["InStock"].HeaderText = "Inventory";
            dataGridView1.Columns["Price"].HeaderText = "Price/Cost per Unit";
            dataGridView1.Columns["Max"].Visible = false;
            dataGridView1.Columns["Min"].Visible = false;

            dataGridView2.Columns["ProductID"].HeaderText = "Product ID";
            dataGridView2.Columns["Name"].HeaderText = "Part Name";
            dataGridView2.Columns["InStock"].HeaderText = "Inventory";
            dataGridView2.Columns["Price"].HeaderText = "Price/Cost per Unit";
            dataGridView2.Columns["Max"].Visible = false;
            dataGridView2.Columns["Min"].Visible = false;

            formatDGV(dataGridView1);
            formatDGV(dataGridView2);
        }

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView2.ReadOnly = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchPart_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            bool found = false;
            if (!int.TryParse(textBox1.Text, out int searchID))
            {
                MessageBox.Show("Please make sure Part ID is numeric");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void AddPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart partForm = new AddPart();
            partForm.Show();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            ModifyPart modPart = new ModifyPart(); //creates new object
            modPart.modPartIDBox.Enabled = false; //disables ID Box
            //if (dataGridView1.CurrentRow.DataBoundItem is Inhouse)
            //{
            //    modPart.radioModInhouse.Select();
            //    modPart.modPartIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    modPart.modPartNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    modPart.modPartInvBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    modPart.modPartPriceBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    modPart.modPartMinBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    modPart.modPartMaxBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //    modPart.label.Text = "Machine ID";
            //    Inhouse inhouse1 = (Inhouse)dataGridView1.CurrentRow.DataBoundItem;
            //    modPart.modPartMachComBox.Text = inhouse1.MachineID.ToString();
            //}
            //else
            //{
            //    modPart.radioModOutsourced.Select();
            //    modPart.modPartIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    modPart.modPartNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    modPart.modPartInvBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    modPart.modPartPriceBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    modPart.modPartMinBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    modPart.modPartMaxBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //    modPart.label.Text = "Company Name";
            //    Outsourced outsourced1 = (Outsourced)dataGridView1.CurrentRow.DataBoundItem;
            //    modPart.modPartMachComBox.Text = outsourced1.CompanyName.ToString();
            //}
            this.Hide();
            modPart.ShowDialog();
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please confirm that you want to delete this part?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                Inventory.MyList.RemoveAt(Inventory.CurrentIndex);
                //display();
            }
            else
            {
                //null
            }
        }

        private void SearchProduct_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            bool found = false;
            if (!int.TryParse(textBox2.Text, out int searchID))
            {
                MessageBox.Show("Please make sure Product ID is numeric");
                return;
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                Product prod = (Product)row.DataBoundItem;
                if (prod.ProductID == searchID)
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addProdForm = new AddProductForm();
            addProdForm.Show();
        }

        private void ModifyProduct_Click(object sender, EventArgs e)
        {

            Inventory.CurrentProd = Inventory.ProductList[Inventory.CurrentProdIndex];
            ModifyProductForm modProdForm = new ModifyProductForm();
            
         

            Inventory.CurrentProd = (Product)dataGridView2.CurrentRow.DataBoundItem;
            modProdForm.modProdID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            modProdForm.modProdName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            modProdForm.modProdInv.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            modProdForm.modProdPrice.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            modProdForm.modProdMax.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            modProdForm.modProdMin.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();


            this.Hide();
            
            modProdForm.Show();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentProd.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete a product with an associated part", "Error");
                return;
            }

            DialogResult result = MessageBox.Show("Please confirm that you want to delete this part?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Inventory.ProductList.RemoveAt(Inventory.CurrentProdIndex);
            }
            else
            {
                //breaks method
            }


            
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Inventory.CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            //Inventory.CurrentIndex = e.RowIndex;
        }




        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

    


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = e.RowIndex;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentProdIndex = e.RowIndex;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
    }
}
