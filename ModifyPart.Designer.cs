namespace BrandonMorgadoInventoryManagementSystem
{
    partial class ModifyPart
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
            this.btnModPartCancel = new System.Windows.Forms.Button();
            this.btnModPartSave = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.modPartMachComBox = new System.Windows.Forms.TextBox();
            this.modPartMinBox = new System.Windows.Forms.TextBox();
            this.modPartMaxBox = new System.Windows.Forms.TextBox();
            this.modPartPriceBox = new System.Windows.Forms.TextBox();
            this.modPartInvBox = new System.Windows.Forms.TextBox();
            this.modPartNameBox = new System.Windows.Forms.TextBox();
            this.modPartIDBox = new System.Windows.Forms.TextBox();
            this.radioModOutsourced = new System.Windows.Forms.RadioButton();
            this.radioModInhouse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModPartCancel
            // 
            this.btnModPartCancel.Location = new System.Drawing.Point(216, 237);
            this.btnModPartCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnModPartCancel.Name = "btnModPartCancel";
            this.btnModPartCancel.Size = new System.Drawing.Size(50, 28);
            this.btnModPartCancel.TabIndex = 37;
            this.btnModPartCancel.Text = "Cancel";
            this.btnModPartCancel.UseVisualStyleBackColor = true;
            this.btnModPartCancel.Click += new System.EventHandler(this.btnModPartCancel_Click);
            // 
            // btnModPartSave
            // 
            this.btnModPartSave.Location = new System.Drawing.Point(150, 237);
            this.btnModPartSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnModPartSave.Name = "btnModPartSave";
            this.btnModPartSave.Size = new System.Drawing.Size(50, 28);
            this.btnModPartSave.TabIndex = 36;
            this.btnModPartSave.Text = "Save";
            this.btnModPartSave.UseVisualStyleBackColor = true;
            this.btnModPartSave.Click += new System.EventHandler(this.btnModPartSave_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 211);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 13);
            this.label.TabIndex = 35;
            this.label.Text = "Company Name";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Location = new System.Drawing.Point(40, 151);
            this.labelPriceCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(63, 13);
            this.labelPriceCost.TabIndex = 34;
            this.labelPriceCost.Text = "Price / Cost";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(50, 120);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 33;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 88);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Name";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(74, 179);
            this.labelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 31;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(177, 179);
            this.labelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 30;
            this.labelMin.Text = "Min";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(73, 55);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 29;
            this.labelID.Text = "ID";
            // 
            // modPartMachComBox
            // 
            this.modPartMachComBox.BackColor = System.Drawing.Color.Salmon;
            this.modPartMachComBox.Location = new System.Drawing.Point(103, 209);
            this.modPartMachComBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartMachComBox.Name = "modPartMachComBox";
            this.modPartMachComBox.Size = new System.Drawing.Size(164, 20);
            this.modPartMachComBox.TabIndex = 28;
            this.modPartMachComBox.TextChanged += new System.EventHandler(this.modPartMachComBox_TextChanged);
            // 
            // modPartMinBox
            // 
            this.modPartMinBox.BackColor = System.Drawing.Color.Salmon;
            this.modPartMinBox.Location = new System.Drawing.Point(204, 177);
            this.modPartMinBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartMinBox.Name = "modPartMinBox";
            this.modPartMinBox.Size = new System.Drawing.Size(63, 20);
            this.modPartMinBox.TabIndex = 27;
            this.modPartMinBox.TextChanged += new System.EventHandler(this.modPartMinBox_TextChanged);
            // 
            // modPartMaxBox
            // 
            this.modPartMaxBox.BackColor = System.Drawing.Color.Salmon;
            this.modPartMaxBox.Location = new System.Drawing.Point(103, 177);
            this.modPartMaxBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartMaxBox.Name = "modPartMaxBox";
            this.modPartMaxBox.Size = new System.Drawing.Size(63, 20);
            this.modPartMaxBox.TabIndex = 26;
            this.modPartMaxBox.TextChanged += new System.EventHandler(this.modPartMaxBox_TextChanged);
            // 
            // modPartPriceBox
            // 
            this.modPartPriceBox.BackColor = System.Drawing.Color.Salmon;
            this.modPartPriceBox.Location = new System.Drawing.Point(103, 149);
            this.modPartPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartPriceBox.Name = "modPartPriceBox";
            this.modPartPriceBox.Size = new System.Drawing.Size(164, 20);
            this.modPartPriceBox.TabIndex = 25;
            this.modPartPriceBox.TextChanged += new System.EventHandler(this.modPartPriceBox_TextChanged);
            // 
            // modPartInvBox
            // 
            this.modPartInvBox.BackColor = System.Drawing.Color.Salmon;
            this.modPartInvBox.Location = new System.Drawing.Point(103, 118);
            this.modPartInvBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartInvBox.Name = "modPartInvBox";
            this.modPartInvBox.Size = new System.Drawing.Size(164, 20);
            this.modPartInvBox.TabIndex = 24;
            this.modPartInvBox.TextChanged += new System.EventHandler(this.modPartInvBox_TextChanged);
            // 
            // modPartNameBox
            // 
            this.modPartNameBox.BackColor = System.Drawing.Color.Salmon;
            this.modPartNameBox.Location = new System.Drawing.Point(103, 86);
            this.modPartNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartNameBox.Name = "modPartNameBox";
            this.modPartNameBox.Size = new System.Drawing.Size(164, 20);
            this.modPartNameBox.TabIndex = 23;
            this.modPartNameBox.TextChanged += new System.EventHandler(this.modPartNameBox_TextChanged);
            // 
            // modPartIDBox
            // 
            this.modPartIDBox.Location = new System.Drawing.Point(103, 55);
            this.modPartIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.modPartIDBox.Name = "modPartIDBox";
            this.modPartIDBox.Size = new System.Drawing.Size(164, 20);
            this.modPartIDBox.TabIndex = 22;
            this.modPartIDBox.TextChanged += new System.EventHandler(this.modPartIDBox_TextChanged);
            // 
            // radioModOutsourced
            // 
            this.radioModOutsourced.AutoSize = true;
            this.radioModOutsourced.Location = new System.Drawing.Point(193, 8);
            this.radioModOutsourced.Margin = new System.Windows.Forms.Padding(2);
            this.radioModOutsourced.Name = "radioModOutsourced";
            this.radioModOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioModOutsourced.TabIndex = 21;
            this.radioModOutsourced.TabStop = true;
            this.radioModOutsourced.Text = "Outsourced";
            this.radioModOutsourced.UseVisualStyleBackColor = true;
            this.radioModOutsourced.CheckedChanged += new System.EventHandler(this.radioModOutsourced_CheckedChanged);
            // 
            // radioModInhouse
            // 
            this.radioModInhouse.AutoSize = true;
            this.radioModInhouse.Location = new System.Drawing.Point(103, 8);
            this.radioModInhouse.Margin = new System.Windows.Forms.Padding(2);
            this.radioModInhouse.Name = "radioModInhouse";
            this.radioModInhouse.Size = new System.Drawing.Size(68, 17);
            this.radioModInhouse.TabIndex = 20;
            this.radioModInhouse.TabStop = true;
            this.radioModInhouse.Text = "In-House";
            this.radioModInhouse.UseVisualStyleBackColor = true;
            this.radioModInhouse.CheckedChanged += new System.EventHandler(this.radioModInhouse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 274);
            this.Controls.Add(this.btnModPartCancel);
            this.Controls.Add(this.btnModPartSave);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.modPartMachComBox);
            this.Controls.Add(this.modPartMinBox);
            this.Controls.Add(this.modPartMaxBox);
            this.Controls.Add(this.modPartPriceBox);
            this.Controls.Add(this.modPartInvBox);
            this.Controls.Add(this.modPartNameBox);
            this.Controls.Add(this.modPartIDBox);
            this.Controls.Add(this.radioModOutsourced);
            this.Controls.Add(this.radioModInhouse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModPartCancel;
        private System.Windows.Forms.Button btnModPartSave;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioModInhouse;
        public System.Windows.Forms.TextBox modPartMachComBox;
        public System.Windows.Forms.TextBox modPartMinBox;
        public System.Windows.Forms.TextBox modPartMaxBox;
        public System.Windows.Forms.TextBox modPartInvBox;
        public System.Windows.Forms.TextBox modPartIDBox;
        public System.Windows.Forms.TextBox modPartNameBox;
        public System.Windows.Forms.TextBox modPartPriceBox;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.RadioButton radioModOutsourced;
    }
}