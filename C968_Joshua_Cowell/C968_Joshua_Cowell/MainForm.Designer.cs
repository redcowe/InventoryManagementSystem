
namespace C968_Joshua_Cowell
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnModifyParts = new System.Windows.Forms.Button();
            this.btnDeleteParts = new System.Windows.Forms.Button();
            this.lblParts = new System.Windows.Forms.Label();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnModifyProducts = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtboxSearchParts = new System.Windows.Forms.TextBox();
            this.txtboxSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.dataviewParts = new System.Windows.Forms.DataGridView();
            this.dataviewProducts = new System.Windows.Forms.DataGridView();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(337, 392);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(54, 23);
            this.btnAddParts.TabIndex = 0;
            this.btnAddParts.Text = "Add";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModifyParts
            // 
            this.btnModifyParts.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnModifyParts.Location = new System.Drawing.Point(397, 392);
            this.btnModifyParts.Name = "btnModifyParts";
            this.btnModifyParts.Size = new System.Drawing.Size(54, 23);
            this.btnModifyParts.TabIndex = 1;
            this.btnModifyParts.Text = "Modify";
            this.btnModifyParts.UseVisualStyleBackColor = true;
            this.btnModifyParts.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDeleteParts
            // 
            this.btnDeleteParts.Location = new System.Drawing.Point(457, 392);
            this.btnDeleteParts.Name = "btnDeleteParts";
            this.btnDeleteParts.Size = new System.Drawing.Size(54, 23);
            this.btnDeleteParts.TabIndex = 2;
            this.btnDeleteParts.Text = "Delete";
            this.btnDeleteParts.UseVisualStyleBackColor = true;
            this.btnDeleteParts.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(7, 77);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(51, 24);
            this.lblParts.TabIndex = 4;
            this.lblParts.Text = "Parts";
            this.lblParts.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.Location = new System.Drawing.Point(977, 392);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(54, 23);
            this.btnDeleteProducts.TabIndex = 8;
            this.btnDeleteProducts.Text = "Delete";
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // btnModifyProducts
            // 
            this.btnModifyProducts.Location = new System.Drawing.Point(917, 392);
            this.btnModifyProducts.Name = "btnModifyProducts";
            this.btnModifyProducts.Size = new System.Drawing.Size(54, 23);
            this.btnModifyProducts.TabIndex = 7;
            this.btnModifyProducts.Text = "Modify";
            this.btnModifyProducts.UseVisualStyleBackColor = true;
            this.btnModifyProducts.Click += new System.EventHandler(this.btnModifyProducts_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(857, 392);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(54, 23);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(527, 77);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(84, 24);
            this.lblProducts.TabIndex = 9;
            this.lblProducts.Text = "Products";
            // 
            // txtboxSearchParts
            // 
            this.txtboxSearchParts.Location = new System.Drawing.Point(337, 83);
            this.txtboxSearchParts.Name = "txtboxSearchParts";
            this.txtboxSearchParts.Size = new System.Drawing.Size(174, 20);
            this.txtboxSearchParts.TabIndex = 10;
            this.txtboxSearchParts.TextChanged += new System.EventHandler(this.txtboxSearchParts_TextChanged);
            // 
            // txtboxSearchProducts
            // 
            this.txtboxSearchProducts.Location = new System.Drawing.Point(857, 79);
            this.txtboxSearchProducts.Name = "txtboxSearchProducts";
            this.txtboxSearchProducts.Size = new System.Drawing.Size(174, 20);
            this.txtboxSearchProducts.TabIndex = 11;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(277, 81);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(54, 23);
            this.btnSearchParts.TabIndex = 12;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Location = new System.Drawing.Point(797, 77);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(54, 23);
            this.btnSearchProducts.TabIndex = 13;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
            // 
            // dataviewParts
            // 
            this.dataviewParts.AllowUserToResizeColumns = false;
            this.dataviewParts.AllowUserToResizeRows = false;
            this.dataviewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewParts.Location = new System.Drawing.Point(11, 110);
            this.dataviewParts.MultiSelect = false;
            this.dataviewParts.Name = "dataviewParts";
            this.dataviewParts.ReadOnly = true;
            this.dataviewParts.RowHeadersVisible = false;
            this.dataviewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataviewParts.Size = new System.Drawing.Size(500, 251);
            this.dataviewParts.TabIndex = 14;
            this.dataviewParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dataviewParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataviewProducts
            // 
            this.dataviewProducts.AllowUserToAddRows = false;
            this.dataviewProducts.AllowUserToDeleteRows = false;
            this.dataviewProducts.AllowUserToResizeColumns = false;
            this.dataviewProducts.AllowUserToResizeRows = false;
            this.dataviewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewProducts.Location = new System.Drawing.Point(531, 110);
            this.dataviewProducts.MultiSelect = false;
            this.dataviewProducts.Name = "dataviewProducts";
            this.dataviewProducts.ReadOnly = true;
            this.dataviewProducts.RowHeadersVisible = false;
            this.dataviewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataviewProducts.Size = new System.Drawing.Size(500, 251);
            this.dataviewProducts.TabIndex = 15;
            this.dataviewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(7, 23);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(229, 20);
            this.lblMainTitle.TabIndex = 16;
            this.lblMainTitle.Text = "Inventory Management System";
            this.lblMainTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(977, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataSource = typeof(C968_Joshua_Cowell.Inventory);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(C968_Joshua_Cowell.Inventory);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 523);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.dataviewProducts);
            this.Controls.Add(this.dataviewParts);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.txtboxSearchProducts);
            this.Controls.Add(this.txtboxSearchParts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnDeleteProducts);
            this.Controls.Add(this.btnModifyProducts);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.btnDeleteParts);
            this.Controls.Add(this.btnModifyParts);
            this.Controls.Add(this.btnAddParts);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button btnModifyParts;
        private System.Windows.Forms.Button btnDeleteParts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Button btnDeleteProducts;
        private System.Windows.Forms.Button btnModifyProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtboxSearchParts;
        private System.Windows.Forms.TextBox txtboxSearchProducts;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.Button btnSearchProducts;
        public System.Windows.Forms.DataGridView dataviewParts;
        public System.Windows.Forms.DataGridView dataviewProducts;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
    }
}

