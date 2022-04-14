using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Joshua_Cowell
{
    public partial class ModifyPart : Form
    {


        private int parseInt(string x)
        {
            return int.Parse(x);
        }

        private bool isChecked()
        {
            if (rdbtnModifyPartsInHouse.Checked)
            {

                lblModifyPartMachineIDCompanyName.Text = "Machine ID";
                return true;
            }
            else
            {
                lblModifyPartMachineIDCompanyName.Text = "Company Name";
                return false;
            }
        }

        private bool isEmpty(string s)
        {
            return String.IsNullOrEmpty(s) ? true : false;
        }

        //checking to see if the
        //form has been filled out
        private bool isFormComplete()
        {
            if (isEmpty(txtModifyPartID.Text))
            {
                return false;
            }
            else if (isEmpty(txtModifyPartName.Text))
            {
                return false;
            }
            else if (isEmpty(txtModifyPartInventory.Text))
            {
                return false;
            }
            else if (isEmpty(txtModifyPartPriceCost.Text))
            {
                return false;
            }
            else if (isEmpty(txtModifyPartMin.Text))
            {
                return false;
            }
            else if (isEmpty(txtModifyPartMax.Text))
            {
                return false;
            }
            else if (isEmpty(txtModifyPartMachineIDCompanyName.Text))
            {
                return false;
            }
            else
            {
                btnModifyPartSave.Enabled = true;
                return true;
            }
        }

        private void updatePart()
        {
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (txtModifyPartID.Text == Inventory.AllParts[i].PartID.ToString())
                {



                    if (rdbtnModifyPartsInHouse.Checked && Inventory.AllParts[i] is InhousePart)
                    {
                        InhousePart x = (InhousePart)Inventory.AllParts[i];
                        x.PartID = parseInt(txtModifyPartID.Text);
                        x.Name = txtModifyPartName.Text;
                        x.InStock = parseInt(txtModifyPartInventory.Text);
                        x.Price = decimal.Parse(txtModifyPartPriceCost.Text);
                        x.Max = parseInt(txtModifyPartMax.Text);
                        x.Min = parseInt(txtModifyPartMin.Text);
                        x.MachineID = parseInt(txtModifyPartMachineIDCompanyName.Text);
                        this.Close();
                        MainForm.mainForm.areListsUpdated(MainForm.mainForm.dgvParts);
                    }
                    else if (rdbtnModifyPartsInHouse.Checked && Inventory.AllParts[i] is OutsourcedPart)
                    {
                        int index = Inventory.AllParts[i].PartID - 1;
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);
                        InhousePart x = new InhousePart();
                        x.PartID = parseInt(txtModifyPartID.Text);
                        x.Name = txtModifyPartName.Text;
                        x.InStock = parseInt(txtModifyPartInventory.Text);
                        x.Price = decimal.Parse(txtModifyPartPriceCost.Text);
                        x.Max = parseInt(txtModifyPartMax.Text);
                        x.Min = parseInt(txtModifyPartMin.Text);
                        x.MachineID = parseInt(txtModifyPartMachineIDCompanyName.Text);
                        Inventory.AllParts.Insert(index, x);
                        this.Close();
                        MainForm.mainForm.areListsUpdated(MainForm.mainForm.dgvParts);
                    }
                    else if (rdbtnModifyPartsOutsourced.Checked && Inventory.AllParts[i] is OutsourcedPart)
                    {
                        OutsourcedPart x = (OutsourcedPart)Inventory.AllParts[i];
                        x.Name = txtModifyPartName.Text;
                        x.InStock = parseInt(txtModifyPartInventory.Text);
                        x.Price = decimal.Parse(txtModifyPartPriceCost.Text);
                        x.Max = parseInt(txtModifyPartMax.Text);
                        x.Min = parseInt(txtModifyPartMin.Text);
                        x.CompanyName = txtModifyPartMachineIDCompanyName.Text;
                        this.Close();
                    }
                }
            }  
        }

        public static ModifyPart modifyPartInstance;
        public TextBox modifyID;
        public TextBox modifyName;
        public TextBox modifyInv;
        public TextBox modifyPriceCost;
        public TextBox modifyMax;
        public TextBox modifyMin;
        public TextBox modifyMachineIDCompanyName;
        public RadioButton inhouseButton;
        public RadioButton outsourceButton;
        public Label machineIDCompanyNameLabel;
        public ModifyPart()
        {
            InitializeComponent();
            modifyPartInstance = this;
            modifyID = txtModifyPartID;
            modifyName = txtModifyPartName;
            modifyInv = txtModifyPartInventory;
            modifyPriceCost = txtModifyPartPriceCost;
            modifyMax = txtModifyPartMax;
            modifyMin = txtModifyPartMin;
            modifyMachineIDCompanyName = txtModifyPartMachineIDCompanyName;
            inhouseButton = rdbtnModifyPartsInHouse;
            outsourceButton = rdbtnModifyPartsOutsourced;
            machineIDCompanyNameLabel = lblModifyPartMachineIDCompanyName;

        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            
        }

        private void txtModifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
        }

        private void btnModifyPartCancel_Click(object sender, EventArgs e)
        {
            //clear text boxes and close window
            this.Close();
        }

        private void rdbtnModifyPartsInHouse_CheckedChanged(object sender, EventArgs e)
        {
            isChecked();
        }

        private void rdbtnModifyPartsOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            isChecked();
        }

        private void btnModifyPartSave_Click(object sender, EventArgs e)
        {
            if (isFormComplete())
            {
                
                updatePart();
            }
        }

        private void txtModifyPartName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModifyPartInventory_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModifyPartMin_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModifyPartMachineIDCompanyName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
