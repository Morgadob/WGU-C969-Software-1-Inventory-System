namespace BrandonMorgadoInventoryManagementSystem
{
    partial class ModifyProductForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelModPartsAss = new System.Windows.Forms.Label();
            this.modifyProductGrid2 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.modifyProductGrid1 = new System.Windows.Forms.DataGridView();
            this.searchBoxModProd = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelModAllParts = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.modProdMin = new System.Windows.Forms.TextBox();
            this.modProdMax = new System.Windows.Forms.TextBox();
            this.modProdPrice = new System.Windows.Forms.TextBox();
            this.modProdInv = new System.Windows.Forms.TextBox();
            this.modProdName = new System.Windows.Forms.TextBox();
            this.modProdID = new System.Windows.Forms.TextBox();
            this.labelModifyProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(630, 346);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 28);
            this.buttonDelete.TabIndex = 70;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelModPartsAss
            // 
            this.labelModPartsAss.AutoSize = true;
            this.labelModPartsAss.Location = new System.Drawing.Point(288, 219);
            this.labelModPartsAss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModPartsAss.Name = "labelModPartsAss";
            this.labelModPartsAss.Size = new System.Drawing.Size(167, 13);
            this.labelModPartsAss.TabIndex = 69;
            this.labelModPartsAss.Text = "Parts Associated with this Product";
            // 
            // modifyProductGrid2
            // 
            this.modifyProductGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modifyProductGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.modifyProductGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductGrid2.Location = new System.Drawing.Point(291, 247);
            this.modifyProductGrid2.Margin = new System.Windows.Forms.Padding(2);
            this.modifyProductGrid2.Name = "modifyProductGrid2";
            this.modifyProductGrid2.RowHeadersVisible = false;
            this.modifyProductGrid2.RowTemplate.Height = 28;
            this.modifyProductGrid2.Size = new System.Drawing.Size(323, 127);
            this.modifyProductGrid2.TabIndex = 68;
            this.modifyProductGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyProductGrid2_CellClick);
            this.modifyProductGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyProductGrid2_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(630, 175);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 28);
            this.buttonAdd.TabIndex = 67;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // modifyProductGrid1
            // 
            this.modifyProductGrid1.AllowUserToAddRows = false;
            this.modifyProductGrid1.AllowUserToDeleteRows = false;
            this.modifyProductGrid1.AllowUserToResizeColumns = false;
            this.modifyProductGrid1.AllowUserToResizeRows = false;
            this.modifyProductGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modifyProductGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.modifyProductGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductGrid1.Location = new System.Drawing.Point(290, 69);
            this.modifyProductGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.modifyProductGrid1.Name = "modifyProductGrid1";
            this.modifyProductGrid1.RowHeadersVisible = false;
            this.modifyProductGrid1.RowTemplate.Height = 28;
            this.modifyProductGrid1.Size = new System.Drawing.Size(324, 134);
            this.modifyProductGrid1.TabIndex = 66;
            this.modifyProductGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyProductGrid1_CellClick);
            this.modifyProductGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyProductGrid1_CellContentClick);
            this.modifyProductGrid1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.modifyProductGrid1_DataBindingComplete);
            // 
            // searchBoxModProd
            // 
            this.searchBoxModProd.Location = new System.Drawing.Point(488, 42);
            this.searchBoxModProd.Margin = new System.Windows.Forms.Padding(2);
            this.searchBoxModProd.Name = "searchBoxModProd";
            this.searchBoxModProd.Size = new System.Drawing.Size(126, 20);
            this.searchBoxModProd.TabIndex = 65;
            this.searchBoxModProd.TextChanged += new System.EventHandler(this.searchBoxModProd_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(426, 40);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 21);
            this.buttonSearch.TabIndex = 64;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelModAllParts
            // 
            this.labelModAllParts.AutoSize = true;
            this.labelModAllParts.Location = new System.Drawing.Point(287, 42);
            this.labelModAllParts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModAllParts.Name = "labelModAllParts";
            this.labelModAllParts.Size = new System.Drawing.Size(45, 13);
            this.labelModAllParts.TabIndex = 63;
            this.labelModAllParts.Text = "All Parts";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(564, 396);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 28);
            this.buttonCancel.TabIndex = 62;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(497, 396);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 28);
            this.buttonSave.TabIndex = 61;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(78, 256);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 60;
            this.labelPrice.Text = "Price";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(63, 225);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 59;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(78, 193);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 58;
            this.labelName.Text = "Name";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(68, 284);
            this.labelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 57;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(171, 284);
            this.labelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 56;
            this.labelMin.Text = "Min";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(85, 160);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 55;
            this.labelID.Text = "ID";
            // 
            // modProdMin
            // 
            this.modProdMin.BackColor = System.Drawing.Color.Salmon;
            this.modProdMin.Location = new System.Drawing.Point(198, 282);
            this.modProdMin.Margin = new System.Windows.Forms.Padding(2);
            this.modProdMin.Name = "modProdMin";
            this.modProdMin.Size = new System.Drawing.Size(63, 20);
            this.modProdMin.TabIndex = 54;
            this.modProdMin.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // modProdMax
            // 
            this.modProdMax.BackColor = System.Drawing.Color.Salmon;
            this.modProdMax.Location = new System.Drawing.Point(97, 282);
            this.modProdMax.Margin = new System.Windows.Forms.Padding(2);
            this.modProdMax.Name = "modProdMax";
            this.modProdMax.Size = new System.Drawing.Size(63, 20);
            this.modProdMax.TabIndex = 53;
            this.modProdMax.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // modProdPrice
            // 
            this.modProdPrice.BackColor = System.Drawing.Color.Salmon;
            this.modProdPrice.Location = new System.Drawing.Point(116, 254);
            this.modProdPrice.Margin = new System.Windows.Forms.Padding(2);
            this.modProdPrice.Name = "modProdPrice";
            this.modProdPrice.Size = new System.Drawing.Size(111, 20);
            this.modProdPrice.TabIndex = 52;
            this.modProdPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // modProdInv
            // 
            this.modProdInv.BackColor = System.Drawing.Color.Salmon;
            this.modProdInv.Location = new System.Drawing.Point(116, 223);
            this.modProdInv.Margin = new System.Windows.Forms.Padding(2);
            this.modProdInv.Name = "modProdInv";
            this.modProdInv.Size = new System.Drawing.Size(111, 20);
            this.modProdInv.TabIndex = 51;
            this.modProdInv.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // modProdName
            // 
            this.modProdName.BackColor = System.Drawing.Color.Salmon;
            this.modProdName.Location = new System.Drawing.Point(116, 191);
            this.modProdName.Margin = new System.Windows.Forms.Padding(2);
            this.modProdName.Name = "modProdName";
            this.modProdName.Size = new System.Drawing.Size(111, 20);
            this.modProdName.TabIndex = 50;
            this.modProdName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // modProdID
            // 
            this.modProdID.Enabled = false;
            this.modProdID.Location = new System.Drawing.Point(116, 160);
            this.modProdID.Margin = new System.Windows.Forms.Padding(2);
            this.modProdID.Name = "modProdID";
            this.modProdID.Size = new System.Drawing.Size(111, 20);
            this.modProdID.TabIndex = 49;
            this.modProdID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelModifyProducts
            // 
            this.labelModifyProducts.AutoSize = true;
            this.labelModifyProducts.Location = new System.Drawing.Point(31, 29);
            this.labelModifyProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModifyProducts.Name = "labelModifyProducts";
            this.labelModifyProducts.Size = new System.Drawing.Size(78, 13);
            this.labelModifyProducts.TabIndex = 46;
            this.labelModifyProducts.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 466);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelModPartsAss);
            this.Controls.Add(this.modifyProductGrid2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.modifyProductGrid1);
            this.Controls.Add(this.searchBoxModProd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelModAllParts);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.modProdMin);
            this.Controls.Add(this.modProdMax);
            this.Controls.Add(this.modProdPrice);
            this.Controls.Add(this.modProdInv);
            this.Controls.Add(this.modProdName);
            this.Controls.Add(this.modProdID);
            this.Controls.Add(this.labelModifyProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelModPartsAss;
        private System.Windows.Forms.DataGridView modifyProductGrid2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView modifyProductGrid1;
        private System.Windows.Forms.TextBox searchBoxModProd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelModAllParts;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelModifyProducts;
        public System.Windows.Forms.TextBox modProdName;
        public System.Windows.Forms.TextBox modProdMin;
        public System.Windows.Forms.TextBox modProdMax;
        public System.Windows.Forms.TextBox modProdPrice;
        public System.Windows.Forms.TextBox modProdInv;
        public System.Windows.Forms.TextBox modProdID;
    }
}