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
    public partial class ModifyPart : Form
    {

        Part modifyPart;
        MainForm mainForm = new MainForm();

        public ModifyPart()
        {
            InitializeComponent();
        }

        private void radioModInhouse_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Machine ID";
        }

        private void radioModOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Company Name";
        }

        private void modPartIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modPartNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartNameBox.Text) || int.TryParse(modPartNameBox.Text, out int i))
            {
                modPartNameBox.BackColor = Color.Salmon;
                btnModPartSave.Enabled = false;

            }
            else
            {
                modPartNameBox.BackColor = Color.White;
                btnModPartSave.Enabled = true;
            }
        }

        private void modPartInvBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartInvBox.Text) || !(int.TryParse(modPartInvBox.Text, out int i)))
            {
                modPartInvBox.BackColor = Color.Salmon;
                btnModPartSave.Enabled = false;

            }
            else
            {
                modPartInvBox.BackColor = Color.White;
                btnModPartSave.Enabled = true;

            }
        }

        private void modPartPriceBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartPriceBox.Text) || !(decimal.TryParse(modPartPriceBox.Text, out decimal i)))
            {
                modPartPriceBox.BackColor = Color.Salmon;
                btnModPartSave.Enabled = false;

            }
            else
            {
                modPartPriceBox.BackColor = Color.White;
                btnModPartSave.Enabled = true;
            }
        }

        private void modPartMaxBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartMaxBox.Text) || !(int.TryParse(modPartMaxBox.Text, out int i)))
            {
                modPartMaxBox.BackColor = Color.Salmon;
                btnModPartSave.Enabled = false;

            }
            else
            {
                modPartMaxBox.BackColor = Color.White;
                btnModPartSave.Enabled = true;

            }
        }

        private void modPartMinBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartMinBox.Text) || !(int.TryParse(modPartMinBox.Text, out int i)))
            {
                modPartMinBox.BackColor = Color.Salmon;
                btnModPartSave.Enabled = false;

            }
            else
            {
                modPartMinBox.BackColor = Color.White;
                btnModPartSave.Enabled = true;

            }
        }

        private void modPartMachComBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartMachComBox.Text) || 
                (radioModInhouse.Checked && !(int.TryParse(modPartMachComBox.Text, out int i))) ||
                (radioModOutsourced.Checked && int.TryParse(modPartMachComBox.Text, out int s)))
            {
                modPartMachComBox.BackColor = Color.Salmon;
                btnModPartSave.Enabled = false;
            }
            else
            {
                modPartMachComBox.BackColor = Color.White;
                btnModPartSave.Enabled = true;
            }
        }

        private void btnModPartSave_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(modPartMinBox.Text) < Convert.ToInt32(modPartMaxBox.Text)) &&
                       (Convert.ToInt32(modPartMinBox.Text) <= Convert.ToInt32(modPartInvBox.Text)) &&
                       (Convert.ToInt32(modPartInvBox.Text) <= Convert.ToInt32(modPartMaxBox.Text)))
            {
                if (radioModInhouse.Checked)
                {
                    modifyPart = new Inhouse(Convert.ToInt32(modPartIDBox.Text),
                        modPartNameBox.Text,
                        Convert.ToInt32(modPartInvBox.Text),
                        Convert.ToDecimal(modPartPriceBox.Text),
                        Convert.ToInt32(modPartMinBox.Text),
                        Convert.ToInt32(modPartMaxBox.Text),
                        Convert.ToInt32(modPartMachComBox.Text));
                    Inventory.swap(modifyPart, Inventory.CurrentIndex);
                    this.Close();

                    
                    mainForm.Show();
                }
                else
                {
                    modifyPart = new Outsourced(Convert.ToInt32(modPartIDBox.Text),
                        modPartNameBox.Text,
                        Convert.ToInt32(modPartInvBox.Text),
                        Convert.ToDecimal(modPartPriceBox.Text),
                        Convert.ToInt32(modPartMinBox.Text),
                        Convert.ToInt32(modPartMaxBox.Text),
                        modPartMachComBox.Text);
                    Inventory.swap(modifyPart, Inventory.CurrentIndex);
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

        private void btnModPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            mainForm.Show();
        }
    }
}
