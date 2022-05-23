
namespace C968_Joshua_Cowell
{
    partial class AddProduct
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
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductInventory = new System.Windows.Forms.Label();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductMin = new System.Windows.Forms.Label();
            this.txtProductMax = new System.Windows.Forms.TextBox();
            this.txtProductMin = new System.Windows.Forms.TextBox();
            this.lblProductMax = new System.Windows.Forms.Label();
            this.dataviewAddProductCandidate = new System.Windows.Forms.DataGridView();
            this.dataviewAssociatedParts = new System.Windows.Forms.DataGridView();
            this.lblAssociated = new System.Windows.Forms.Label();
            this.lblAllParts = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.btnAddProductCancel = new System.Windows.Forms.Button();
            this.btnAddProductSave = new System.Windows.Forms.Button();
            this.txtAddProductSearch = new System.Windows.Forms.TextBox();
            this.btnAddProductSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAddProductCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(13, 13);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(66, 13);
            this.lblProductTitle.TabIndex = 0;
            this.lblProductTitle.Text = "Add Product";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(85, 159);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(118, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(13, 162);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "ID";
            this.lblProductID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(13, 206);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(35, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductName.Location = new System.Drawing.Point(85, 203);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(118, 20);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProductInventory
            // 
            this.lblProductInventory.AutoSize = true;
            this.lblProductInventory.Location = new System.Drawing.Point(13, 246);
            this.lblProductInventory.Name = "lblProductInventory";
            this.lblProductInventory.Size = new System.Drawing.Size(51, 13);
            this.lblProductInventory.TabIndex = 6;
            this.lblProductInventory.Text = "Inventory";
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductInventory.Location = new System.Drawing.Point(85, 243);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(118, 20);
            this.txtProductInventory.TabIndex = 5;
            this.txtProductInventory.TextChanged += new System.EventHandler(this.txtProductInventory_TextChanged);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(13, 291);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(31, 13);
            this.lblProductPrice.TabIndex = 8;
            this.lblProductPrice.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductPrice.Location = new System.Drawing.Point(85, 288);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(118, 20);
            this.txtProductPrice.TabIndex = 7;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // lblProductMin
            // 
            this.lblProductMin.AutoSize = true;
            this.lblProductMin.Location = new System.Drawing.Point(125, 338);
            this.lblProductMin.Name = "lblProductMin";
            this.lblProductMin.Size = new System.Drawing.Size(24, 13);
            this.lblProductMin.TabIndex = 10;
            this.lblProductMin.Text = "Min";
            // 
            // txtProductMax
            // 
            this.txtProductMax.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductMax.Location = new System.Drawing.Point(50, 335);
            this.txtProductMax.Name = "txtProductMax";
            this.txtProductMax.Size = new System.Drawing.Size(41, 20);
            this.txtProductMax.TabIndex = 11;
            this.txtProductMax.TextChanged += new System.EventHandler(this.txtProductMax_TextChanged);
            // 
            // txtProductMin
            // 
            this.txtProductMin.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductMin.Location = new System.Drawing.Point(162, 335);
            this.txtProductMin.Name = "txtProductMin";
            this.txtProductMin.Size = new System.Drawing.Size(41, 20);
            this.txtProductMin.TabIndex = 12;
            this.txtProductMin.TextChanged += new System.EventHandler(this.txtProductMin_TextChanged);
            // 
            // lblProductMax
            // 
            this.lblProductMax.AutoSize = true;
            this.lblProductMax.Location = new System.Drawing.Point(17, 338);
            this.lblProductMax.Name = "lblProductMax";
            this.lblProductMax.Size = new System.Drawing.Size(27, 13);
            this.lblProductMax.TabIndex = 13;
            this.lblProductMax.Text = "Max";
            // 
            // dataviewAddProductCandidate
            // 
            this.dataviewAddProductCandidate.AllowUserToAddRows = false;
            this.dataviewAddProductCandidate.AllowUserToDeleteRows = false;
            this.dataviewAddProductCandidate.AllowUserToResizeColumns = false;
            this.dataviewAddProductCandidate.AllowUserToResizeRows = false;
            this.dataviewAddProductCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAddProductCandidate.Location = new System.Drawing.Point(288, 70);
            this.dataviewAddProductCandidate.MultiSelect = false;
            this.dataviewAddProductCandidate.Name = "dataviewAddProductCandidate";
            this.dataviewAddProductCandidate.ReadOnly = true;
            this.dataviewAddProductCandidate.RowHeadersVisible = false;
            this.dataviewAddProductCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataviewAddProductCandidate.Size = new System.Drawing.Size(500, 162);
            this.dataviewAddProductCandidate.TabIndex = 16;
            this.dataviewAddProductCandidate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewAddProductCandidate_CellContentClick);
            // 
            // dataviewAssociatedParts
            // 
            this.dataviewAssociatedParts.AllowUserToAddRows = false;
            this.dataviewAssociatedParts.AllowUserToDeleteRows = false;
            this.dataviewAssociatedParts.AllowUserToResizeColumns = false;
            this.dataviewAssociatedParts.AllowUserToResizeRows = false;
            this.dataviewAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAssociatedParts.Location = new System.Drawing.Point(288, 277);
            this.dataviewAssociatedParts.MultiSelect = false;
            this.dataviewAssociatedParts.Name = "dataviewAssociatedParts";
            this.dataviewAssociatedParts.ReadOnly = true;
            this.dataviewAssociatedParts.RowHeadersVisible = false;
            this.dataviewAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataviewAssociatedParts.Size = new System.Drawing.Size(500, 162);
            this.dataviewAssociatedParts.TabIndex = 17;
            // 
            // lblAssociated
            // 
            this.lblAssociated.AutoSize = true;
            this.lblAssociated.Location = new System.Drawing.Point(285, 261);
            this.lblAssociated.Name = "lblAssociated";
            this.lblAssociated.Size = new System.Drawing.Size(167, 13);
            this.lblAssociated.TabIndex = 18;
            this.lblAssociated.Text = "Parts Associated with this Product";
            this.lblAssociated.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblAllParts
            // 
            this.lblAllParts.AutoSize = true;
            this.lblAllParts.Location = new System.Drawing.Point(285, 54);
            this.lblAllParts.Name = "lblAllParts";
            this.lblAllParts.Size = new System.Drawing.Size(95, 13);
            this.lblAllParts.TabIndex = 19;
            this.lblAllParts.Text = "All candidate Parts";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(737, 241);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(51, 23);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteAssociatedPart
            // 
            this.btnDeleteAssociatedPart.Location = new System.Drawing.Point(737, 457);
            this.btnDeleteAssociatedPart.Name = "btnDeleteAssociatedPart";
            this.btnDeleteAssociatedPart.Size = new System.Drawing.Size(51, 23);
            this.btnDeleteAssociatedPart.TabIndex = 21;
            this.btnDeleteAssociatedPart.Text = "Delete";
            this.btnDeleteAssociatedPart.UseVisualStyleBackColor = true;
            this.btnDeleteAssociatedPart.Click += new System.EventHandler(this.btnDeleteAssociatedPart_Click);
            // 
            // btnAddProductCancel
            // 
            this.btnAddProductCancel.Location = new System.Drawing.Point(680, 457);
            this.btnAddProductCancel.Name = "btnAddProductCancel";
            this.btnAddProductCancel.Size = new System.Drawing.Size(51, 23);
            this.btnAddProductCancel.TabIndex = 22;
            this.btnAddProductCancel.Text = "Cancel";
            this.btnAddProductCancel.UseVisualStyleBackColor = true;
            this.btnAddProductCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddProductSave
            // 
            this.btnAddProductSave.Location = new System.Drawing.Point(623, 457);
            this.btnAddProductSave.Name = "btnAddProductSave";
            this.btnAddProductSave.Size = new System.Drawing.Size(51, 23);
            this.btnAddProductSave.TabIndex = 23;
            this.btnAddProductSave.Text = "Save";
            this.btnAddProductSave.UseVisualStyleBackColor = true;
            this.btnAddProductSave.Click += new System.EventHandler(this.btnSaveAd_Click);
            // 
            // txtAddProductSearch
            // 
            this.txtAddProductSearch.Location = new System.Drawing.Point(623, 34);
            this.txtAddProductSearch.Name = "txtAddProductSearch";
            this.txtAddProductSearch.Size = new System.Drawing.Size(165, 20);
            this.txtAddProductSearch.TabIndex = 24;
            this.txtAddProductSearch.TextChanged += new System.EventHandler(this.txtAddProductSearch_TextChanged);
            // 
            // btnAddProductSearch
            // 
            this.btnAddProductSearch.Location = new System.Drawing.Point(566, 32);
            this.btnAddProductSearch.Name = "btnAddProductSearch";
            this.btnAddProductSearch.Size = new System.Drawing.Size(51, 23);
            this.btnAddProductSearch.TabIndex = 25;
            this.btnAddProductSearch.Text = "Search";
            this.btnAddProductSearch.UseVisualStyleBackColor = true;
            this.btnAddProductSearch.Click += new System.EventHandler(this.btnAddProductSearch_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.btnAddProductSearch);
            this.Controls.Add(this.txtAddProductSearch);
            this.Controls.Add(this.btnAddProductSave);
            this.Controls.Add(this.btnAddProductCancel);
            this.Controls.Add(this.btnDeleteAssociatedPart);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblAllParts);
            this.Controls.Add(this.lblAssociated);
            this.Controls.Add(this.dataviewAssociatedParts);
            this.Controls.Add(this.dataviewAddProductCandidate);
            this.Controls.Add(this.lblProductMax);
            this.Controls.Add(this.txtProductMin);
            this.Controls.Add(this.txtProductMax);
            this.Controls.Add(this.lblProductMin);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductInventory);
            this.Controls.Add(this.txtProductInventory);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductTitle);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAddProductCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductInventory;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductMin;
        private System.Windows.Forms.TextBox txtProductMax;
        private System.Windows.Forms.TextBox txtProductMin;
        private System.Windows.Forms.Label lblProductMax;
        private System.Windows.Forms.DataGridView dataviewAddProductCandidate;
        private System.Windows.Forms.DataGridView dataviewAssociatedParts;
        private System.Windows.Forms.Label lblAssociated;
        private System.Windows.Forms.Label lblAllParts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteAssociatedPart;
        private System.Windows.Forms.Button btnAddProductCancel;
        private System.Windows.Forms.Button btnAddProductSave;
        private System.Windows.Forms.TextBox txtAddProductSearch;
        private System.Windows.Forms.Button btnAddProductSearch;
    }
}