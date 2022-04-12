
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
            this.txtAddProductSearch = new System.Windows.Forms.TextBox();
            this.btnModifyAddProductSave = new System.Windows.Forms.Button();
            this.btnModifyAddProductCancel = new System.Windows.Forms.Button();
            this.btnModifyDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.btnModifyAddProduct = new System.Windows.Forms.Button();
            this.lblAllParts = new System.Windows.Forms.Label();
            this.lblAssociated = new System.Windows.Forms.Label();
            this.dataviewAssociatedParts = new System.Windows.Forms.DataGridView();
            this.columnAssociatedAddProductPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAssociatedAddProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAssociatedAddProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAssociatedAddProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAssociatedAddProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAssociatedAddProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataviewAddProductCandidate = new System.Windows.Forms.DataGridView();
            this.columnAddProductPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsAddProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblModifyProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAddProductCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProductSearch
            // 
            this.btnAddProductSearch.Location = new System.Drawing.Point(569, 32);
            this.btnAddProductSearch.Name = "btnAddProductSearch";
            this.btnAddProductSearch.Size = new System.Drawing.Size(51, 23);
            this.btnAddProductSearch.TabIndex = 48;
            this.btnAddProductSearch.Text = "Search";
            this.btnAddProductSearch.UseVisualStyleBackColor = true;
            // 
            // txtAddProductSearch
            // 
            this.txtAddProductSearch.Location = new System.Drawing.Point(626, 32);
            this.txtAddProductSearch.Name = "txtAddProductSearch";
            this.txtAddProductSearch.Size = new System.Drawing.Size(165, 20);
            this.txtAddProductSearch.TabIndex = 47;
            // 
            // btnModifyAddProductSave
            // 
            this.btnModifyAddProductSave.Location = new System.Drawing.Point(626, 457);
            this.btnModifyAddProductSave.Name = "btnModifyAddProductSave";
            this.btnModifyAddProductSave.Size = new System.Drawing.Size(51, 23);
            this.btnModifyAddProductSave.TabIndex = 46;
            this.btnModifyAddProductSave.Text = "Save";
            this.btnModifyAddProductSave.UseVisualStyleBackColor = true;
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
            // 
            // btnModifyAddProduct
            // 
            this.btnModifyAddProduct.Location = new System.Drawing.Point(740, 241);
            this.btnModifyAddProduct.Name = "btnModifyAddProduct";
            this.btnModifyAddProduct.Size = new System.Drawing.Size(51, 23);
            this.btnModifyAddProduct.TabIndex = 43;
            this.btnModifyAddProduct.Text = "Add";
            this.btnModifyAddProduct.UseVisualStyleBackColor = true;
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
            this.dataviewAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAssociatedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAssociatedAddProductPartID,
            this.columnAssociatedAddProductName,
            this.columnAssociatedAddProductInventory,
            this.columnAssociatedAddProductPrice,
            this.columnAssociatedAddProductMin,
            this.columnAssociatedAddProductMax});
            this.dataviewAssociatedParts.Location = new System.Drawing.Point(291, 277);
            this.dataviewAssociatedParts.Name = "dataviewAssociatedParts";
            this.dataviewAssociatedParts.RowHeadersVisible = false;
            this.dataviewAssociatedParts.Size = new System.Drawing.Size(500, 162);
            this.dataviewAssociatedParts.TabIndex = 40;
            // 
            // columnAssociatedAddProductPartID
            // 
            this.columnAssociatedAddProductPartID.Frozen = true;
            this.columnAssociatedAddProductPartID.HeaderText = "Part ID";
            this.columnAssociatedAddProductPartID.Name = "columnAssociatedAddProductPartID";
            this.columnAssociatedAddProductPartID.ReadOnly = true;
            // 
            // columnAssociatedAddProductName
            // 
            this.columnAssociatedAddProductName.Frozen = true;
            this.columnAssociatedAddProductName.HeaderText = "Name";
            this.columnAssociatedAddProductName.Name = "columnAssociatedAddProductName";
            this.columnAssociatedAddProductName.ReadOnly = true;
            // 
            // columnAssociatedAddProductInventory
            // 
            this.columnAssociatedAddProductInventory.Frozen = true;
            this.columnAssociatedAddProductInventory.HeaderText = "Inventory";
            this.columnAssociatedAddProductInventory.Name = "columnAssociatedAddProductInventory";
            this.columnAssociatedAddProductInventory.ReadOnly = true;
            // 
            // columnAssociatedAddProductPrice
            // 
            this.columnAssociatedAddProductPrice.Frozen = true;
            this.columnAssociatedAddProductPrice.HeaderText = "Price";
            this.columnAssociatedAddProductPrice.Name = "columnAssociatedAddProductPrice";
            this.columnAssociatedAddProductPrice.ReadOnly = true;
            // 
            // columnAssociatedAddProductMin
            // 
            this.columnAssociatedAddProductMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnAssociatedAddProductMin.Frozen = true;
            this.columnAssociatedAddProductMin.HeaderText = "Min";
            this.columnAssociatedAddProductMin.Name = "columnAssociatedAddProductMin";
            this.columnAssociatedAddProductMin.ReadOnly = true;
            this.columnAssociatedAddProductMin.Width = 49;
            // 
            // columnAssociatedAddProductMax
            // 
            this.columnAssociatedAddProductMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnAssociatedAddProductMax.Frozen = true;
            this.columnAssociatedAddProductMax.HeaderText = "Max";
            this.columnAssociatedAddProductMax.Name = "columnAssociatedAddProductMax";
            this.columnAssociatedAddProductMax.ReadOnly = true;
            this.columnAssociatedAddProductMax.Width = 52;
            // 
            // dataviewAddProductCandidate
            // 
            this.dataviewAddProductCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAddProductCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAddProductPartID,
            this.columnsAddProductName,
            this.columnAddProductInventory,
            this.columnAddProductPrice,
            this.columnAddProductMin,
            this.columnAddProductMax});
            this.dataviewAddProductCandidate.Location = new System.Drawing.Point(291, 70);
            this.dataviewAddProductCandidate.Name = "dataviewAddProductCandidate";
            this.dataviewAddProductCandidate.RowHeadersVisible = false;
            this.dataviewAddProductCandidate.Size = new System.Drawing.Size(500, 162);
            this.dataviewAddProductCandidate.TabIndex = 39;
            // 
            // columnAddProductPartID
            // 
            this.columnAddProductPartID.Frozen = true;
            this.columnAddProductPartID.HeaderText = "Part ID";
            this.columnAddProductPartID.Name = "columnAddProductPartID";
            this.columnAddProductPartID.ReadOnly = true;
            // 
            // columnsAddProductName
            // 
            this.columnsAddProductName.Frozen = true;
            this.columnsAddProductName.HeaderText = "Name";
            this.columnsAddProductName.Name = "columnsAddProductName";
            this.columnsAddProductName.ReadOnly = true;
            // 
            // columnAddProductInventory
            // 
            this.columnAddProductInventory.Frozen = true;
            this.columnAddProductInventory.HeaderText = "Inventory";
            this.columnAddProductInventory.Name = "columnAddProductInventory";
            this.columnAddProductInventory.ReadOnly = true;
            // 
            // columnAddProductPrice
            // 
            this.columnAddProductPrice.Frozen = true;
            this.columnAddProductPrice.HeaderText = "Price";
            this.columnAddProductPrice.Name = "columnAddProductPrice";
            this.columnAddProductPrice.ReadOnly = true;
            // 
            // columnAddProductMin
            // 
            this.columnAddProductMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnAddProductMin.Frozen = true;
            this.columnAddProductMin.HeaderText = "Min";
            this.columnAddProductMin.Name = "columnAddProductMin";
            this.columnAddProductMin.ReadOnly = true;
            this.columnAddProductMin.Width = 49;
            // 
            // columnAddProductMax
            // 
            this.columnAddProductMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnAddProductMax.Frozen = true;
            this.columnAddProductMax.HeaderText = "Max";
            this.columnAddProductMax.Name = "columnAddProductMax";
            this.columnAddProductMax.ReadOnly = true;
            this.columnAddProductMax.Width = 52;
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
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(88, 159);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(118, 20);
            this.txtProductID.TabIndex = 27;
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
            this.Controls.Add(this.txtAddProductSearch);
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
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblModifyProductTitle);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAddProductCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProductSearch;
        private System.Windows.Forms.TextBox txtAddProductSearch;
        private System.Windows.Forms.Button btnModifyAddProductSave;
        private System.Windows.Forms.Button btnModifyAddProductCancel;
        private System.Windows.Forms.Button btnModifyDeleteAssociatedPart;
        private System.Windows.Forms.Button btnModifyAddProduct;
        private System.Windows.Forms.Label lblAllParts;
        private System.Windows.Forms.Label lblAssociated;
        private System.Windows.Forms.DataGridView dataviewAssociatedParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAssociatedAddProductPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAssociatedAddProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAssociatedAddProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAssociatedAddProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAssociatedAddProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAssociatedAddProductMax;
        private System.Windows.Forms.DataGridView dataviewAddProductCandidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddProductPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsAddProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddProductMax;
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
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblModifyProductTitle;
    }
}