
namespace C968_Joshua_Cowell
{
    partial class ModifyProduct
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
            this.btnAddProductSearch = new System.Windows.Forms.Button();
            this.txtModifyAddProductSearch = new System.Windows.Forms.TextBox();
            this.btnModifyAddProductSave = new System.Windows.Forms.Button();
            this.btnModifyAddProductCancel = new System.Windows.Forms.Button();
            this.btnModifyDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.btnModifyAddProduct = new System.Windows.Forms.Button();
            this.lblAllParts = new System.Windows.Forms.Label();
            this.lblAssociated = new System.Windows.Forms.Label();
            this.dataviewAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dataviewAddProductCandidate = new System.Windows.Forms.DataGridView();
            this.lblProductMax = new System.Windows.Forms.Label();
            this.txtModifyProductMin = new System.Windows.Forms.TextBox();
            this.txtModifyProductMax = new System.Windows.Forms.TextBox();
            this.lblProductMin = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtModifyProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductInventory = new System.Windows.Forms.Label();
            this.txtModifyProductInventory = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtModifyProductName = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtModifyProductID = new System.Windows.Forms.TextBox();
            this.lblModifyProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAddProductCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProductSearch
            // 
            this.btnAddProductSearch.Location = new System.Drawing.Point(569, 33);
            this.btnAddProductSearch.Name = "btnAddProductSearch";
            this.btnAddProductSearch.Size = new System.Drawing.Size(51, 23);
            this.btnAddProductSearch.TabIndex = 48;
            this.btnAddProductSearch.Text = "Search";
            this.btnAddProductSearch.UseVisualStyleBackColor = true;
            this.btnAddProductSearch.Click += new System.EventHandler(this.btnAddProductSearch_Click);
            // 
            // txtModifyAddProductSearch
            // 
            this.txtModifyAddProductSearch.Location = new System.Drawing.Point(626, 35);
            this.txtModifyAddProductSearch.Name = "txtModifyAddProductSearch";
            this.txtModifyAddProductSearch.Size = new System.Drawing.Size(165, 20);
            this.txtModifyAddProductSearch.TabIndex = 47;
            // 
            // btnModifyAddProductSave
            // 
            this.btnModifyAddProductSave.Location = new System.Drawing.Point(626, 457);
            this.btnModifyAddProductSave.Name = "btnModifyAddProductSave";
            this.btnModifyAddProductSave.Size = new System.Drawing.Size(51, 23);
            this.btnModifyAddProductSave.TabIndex = 46;
            this.btnModifyAddProductSave.Text = "Save";
            this.btnModifyAddProductSave.UseVisualStyleBackColor = true;
            this.btnModifyAddProductSave.Click += new System.EventHandler(this.btnModifyAddProductSave_Click);
            // 
            // btnModifyAddProductCancel
            // 
            this.btnModifyAddProductCancel.Location = new System.Drawing.Point(683, 457);
            this.btnModifyAddProductCancel.Name = "btnModifyAddProductCancel";
            this.btnModifyAddProductCancel.Size = new System.Drawing.Size(51, 23);
            this.btnModifyAddProductCancel.TabIndex = 45;
            this.btnModifyAddProductCancel.Text = "Cancel";
            this.btnModifyAddProductCancel.UseVisualStyleBackColor = true;
            this.btnModifyAddProductCancel.Click += new System.EventHandler(this.btnModifyAddProductCancel_Click);
            // 
            // btnModifyDeleteAssociatedPart
            // 
            this.btnModifyDeleteAssociatedPart.Location = new System.Drawing.Point(740, 457);
            this.btnModifyDeleteAssociatedPart.Name = "btnModifyDeleteAssociatedPart";
            this.btnModifyDeleteAssociatedPart.Size = new System.Drawing.Size(51, 23);
            this.btnModifyDeleteAssociatedPart.TabIndex = 44;
            this.btnModifyDeleteAssociatedPart.Text = "Delete";
            this.btnModifyDeleteAssociatedPart.UseVisualStyleBackColor = true;
            this.btnModifyDeleteAssociatedPart.Click += new System.EventHandler(this.btnModifyDeleteAssociatedPart_Click);
            // 
            // btnModifyAddProduct
            // 
            this.btnModifyAddProduct.Location = new System.Drawing.Point(740, 241);
            this.btnModifyAddProduct.Name = "btnModifyAddProduct";
            this.btnModifyAddProduct.Size = new System.Drawing.Size(51, 23);
            this.btnModifyAddProduct.TabIndex = 43;
            this.btnModifyAddProduct.Text = "Add";
            this.btnModifyAddProduct.UseVisualStyleBackColor = true;
            this.btnModifyAddProduct.Click += new System.EventHandler(this.btnModifyAddProduct_Click);
            // 
            // lblAllParts
            // 
            this.lblAllParts.AutoSize = true;
            this.lblAllParts.Location = new System.Drawing.Point(288, 54);
            this.lblAllParts.Name = "lblAllParts";
            this.lblAllParts.Size = new System.Drawing.Size(95, 13);
            this.lblAllParts.TabIndex = 42;
            this.lblAllParts.Text = "All candidate Parts";
            // 
            // lblAssociated
            // 
            this.lblAssociated.AutoSize = true;
            this.lblAssociated.Location = new System.Drawing.Point(288, 261);
            this.lblAssociated.Name = "lblAssociated";
            this.lblAssociated.Size = new System.Drawing.Size(167, 13);
            this.lblAssociated.TabIndex = 41;
            this.lblAssociated.Text = "Parts Associated with this Product";
            // 
            // dataviewAssociatedParts
            // 
            this.dataviewAssociatedParts.AllowUserToAddRows = false;
            this.dataviewAssociatedParts.AllowUserToDeleteRows = false;
            this.dataviewAssociatedParts.AllowUserToOrderColumns = true;
            this.dataviewAssociatedParts.AllowUserToResizeColumns = false;
            this.dataviewAssociatedParts.AllowUserToResizeRows = false;
            this.dataviewAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAssociatedParts.Location = new System.Drawing.Point(291, 277);
            this.dataviewAssociatedParts.MultiSelect = false;
            this.dataviewAssociatedParts.Name = "dataviewAssociatedParts";
            this.dataviewAssociatedParts.ReadOnly = true;
            this.dataviewAssociatedParts.RowHeadersVisible = false;
            this.dataviewAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataviewAssociatedParts.Size = new System.Drawing.Size(500, 162);
            this.dataviewAssociatedParts.TabIndex = 40;
            // 
            // dataviewAddProductCandidate
            // 
            this.dataviewAddProductCandidate.AllowUserToAddRows = false;
            this.dataviewAddProductCandidate.AllowUserToDeleteRows = false;
            this.dataviewAddProductCandidate.AllowUserToResizeColumns = false;
            this.dataviewAddProductCandidate.AllowUserToResizeRows = false;
            this.dataviewAddProductCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAddProductCandidate.Location = new System.Drawing.Point(291, 70);
            this.dataviewAddProductCandidate.MultiSelect = false;
            this.dataviewAddProductCandidate.Name = "dataviewAddProductCandidate";
            this.dataviewAddProductCandidate.ReadOnly = true;
            this.dataviewAddProductCandidate.RowHeadersVisible = false;
            this.dataviewAddProductCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataviewAddProductCandidate.Size = new System.Drawing.Size(500, 162);
            this.dataviewAddProductCandidate.TabIndex = 39;
            // 
            // lblProductMax
            // 
            this.lblProductMax.AutoSize = true;
            this.lblProductMax.Location = new System.Drawing.Point(20, 338);
            this.lblProductMax.Name = "lblProductMax";
            this.lblProductMax.Size = new System.Drawing.Size(27, 13);
            this.lblProductMax.TabIndex = 38;
            this.lblProductMax.Text = "Max";
            // 
            // txtModifyProductMin
            // 
            this.txtModifyProductMin.BackColor = System.Drawing.Color.White;
            this.txtModifyProductMin.Location = new System.Drawing.Point(165, 335);
            this.txtModifyProductMin.Name = "txtModifyProductMin";
            this.txtModifyProductMin.Size = new System.Drawing.Size(41, 20);
            this.txtModifyProductMin.TabIndex = 37;
            // 
            // txtModifyProductMax
            // 
            this.txtModifyProductMax.BackColor = System.Drawing.Color.White;
            this.txtModifyProductMax.Location = new System.Drawing.Point(53, 335);
            this.txtModifyProductMax.Name = "txtModifyProductMax";
            this.txtModifyProductMax.Size = new System.Drawing.Size(41, 20);
            this.txtModifyProductMax.TabIndex = 36;
            // 
            // lblProductMin
            // 
            this.lblProductMin.AutoSize = true;
            this.lblProductMin.Location = new System.Drawing.Point(128, 338);
            this.lblProductMin.Name = "lblProductMin";
            this.lblProductMin.Size = new System.Drawing.Size(24, 13);
            this.lblProductMin.TabIndex = 35;
            this.lblProductMin.Text = "Min";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(16, 291);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(31, 13);
            this.lblProductPrice.TabIndex = 34;
            this.lblProductPrice.Text = "Price";
            // 
            // txtModifyProductPrice
            // 
            this.txtModifyProductPrice.BackColor = System.Drawing.Color.White;
            this.txtModifyProductPrice.Location = new System.Drawing.Point(88, 288);
            this.txtModifyProductPrice.Name = "txtModifyProductPrice";
            this.txtModifyProductPrice.Size = new System.Drawing.Size(118, 20);
            this.txtModifyProductPrice.TabIndex = 33;
            // 
            // lblProductInventory
            // 
            this.lblProductInventory.AutoSize = true;
            this.lblProductInventory.Location = new System.Drawing.Point(16, 246);
            this.lblProductInventory.Name = "lblProductInventory";
            this.lblProductInventory.Size = new System.Drawing.Size(51, 13);
            this.lblProductInventory.TabIndex = 32;
            this.lblProductInventory.Text = "Inventory";
            // 
            // txtModifyProductInventory
            // 
            this.txtModifyProductInventory.BackColor = System.Drawing.Color.White;
            this.txtModifyProductInventory.Location = new System.Drawing.Point(88, 243);
            this.txtModifyProductInventory.Name = "txtModifyProductInventory";
            this.txtModifyProductInventory.Size = new System.Drawing.Size(118, 20);
            this.txtModifyProductInventory.TabIndex = 31;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(16, 206);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(35, 13);
            this.lblProductName.TabIndex = 30;
            this.lblProductName.Text = "Name";
            // 
            // txtModifyProductName
            // 
            this.txtModifyProductName.BackColor = System.Drawing.Color.White;
            this.txtModifyProductName.Location = new System.Drawing.Point(88, 203);
            this.txtModifyProductName.Name = "txtModifyProductName";
            this.txtModifyProductName.Size = new System.Drawing.Size(118, 20);
            this.txtModifyProductName.TabIndex = 29;
            this.txtModifyProductName.TextChanged += new System.EventHandler(this.txtModifyProductName_TextChanged);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(16, 162);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 28;
            this.lblProductID.Text = "ID";
            // 
            // txtModifyProductID
            // 
            this.txtModifyProductID.Enabled = false;
            this.txtModifyProductID.Location = new System.Drawing.Point(88, 159);
            this.txtModifyProductID.Name = "txtModifyProductID";
            this.txtModifyProductID.ReadOnly = true;
            this.txtModifyProductID.Size = new System.Drawing.Size(118, 20);
            this.txtModifyProductID.TabIndex = 27;
            // 
            // lblModifyProductTitle
            // 
            this.lblModifyProductTitle.AutoSize = true;
            this.lblModifyProductTitle.Location = new System.Drawing.Point(16, 13);
            this.lblModifyProductTitle.Name = "lblModifyProductTitle";
            this.lblModifyProductTitle.Size = new System.Drawing.Size(78, 13);
            this.lblModifyProductTitle.TabIndex = 26;
            this.lblModifyProductTitle.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.btnAddProductSearch);
            this.Controls.Add(this.txtModifyAddProductSearch);
            this.Controls.Add(this.btnModifyAddProductSave);
            this.Controls.Add(this.btnModifyAddProductCancel);
            this.Controls.Add(this.btnModifyDeleteAssociatedPart);
            this.Controls.Add(this.btnModifyAddProduct);
            this.Controls.Add(this.lblAllParts);
            this.Controls.Add(this.lblAssociated);
            this.Controls.Add(this.dataviewAssociatedParts);
            this.Controls.Add(this.dataviewAddProductCandidate);
            this.Controls.Add(this.lblProductMax);
            this.Controls.Add(this.txtModifyProductMin);
            this.Controls.Add(this.txtModifyProductMax);
            this.Controls.Add(this.lblProductMin);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.txtModifyProductPrice);
            this.Controls.Add(this.lblProductInventory);
            this.Controls.Add(this.txtModifyProductInventory);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtModifyProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtModifyProductID);
            this.Controls.Add(this.lblModifyProductTitle);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAddProductCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProductSearch;
        private System.Windows.Forms.TextBox txtModifyAddProductSearch;
        private System.Windows.Forms.Button btnModifyAddProductSave;
        private System.Windows.Forms.Button btnModifyAddProductCancel;
        private System.Windows.Forms.Button btnModifyDeleteAssociatedPart;
        private System.Windows.Forms.Button btnModifyAddProduct;
        private System.Windows.Forms.Label lblAllParts;
        private System.Windows.Forms.Label lblAssociated;
        private System.Windows.Forms.DataGridView dataviewAssociatedParts;
        private System.Windows.Forms.DataGridView dataviewAddProductCandidate;
        private System.Windows.Forms.Label lblProductMax;
        private System.Windows.Forms.TextBox txtModifyProductMin;
        private System.Windows.Forms.TextBox txtModifyProductMax;
        private System.Windows.Forms.Label lblProductMin;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtModifyProductPrice;
        private System.Windows.Forms.Label lblProductInventory;
        private System.Windows.Forms.TextBox txtModifyProductInventory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtModifyProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtModifyProductID;
        private System.Windows.Forms.Label lblModifyProductTitle;
    }
}