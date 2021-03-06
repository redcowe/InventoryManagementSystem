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
    public partial class AddPart : Form
    {

        private Regex decimalCheck = new Regex(@"-?[0-9][0-9,\.]+$");
        private Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");

        //Validate form
        private bool isValid()
        {
            int pass = 0;

            //validaitng inventory
            if (numberCheck.IsMatch(txtPartInventory.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Inventory");
                return false;
            }

            //validating price
            if (decimalCheck.IsMatch(txtPartPriceCost.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Price/Cost");
                return false;
            }


            if (numberCheck.IsMatch(txtPartMax.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Max");
                return false;
            }

            //validating min
            if (numberCheck.IsMatch(txtPartMin.Text))
            {
                if (parseInt(txtPartMin.Text) < parseInt(txtPartMax.Text))
                {
                    if (parseInt(txtPartInventory.Text) > parseInt(txtPartMax.Text))
                    {
                        MessageBox.Show("Please make sure the inventory is lower than  the max");
                        return false; 
                    }
                    else if (parseInt(txtPartInventory.Text) < parseInt(txtPartMin.Text))
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
            if (rdbtnPartsInHouse.Checked)
            {
                if (numberCheck.IsMatch(txtPartMachineIDCompanyName.Text))
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

        
        private void resetFields()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtPartID);
            textBoxes.Add(txtPartName);
            textBoxes.Add(txtPartInventory);
            textBoxes.Add(txtPartMax);
            textBoxes.Add(txtPartMin);
            textBoxes.Add(txtPartMachineIDCompanyName);
            textBoxes.Add(txtPartPriceCost);

            foreach ( TextBox txtbox in textBoxes)
            {
                txtbox.Text = "";
            }
        }

        //helper function that checks
        //for empty fields
        private bool isEmpty(string s)
        {
            return String.IsNullOrEmpty(s) ? true : false;
        }

        //checking to see if the
        //form has been filled out
        private bool isFormComplete()
        {
            if (isEmpty(txtPartID.Text))
            {
                return false;
            }
            else if (isEmpty(txtPartName.Text))
            {
                return false;
            }
            else if (isEmpty(txtPartInventory.Text))
            {
                return false;
            }
            else if (isEmpty(txtPartPriceCost.Text))
            {
                return false;
            }
            else if (isEmpty(txtPartMin.Text))
            {
                return false;
            }
            else if (isEmpty(txtPartMax.Text))
            {
                return false;
            }
            else if (isEmpty(txtPartMachineIDCompanyName.Text))
            {
                return false;
            }
            else
            {
                btnPartSave.Enabled = true;
                return true;
            }
        }
       
        //checking the state of the radio buttons
        //and changing accordingly
        private bool isChecked()
        {
            if (rdbtnPartsInHouse.Checked)
            {
                
                lblPartMachineIDCompanyName.Text = "Machine ID";
                return true;
            }
            else
            {
                lblPartMachineIDCompanyName.Text = "Company Name";
                return false;
            }
        }

        private int parseInt(string x)
        {
            return int.Parse(x);
        }

        private Part createPart()
        {
            if (rdbtnPartsInHouse.Checked)
            {
                //create inhouse part 

                return new InhousePart { PartID = parseInt(txtPartID.Text), Name = txtPartName.Text, InStock = parseInt(txtPartInventory.Text), Price = decimal.Parse(txtPartPriceCost.Text), Min = parseInt(txtPartMin.Text), Max = parseInt(txtPartMax.Text), MachineID = parseInt(txtPartMachineIDCompanyName.Text) };
                    
            }
            else
            {
                //create outsourced part

                return new OutsourcedPart { PartID = parseInt(txtPartID.Text), Name = txtPartName.Text, InStock = parseInt(txtPartInventory.Text), Price = decimal.Parse(txtPartPriceCost.Text), Min = parseInt(txtPartMin.Text), Max = parseInt(txtPartMax.Text), CompanyName = txtPartMachineIDCompanyName.Text };
                    
            }
        }
        
        
        public AddPart()
        {
            InitializeComponent();
            txtPartID.Text = Inventory.calculatePartID().ToString();
            
        }

        private void Parts_Load(object sender, EventArgs e)
        {

        }

        private void btnPartCancel_Click(object sender, EventArgs e)
        {
            
            //clear text boxes and close window
            this.Close();
            resetFields();
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
            txtPartName.BackColor = Color.White;
        }

        private void rdbtnPartsOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            isChecked();
        }

        private void rdbtnPartsInHouse_CheckedChanged(object sender, EventArgs e)
        {
            isChecked();
        }

        private void btnPartSave_Click(object sender, EventArgs e)
        {
            
            if (isValid())
            {
                Inventory.addPart(createPart());
                this.Close();
                resetFields();
            }
            else
            {
                Console.WriteLine("Not working");
            } 
        }

        private void txtPartInventory_TextChanged(object sender, EventArgs e)
        {
            txtPartInventory.BackColor = Color.White;
        }

        private void txtPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
            txtPartPriceCost.BackColor = Color.White;
        }

        private void txtPartMax_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
            txtPartMax.BackColor = Color.White;
        }

        private void txtPartMin_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
            txtPartMin.BackColor = Color.White;
        }

        private void txtPartMachineIDCompanyName_TextChanged(object sender, EventArgs e)
        {
            isFormComplete();
            txtPartMachineIDCompanyName.BackColor = Color.White;
        }

        private void txtPartID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
