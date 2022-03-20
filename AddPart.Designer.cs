namespace BrandonMorgadoInventoryManagementSystem
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddPart = new System.Windows.Forms.Label();
            this.radioAddInHouse = new System.Windows.Forms.RadioButton();
            this.radioAddOutsourced = new System.Windows.Forms.RadioButton();
            this.addPartIDBox = new System.Windows.Forms.TextBox();
            this.addPartNameBox = new System.Windows.Forms.TextBox();
            this.addPartPriceBox = new System.Windows.Forms.TextBox();
            this.addPartInvBox = new System.Windows.Forms.TextBox();
            this.addPartMaxBox = new System.Windows.Forms.TextBox();
            this.addPartMinBox = new System.Windows.Forms.TextBox();
            this.addPartMachComBox = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.btnAddPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddPart
            // 
            this.labelAddPart.AutoSize = true;
            this.labelAddPart.Location = new System.Drawing.Point(8, 6);
            this.labelAddPart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddPart.Name = "labelAddPart";
            this.labelAddPart.Size = new System.Drawing.Size(48, 13);
            this.labelAddPart.TabIndex = 0;
            this.labelAddPart.Text = "Add Part";
            this.labelAddPart.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioAddInHouse
            // 
            this.radioAddInHouse.AutoSize = true;
            this.radioAddInHouse.Location = new System.Drawing.Point(93, 3);
            this.radioAddInHouse.Margin = new System.Windows.Forms.Padding(2);
            this.radioAddInHouse.Name = "radioAddInHouse";
            this.radioAddInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioAddInHouse.TabIndex = 1;
            this.radioAddInHouse.TabStop = true;
            this.radioAddInHouse.Text = "In-House";
            this.radioAddInHouse.UseVisualStyleBackColor = true;
            this.radioAddInHouse.CheckedChanged += new System.EventHandler(this.radioAddInHouse_CheckedChanged);
            // 
            // radioAddOutsourced
            // 
            this.radioAddOutsourced.AutoSize = true;
            this.radioAddOutsourced.Location = new System.Drawing.Point(182, 3);
            this.radioAddOutsourced.Margin = new System.Windows.Forms.Padding(2);
            this.radioAddOutsourced.Name = "radioAddOutsourced";
            this.radioAddOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioAddOutsourced.TabIndex = 2;
            this.radioAddOutsourced.TabStop = true;
            this.radioAddOutsourced.Text = "Outsourced";
            this.radioAddOutsourced.UseVisualStyleBackColor = true;
            this.radioAddOutsourced.CheckedChanged += new System.EventHandler(this.radioAddOutsourced_CheckedChanged);
            // 
            // addPartIDBox
            // 
            this.addPartIDBox.Enabled = false;
            this.addPartIDBox.Location = new System.Drawing.Point(93, 50);
            this.addPartIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartIDBox.Name = "addPartIDBox";
            this.addPartIDBox.Size = new System.Drawing.Size(164, 20);
            this.addPartIDBox.TabIndex = 3;
            this.addPartIDBox.Text = "Auto Generated";
            this.addPartIDBox.TextChanged += new System.EventHandler(this.addPartIDBox_TextChanged);
            // 
            // addPartNameBox
            // 
            this.addPartNameBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartNameBox.Location = new System.Drawing.Point(93, 81);
            this.addPartNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartNameBox.Name = "addPartNameBox";
            this.addPartNameBox.Size = new System.Drawing.Size(164, 20);
            this.addPartNameBox.TabIndex = 4;
            this.addPartNameBox.TextChanged += new System.EventHandler(this.addPartNameBox_TextChanged);
            // 
            // addPartPriceBox
            // 
            this.addPartPriceBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartPriceBox.Location = new System.Drawing.Point(93, 144);
            this.addPartPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartPriceBox.Name = "addPartPriceBox";
            this.addPartPriceBox.Size = new System.Drawing.Size(164, 20);
            this.addPartPriceBox.TabIndex = 6;
            this.addPartPriceBox.TextChanged += new System.EventHandler(this.addPartPriceBox_TextChanged);
            // 
            // addPartInvBox
            // 
            this.addPartInvBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartInvBox.Location = new System.Drawing.Point(93, 113);
            this.addPartInvBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartInvBox.Name = "addPartInvBox";
            this.addPartInvBox.Size = new System.Drawing.Size(164, 20);
            this.addPartInvBox.TabIndex = 5;
            this.addPartInvBox.TextChanged += new System.EventHandler(this.addPartInvBox_TextChanged);
            // 
            // addPartMaxBox
            // 
            this.addPartMaxBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartMaxBox.Location = new System.Drawing.Point(93, 172);
            this.addPartMaxBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartMaxBox.Name = "addPartMaxBox";
            this.addPartMaxBox.Size = new System.Drawing.Size(63, 20);
            this.addPartMaxBox.TabIndex = 7;
            this.addPartMaxBox.TextChanged += new System.EventHandler(this.addPartMaxBox_TextChanged);
            // 
            // addPartMinBox
            // 
            this.addPartMinBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartMinBox.Location = new System.Drawing.Point(193, 172);
            this.addPartMinBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartMinBox.Name = "addPartMinBox";
            this.addPartMinBox.Size = new System.Drawing.Size(63, 20);
            this.addPartMinBox.TabIndex = 8;
            this.addPartMinBox.TextChanged += new System.EventHandler(this.addPartMinBox_TextChanged);
            // 
            // addPartMachComBox
            // 
            this.addPartMachComBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartMachComBox.Location = new System.Drawing.Point(93, 204);
            this.addPartMachComBox.Margin = new System.Windows.Forms.Padding(2);
            this.addPartMachComBox.Name = "addPartMachComBox";
            this.addPartMachComBox.Size = new System.Drawing.Size(164, 20);
            this.addPartMachComBox.TabIndex = 9;
            this.addPartMachComBox.TextChanged += new System.EventHandler(this.addPartMachComBox_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(62, 50);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(167, 174);
            this.labelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(63, 174);
            this.labelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 12;
            this.labelMax.Text = "Max";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(55, 83);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(39, 115);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 14;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Location = new System.Drawing.Point(29, 146);
            this.labelPriceCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(63, 13);
            this.labelPriceCost.TabIndex = 15;
            this.labelPriceCost.Text = "Price / Cost";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Machine ID";
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.Location = new System.Drawing.Point(139, 232);
            this.btnAddPartSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(50, 28);
            this.btnAddPartSave.TabIndex = 17;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.btnAddPartSave_Click);
            // 
            // btnAddPartCancel
            // 
            this.btnAddPartCancel.Location = new System.Drawing.Point(205, 232);
            this.btnAddPartCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPartCancel.Name = "btnAddPartCancel";
            this.btnAddPartCancel.Size = new System.Drawing.Size(50, 28);
            this.btnAddPartCancel.TabIndex = 18;
            this.btnAddPartCancel.Text = "Cancel";
            this.btnAddPartCancel.UseVisualStyleBackColor = true;
            this.btnAddPartCancel.Click += new System.EventHandler(this.btnAddPartCancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 274);
            this.Controls.Add(this.btnAddPartCancel);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.addPartMachComBox);
            this.Controls.Add(this.addPartMinBox);
            this.Controls.Add(this.addPartMaxBox);
            this.Controls.Add(this.addPartPriceBox);
            this.Controls.Add(this.addPartInvBox);
            this.Controls.Add(this.addPartNameBox);
            this.Controls.Add(this.addPartIDBox);
            this.Controls.Add(this.radioAddOutsourced);
            this.Controls.Add(this.radioAddInHouse);
            this.Controls.Add(this.labelAddPart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPart;
        private System.Windows.Forms.RadioButton radioAddInHouse;
        private System.Windows.Forms.RadioButton radioAddOutsourced;
        private System.Windows.Forms.TextBox addPartIDBox;
        private System.Windows.Forms.TextBox addPartNameBox;
        private System.Windows.Forms.TextBox addPartPriceBox;
        private System.Windows.Forms.TextBox addPartInvBox;
        private System.Windows.Forms.TextBox addPartMaxBox;
        private System.Windows.Forms.TextBox addPartMinBox;
        private System.Windows.Forms.TextBox addPartMachComBox;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPartSave;
        private System.Windows.Forms.Button btnAddPartCancel;
    }
}