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
    public partial class AddPart : Form
    {
        
        Part addPart;
        MainForm mainForm = new MainForm();

        public AddPart()
        { 
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioAddInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Machine ID";
            
        }

        private void radioAddOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Company Name";
            
        }

        private void addPartIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPartNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartNameBox.Text) || int.TryParse(addPartNameBox.Text, out int i)) 
            {
                addPartNameBox.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
                
            }
            else
            {
                addPartNameBox.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }


        }

        private void addPartInvBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartInvBox.Text) || !(int.TryParse(addPartInvBox.Text, out int i)))
            {
                addPartInvBox.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;

            }
            else
            {
                addPartInvBox.BackColor = Color.White;
                btnAddPartSave.Enabled = true;

            }
        }

        private void addPartPriceBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartPriceBox.Text) || !(decimal.TryParse(addPartPriceBox.Text, out decimal i)))
            {
                addPartPriceBox.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;

            }
            else
            {
                addPartPriceBox.BackColor = Color.White;
                btnAddPartSave.Enabled = true;

            }
        }

        private void addPartMaxBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartMaxBox.Text) || !(int.TryParse(addPartMaxBox.Text, out int i)))
            {
                addPartMaxBox.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;

            }
            else
            {
                addPartMaxBox.BackColor = Color.White;
                btnAddPartSave.Enabled = true;

            }
        }

        private void addPartMinBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartMinBox.Text) || !(int.TryParse(addPartMinBox.Text, out int i)))
            {
                addPartMinBox.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;

            }
            else
            {
                addPartMinBox.BackColor = Color.White;
                btnAddPartSave.Enabled = true;

            }
        }

        private void addPartMachComBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartMachComBox.Text) || 
                (radioAddInHouse.Checked && !(int.TryParse(addPartMachComBox.Text, out int i))) ||
                (radioAddOutsourced.Checked && int.TryParse(addPartMachComBox.Text, out int s)))
            {
                addPartMachComBox.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
            }
            else
            {
                addPartMachComBox.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }
            
          
        }

        private void btnAddPartSave_Click(object sender, EventArgs e)
        {
            
          
            MainForm mainForm = new MainForm();

            if ((Convert.ToInt32(addPartMinBox.Text) < Convert.ToInt32(addPartMaxBox.Text)) &&
                       (Convert.ToInt32(addPartMinBox.Text) <= Convert.ToInt32(addPartInvBox.Text)) &&
                       (Convert.ToInt32(addPartInvBox.Text) <= Convert.ToInt32(addPartMaxBox.Text)))
            { 

                if (radioAddInHouse.Checked)
                {
                    addPart = new Inhouse(
                        (Inventory.MyList.Count + 1),//adds +1 to partID
                        addPartNameBox.Text,
                        Convert.ToInt32(addPartInvBox.Text),
                        Convert.ToDecimal(addPartPriceBox.Text),
                        Convert.ToInt32(addPartMinBox.Text),
                        Convert.ToInt32(addPartMaxBox.Text),
                        Convert.ToInt32(addPartMachComBox.Text));

                    Inventory.add(addPart);
                    this.Close();
                    mainForm.Show();
                }
                else
                {
                    addPart = new Outsourced(
                        (Inventory.MyList.Count + 1), // adds + 1 to partID
                        addPartNameBox.Text,
                        Convert.ToInt32(addPartInvBox.Text),
                        Convert.ToDecimal(addPartPriceBox.Text),
                        Convert.ToInt32(addPartMinBox.Text),
                        Convert.ToInt32(addPartMaxBox.Text),
                        addPartMachComBox.Text);

                    Inventory.add(addPart);
                this.Close();
                mainForm.Show();
                }
        
            }
            else
            {
                Exception exception = new Exception
                ("Please make sure that minimum is less than maximum and that inventory is between them both");
                MessageBox.Show(exception.Message);
            }
                

            
        }

        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();    
        }
    }
}
