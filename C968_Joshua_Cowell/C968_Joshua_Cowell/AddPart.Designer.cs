
namespace C968_Joshua_Cowell
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
            this.rdbtnPartsInHouse = new System.Windows.Forms.RadioButton();
            this.rdbtnPartsOutsourced = new System.Windows.Forms.RadioButton();
            this.lblModifyPart = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.lblPartID = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblPartInventory = new System.Windows.Forms.Label();
            this.txtPartInventory = new System.Windows.Forms.TextBox();
            this.lblPartPriceCost = new System.Windows.Forms.Label();
            this.txtPartPriceCost = new System.Windows.Forms.TextBox();
            this.lblPartMax = new System.Windows.Forms.Label();
            this.txtPartMax = new System.Windows.Forms.TextBox();
            this.txtPartMin = new System.Windows.Forms.TextBox();
            this.lblPartMin = new System.Windows.Forms.Label();
            this.lblPartMachineID = new System.Windows.Forms.Label();
            this.txtPartMachineID = new System.Windows.Forms.TextBox();
            this.btnPartSave = new System.Windows.Forms.Button();
            this.btnPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnPartsInHouse
            // 
            this.rdbtnPartsInHouse.AutoSize = true;
            this.rdbtnPartsInHouse.Checked = true;
            this.rdbtnPartsInHouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbtnPartsInHouse.Location = new System.Drawing.Point(76, 12);
            this.rdbtnPartsInHouse.Name = "rdbtnPartsInHouse";
            this.rdbtnPartsInHouse.Size = new System.Drawing.Size(68, 17);
            this.rdbtnPartsInHouse.TabIndex = 0;
            this.rdbtnPartsInHouse.TabStop = true;
            this.rdbtnPartsInHouse.Text = "In-House";
            this.rdbtnPartsInHouse.UseVisualStyleBackColor = true;
            this.rdbtnPartsInHouse.CheckedChanged += new System.EventHandler(this.rdbtnPartsInHouse_CheckedChanged);
            // 
            // rdbtnPartsOutsourced
            // 
            this.rdbtnPartsOutsourced.AutoSize = true;
            this.rdbtnPartsOutsourced.Location = new System.Drawing.Point(167, 12);
            this.rdbtnPartsOutsourced.Name = "rdbtnPartsOutsourced";
            this.rdbtnPartsOutsourced.Size = new System.Drawing.Size(80, 17);
            this.rdbtnPartsOutsourced.TabIndex = 1;
            this.rdbtnPartsOutsourced.Text = "Outsourced";
            this.rdbtnPartsOutsourced.UseVisualStyleBackColor = true;
            this.rdbtnPartsOutsourced.CheckedChanged += new System.EventHandler(this.rdbtnPartsOutsourced_CheckedChanged);
            // 
            // lblModifyPart
            // 
            this.lblModifyPart.AutoSize = true;
            this.lblModifyPart.Location = new System.Drawing.Point(12, 14);
            this.lblModifyPart.Name = "lblModifyPart";
            this.lblModifyPart.Size = new System.Drawing.Size(48, 13);
            this.lblModifyPart.TabIndex = 2;
            this.lblModifyPart.Text = "Add Part";
            // 
            // txtPartID
            // 
            this.txtPartID.Enabled = false;
            this.txtPartID.Location = new System.Drawing.Point(167, 73);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(108, 20);
            this.txtPartID.TabIndex = 3;
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Location = new System.Drawing.Point(73, 73);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(18, 13);
            this.lblPartID.TabIndex = 4;
            this.lblPartID.Text = "ID";
            this.lblPartID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(73, 114);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(35, 13);
            this.lblPartName.TabIndex = 6;
            this.lblPartName.Text = "Name";
            this.lblPartName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.Color.LightCoral;
            this.txtPartName.Location = new System.Drawing.Point(167, 114);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(108, 20);
            this.txtPartName.TabIndex = 5;
            this.txtPartName.TextChanged += new System.EventHandler(this.txtPartName_TextChanged);
            // 
            // lblPartInventory
            // 
            this.lblPartInventory.AutoSize = true;
            this.lblPartInventory.Location = new System.Drawing.Point(73, 161);
            this.lblPartInventory.Name = "lblPartInventory";
            this.lblPartInventory.Size = new System.Drawing.Size(51, 13);
            this.lblPartInventory.TabIndex = 8;
            this.lblPartInventory.Text = "Inventory";
            this.lblPartInventory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartInventory
            // 
            this.txtPartInventory.BackColor = System.Drawing.Color.LightCoral;
            this.txtPartInventory.Location = new System.Drawing.Point(167, 158);
            this.txtPartInventory.Name = "txtPartInventory";
            this.txtPartInventory.Size = new System.Drawing.Size(108, 20);
            this.txtPartInventory.TabIndex = 7;
            // 
            // lblPartPriceCost
            // 
            this.lblPartPriceCost.AutoSize = true;
            this.lblPartPriceCost.Location = new System.Drawing.Point(73, 205);
            this.lblPartPriceCost.Name = "lblPartPriceCost";
            this.lblPartPriceCost.Size = new System.Drawing.Size(63, 13);
            this.lblPartPriceCost.TabIndex = 10;
            this.lblPartPriceCost.Text = "Price / Cost";
            this.lblPartPriceCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartPriceCost
            // 
            this.txtPartPriceCost.BackColor = System.Drawing.Color.LightCoral;
            this.txtPartPriceCost.Location = new System.Drawing.Point(167, 202);
            this.txtPartPriceCost.Name = "txtPartPriceCost";
            this.txtPartPriceCost.Size = new System.Drawing.Size(108, 20);
            this.txtPartPriceCost.TabIndex = 9;
            // 
            // lblPartMax
            // 
            this.lblPartMax.AutoSize = true;
            this.lblPartMax.Location = new System.Drawing.Point(73, 249);
            this.lblPartMax.Name = "lblPartMax";
            this.lblPartMax.Size = new System.Drawing.Size(27, 13);
            this.lblPartMax.TabIndex = 12;
            this.lblPartMax.Text = "Max";
            this.lblPartMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartMax
            // 
            this.txtPartMax.BackColor = System.Drawing.Color.LightCoral;
            this.txtPartMax.Location = new System.Drawing.Point(106, 246);
            this.txtPartMax.Name = "txtPartMax";
            this.txtPartMax.Size = new System.Drawing.Size(50, 20);
            this.txtPartMax.TabIndex = 11;
            // 
            // txtPartMin
            // 
            this.txtPartMin.BackColor = System.Drawing.Color.LightCoral;
            this.txtPartMin.Location = new System.Drawing.Point(225, 246);
            this.txtPartMin.Name = "txtPartMin";
            this.txtPartMin.Size = new System.Drawing.Size(50, 20);
            this.txtPartMin.TabIndex = 13;
            // 
            // lblPartMin
            // 
            this.lblPartMin.AutoSize = true;
            this.lblPartMin.Location = new System.Drawing.Point(192, 249);
            this.lblPartMin.Name = "lblPartMin";
            this.lblPartMin.Size = new System.Drawing.Size(24, 13);
            this.lblPartMin.TabIndex = 14;
            this.lblPartMin.Text = "Min";
            this.lblPartMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPartMachineID
            // 
            this.lblPartMachineID.AutoSize = true;
            this.lblPartMachineID.Location = new System.Drawing.Point(73, 287);
            this.lblPartMachineID.Name = "lblPartMachineID";
            this.lblPartMachineID.Size = new System.Drawing.Size(62, 13);
            this.lblPartMachineID.TabIndex = 15;
            this.lblPartMachineID.Text = "Machine ID";
            // 
            // txtPartMachineID
            // 
            this.txtPartMachineID.BackColor = System.Drawing.Color.LightCoral;
            this.txtPartMachineID.Location = new System.Drawing.Point(167, 284);
            this.txtPartMachineID.Name = "txtPartMachineID";
            this.txtPartMachineID.Size = new System.Drawing.Size(108, 20);
            this.txtPartMachineID.TabIndex = 16;
            // 
            // btnPartSave
            // 
            this.btnPartSave.Enabled = false;
            this.btnPartSave.Location = new System.Drawing.Point(76, 327);
            this.btnPartSave.Name = "btnPartSave";
            this.btnPartSave.Size = new System.Drawing.Size(75, 23);
            this.btnPartSave.TabIndex = 17;
            this.btnPartSave.Text = "Save";
            this.btnPartSave.UseVisualStyleBackColor = true;
            // 
            // btnPartCancel
            // 
            this.btnPartCancel.Location = new System.Drawing.Point(200, 327);
            this.btnPartCancel.Name = "btnPartCancel";
            this.btnPartCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPartCancel.TabIndex = 18;
            this.btnPartCancel.Text = "Cancel";
            this.btnPartCancel.UseVisualStyleBackColor = true;
            this.btnPartCancel.Click += new System.EventHandler(this.btnPartCancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 377);
            this.Controls.Add(this.btnPartCancel);
            this.Controls.Add(this.btnPartSave);
            this.Controls.Add(this.txtPartMachineID);
            this.Controls.Add(this.lblPartMachineID);
            this.Controls.Add(this.lblPartMin);
            this.Controls.Add(this.txtPartMin);
            this.Controls.Add(this.lblPartMax);
            this.Controls.Add(this.txtPartMax);
            this.Controls.Add(this.lblPartPriceCost);
            this.Controls.Add(this.txtPartPriceCost);
            this.Controls.Add(this.lblPartInventory);
            this.Controls.Add(this.txtPartInventory);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.lblModifyPart);
            this.Controls.Add(this.rdbtnPartsOutsourced);
            this.Controls.Add(this.rdbtnPartsInHouse);
            this.Name = "AddPart";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnPartsInHouse;
        private System.Windows.Forms.RadioButton rdbtnPartsOutsourced;
        private System.Windows.Forms.Label lblModifyPart;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPartInventory;
        private System.Windows.Forms.TextBox txtPartInventory;
        private System.Windows.Forms.Label lblPartPriceCost;
        private System.Windows.Forms.TextBox txtPartPriceCost;
        private System.Windows.Forms.Label lblPartMax;
        private System.Windows.Forms.TextBox txtPartMax;
        private System.Windows.Forms.TextBox txtPartMin;
        private System.Windows.Forms.Label lblPartMin;
        private System.Windows.Forms.Label lblPartMachineID;
        private System.Windows.Forms.TextBox txtPartMachineID;
        private System.Windows.Forms.Button btnPartSave;
        private System.Windows.Forms.Button btnPartCancel;
    }
}