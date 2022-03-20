namespace BrandonMorgadoInventoryManagementSystem
{
    partial class AddProductForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.addProdMin = new System.Windows.Forms.TextBox();
            this.addProdMax = new System.Windows.Forms.TextBox();
            this.addProdPrice = new System.Windows.Forms.TextBox();
            this.addProdInv = new System.Windows.Forms.TextBox();
            this.addProdName = new System.Windows.Forms.TextBox();
            this.addProdID = new System.Windows.Forms.TextBox();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.labelAllPart = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchBoxAddProd = new System.Windows.Forms.TextBox();
            this.addProductGrid1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.addProductGrid2 = new System.Windows.Forms.DataGridView();
            this.labelPartsAss = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(583, 431);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 28);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(515, 431);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 28);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(39, 272);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(63, 13);
            this.labelPrice.TabIndex = 34;
            this.labelPrice.Text = "Price / Cost";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(49, 241);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 33;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 209);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Name";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(55, 300);
            this.labelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 31;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(158, 300);
            this.labelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 30;
            this.labelMin.Text = "Min";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(72, 176);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 29;
            this.labelID.Text = "ID";
            // 
            // addProdMin
            // 
            this.addProdMin.BackColor = System.Drawing.Color.Salmon;
            this.addProdMin.Location = new System.Drawing.Point(185, 298);
            this.addProdMin.Margin = new System.Windows.Forms.Padding(2);
            this.addProdMin.Name = "addProdMin";
            this.addProdMin.Size = new System.Drawing.Size(63, 20);
            this.addProdMin.TabIndex = 27;
            this.addProdMin.TextChanged += new System.EventHandler(this.addProdMin_TextChanged);
            // 
            // addProdMax
            // 
            this.addProdMax.BackColor = System.Drawing.Color.Salmon;
            this.addProdMax.Location = new System.Drawing.Point(84, 298);
            this.addProdMax.Margin = new System.Windows.Forms.Padding(2);
            this.addProdMax.Name = "addProdMax";
            this.addProdMax.Size = new System.Drawing.Size(63, 20);
            this.addProdMax.TabIndex = 26;
            this.addProdMax.TextChanged += new System.EventHandler(this.addProdMax_TextChanged);
            // 
            // addProdPrice
            // 
            this.addProdPrice.BackColor = System.Drawing.Color.Salmon;
            this.addProdPrice.Location = new System.Drawing.Point(103, 270);
            this.addProdPrice.Margin = new System.Windows.Forms.Padding(2);
            this.addProdPrice.Name = "addProdPrice";
            this.addProdPrice.Size = new System.Drawing.Size(111, 20);
            this.addProdPrice.TabIndex = 25;
            this.addProdPrice.TextChanged += new System.EventHandler(this.addProdPrice_TextChanged);
            // 
            // addProdInv
            // 
            this.addProdInv.BackColor = System.Drawing.Color.Salmon;
            this.addProdInv.Location = new System.Drawing.Point(103, 239);
            this.addProdInv.Margin = new System.Windows.Forms.Padding(2);
            this.addProdInv.Name = "addProdInv";
            this.addProdInv.Size = new System.Drawing.Size(111, 20);
            this.addProdInv.TabIndex = 24;
            this.addProdInv.TextChanged += new System.EventHandler(this.addProdInv_TextChanged);
            // 
            // addProdName
            // 
            this.addProdName.BackColor = System.Drawing.Color.Salmon;
            this.addProdName.Location = new System.Drawing.Point(103, 207);
            this.addProdName.Margin = new System.Windows.Forms.Padding(2);
            this.addProdName.Name = "addProdName";
            this.addProdName.Size = new System.Drawing.Size(111, 20);
            this.addProdName.TabIndex = 23;
            this.addProdName.TextChanged += new System.EventHandler(this.addProdName_TextChanged);
            // 
            // addProdID
            // 
            this.addProdID.Enabled = false;
            this.addProdID.Location = new System.Drawing.Point(103, 176);
            this.addProdID.Margin = new System.Windows.Forms.Padding(2);
            this.addProdID.Name = "addProdID";
            this.addProdID.Size = new System.Drawing.Size(111, 20);
            this.addProdID.TabIndex = 22;
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Location = new System.Drawing.Point(41, 35);
            this.labelAddProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(66, 13);
            this.labelAddProduct.TabIndex = 19;
            this.labelAddProduct.Text = "Add Product";
            this.labelAddProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAllPart
            // 
            this.labelAllPart.AutoSize = true;
            this.labelAllPart.Location = new System.Drawing.Point(298, 48);
            this.labelAllPart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllPart.Name = "labelAllPart";
            this.labelAllPart.Size = new System.Drawing.Size(45, 13);
            this.labelAllPart.TabIndex = 38;
            this.labelAllPart.Text = "All Parts";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(366, 45);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 21);
            this.buttonSearch.TabIndex = 39;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchBoxAddProd
            // 
            this.searchBoxAddProd.Location = new System.Drawing.Point(428, 46);
            this.searchBoxAddProd.Margin = new System.Windows.Forms.Padding(2);
            this.searchBoxAddProd.Name = "searchBoxAddProd";
            this.searchBoxAddProd.Size = new System.Drawing.Size(126, 20);
            this.searchBoxAddProd.TabIndex = 40;
            // 
            // addProductGrid1
            // 
            this.addProductGrid1.AllowUserToAddRows = false;
            this.addProductGrid1.AllowUserToDeleteRows = false;
            this.addProductGrid1.AllowUserToResizeColumns = false;
            this.addProductGrid1.AllowUserToResizeRows = false;
            this.addProductGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.addProductGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGrid1.Location = new System.Drawing.Point(301, 75);
            this.addProductGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.addProductGrid1.Name = "addProductGrid1";
            this.addProductGrid1.RowHeadersVisible = false;
            this.addProductGrid1.RowTemplate.Height = 28;
            this.addProductGrid1.Size = new System.Drawing.Size(327, 144);
            this.addProductGrid1.TabIndex = 41;
            this.addProductGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProductGrid1_CellClick);
            this.addProductGrid1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.addProductGrid1_DataBindingComplete);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(646, 191);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 28);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addProductGrid2
            // 
            this.addProductGrid2.AllowUserToAddRows = false;
            this.addProductGrid2.AllowUserToDeleteRows = false;
            this.addProductGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.addProductGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGrid2.Location = new System.Drawing.Point(301, 265);
            this.addProductGrid2.Margin = new System.Windows.Forms.Padding(2);
            this.addProductGrid2.Name = "addProductGrid2";
            this.addProductGrid2.RowTemplate.Height = 28;
            this.addProductGrid2.Size = new System.Drawing.Size(327, 144);
            this.addProductGrid2.TabIndex = 43;
            this.addProductGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProductGrid2_CellClick);
            // 
            // labelPartsAss
            // 
            this.labelPartsAss.AutoSize = true;
            this.labelPartsAss.Location = new System.Drawing.Point(298, 242);
            this.labelPartsAss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPartsAss.Name = "labelPartsAss";
            this.labelPartsAss.Size = new System.Drawing.Size(167, 13);
            this.labelPartsAss.TabIndex = 44;
            this.labelPartsAss.Text = "Parts Associated with this Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(646, 381);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 28);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 486);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelPartsAss);
            this.Controls.Add(this.addProductGrid2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addProductGrid1);
            this.Controls.Add(this.searchBoxAddProd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelAllPart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.addProdMin);
            this.Controls.Add(this.addProdMax);
            this.Controls.Add(this.addProdPrice);
            this.Controls.Add(this.addProdInv);
            this.Controls.Add(this.addProdName);
            this.Controls.Add(this.addProdID);
            this.Controls.Add(this.labelAddProduct);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox addProdMin;
        private System.Windows.Forms.TextBox addProdMax;
        private System.Windows.Forms.TextBox addProdPrice;
        private System.Windows.Forms.TextBox addProdName;
        private System.Windows.Forms.TextBox addProdID;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelAllPart;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchBoxAddProd;
        private System.Windows.Forms.DataGridView addProductGrid1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView addProductGrid2;
        private System.Windows.Forms.Label labelPartsAss;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox addProdInv;
    }
}