using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                    //Creating new object to replace old one

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
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);
                        Inventory.AllParts.Add(x);
                        this.Close();
                    }
                    else if (rdbtnModifyPartsInHouse.Checked && Inventory.AllParts[i] is OutsourcedPart)
                    {
                        InhousePart x = new InhousePart();
                        x.PartID = parseInt(txtModifyPartID.Text);
                        x.Name = txtModifyPartName.Text;
                        x.InStock = parseInt(txtModifyPartInventory.Text);
                        x.Price = decimal.Parse(txtModifyPartPriceCost.Text);
                        x.Max = parseInt(txtModifyPartMax.Text);
                        x.Min = parseInt(txtModifyPartMin.Text);
                        x.MachineID = parseInt(txtModifyPartMachineIDCompanyName.Text);
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);
                        Inventory.AllParts.Add(x);
                        this.Close();
                    }
                    else if (rdbtnModifyPartsOutsourced.Checked && Inventory.AllParts[i] is OutsourcedPart)
                    {
                        OutsourcedPart x = (OutsourcedPart)Inventory.AllParts[i];
                        x.PartID = parseInt(txtModifyPartID.Text);
                        x.Name = txtModifyPartName.Text;
                        x.InStock = parseInt(txtModifyPartInventory.Text);
                        x.Price = decimal.Parse(txtModifyPartPriceCost.Text);
                        x.Max = parseInt(txtModifyPartMax.Text);
                        x.Min = parseInt(txtModifyPartMin.Text);
                        x.CompanyName = txtModifyPartMachineIDCompanyName.Text;
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);
                        Inventory.AllParts.Add(x);
                        this.Close();
                    }
                    else
                    {
                        OutsourcedPart x = new OutsourcedPart();
                        x.PartID = parseInt(txtModifyPartID.Text);
                        x.Name = txtModifyPartName.Text;
                        x.InStock = parseInt(txtModifyPartInventory.Text);
                        x.Price = decimal.Parse(txtModifyPartPriceCost.Text);
                        x.Max = parseInt(txtModifyPartMax.Text);
                        x.Min = parseInt(txtModifyPartMin.Text);
                        x.CompanyName = txtModifyPartMachineIDCompanyName.Text;
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);
                        Inventory.AllParts.Add(x);
                        this.Close();
                    }
                }
            }  
        }

        private Regex decimalCheck = new Regex(@"-?[0-9][0-9,\.]+$");
        private Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");

        private bool isValid()
        {
            int pass = 0;

            //validaitng inventory
            if (numberCheck.IsMatch(txtModifyPartInventory.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Inventory");
                return false;
            }

            //validating price
            if (decimalCheck.IsMatch(txtModifyPartPriceCost.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Price/Cost");
                return false;
            }


            if (numberCheck.IsMatch(txtModifyPartMax.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Max");
                return false;
            }

            //validating min and making sure it's smaller than max
            if (numberCheck.IsMatch(txtModifyPartMin.Text))
            {
                if (parseInt(txtModifyPartMin.Text) < parseInt(txtModifyPartMax.Text))
                {
                    if (parseInt(txtModifyPartInventory.Text) > parseInt(txtModifyPartMax.Text))
                    {
                        MessageBox.Show("Please make sure the inventory is lower than  the max");
                        return false;
                    }
                    else if (parseInt(txtModifyPartInventory.Text) < parseInt(txtModifyPartMin.Text))
                    {
                        MessageBox.Show("Please make sure the inventory is higher than the min");
                        return false;
                    }
                    else
                    {
                        pass++;
                    }
                }
                else
                {
                    MessageBox.Show("Please make Min smaller than Max");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Please enter a proper value for Min");
                return false;
            }

            //checking if is inhouse
            if (rdbtnModifyPartsInHouse.Checked)
            {
                if (numberCheck.IsMatch(txtModifyPartMachineIDCompanyName.Text))
                {
                    pass++;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Machine ID");
                }
            }
            else
            {
                pass++;
            }

            return pass == 5 ? true : false;
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
            if (isValid() && isFormComplete())
            {
                updatePart();
            }
            
        }

        private void txtModifyPartName_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
        }

        private void txtModifyPartInventory_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
        }

        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
        }

        private void txtModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
        }

        private void txtModifyPartMachineIDCompanyName_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
        }
    }
}
