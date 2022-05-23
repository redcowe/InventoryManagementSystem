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

    public partial class ModifyProduct : Form
    {

        BindingList<Part> parts = new BindingList<Part>();
        private int parseInt(string x)
        {
            return int.Parse(x);
        }

        private Regex decimalCheck = new Regex(@"-?[0-9][0-9,\.]+$");
        private Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");

        //Validate form
        private bool isValid()
        {
            int pass = 0;

            //validaitng inventory
            if (numberCheck.IsMatch(txtModifyProductInventory.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Inventory");
                return false;
            }

            //validating price
            if (decimalCheck.IsMatch(txtModifyProductPrice.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Price/Cost");
                return false;
            }


            if (numberCheck.IsMatch(txtModifyProductMax.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Max");
                return false;
            }

            //validating min, max, and if inventory is between
            if (numberCheck.IsMatch(txtModifyProductMin.Text))
            {
                if (parseInt(txtModifyProductMin.Text) < parseInt(txtModifyProductMax.Text))
                {
                    if (parseInt(txtModifyProductInventory.Text) > parseInt(txtModifyProductMax.Text))
                    {
                        MessageBox.Show("Please make sure the inventory is lower than  the max");
                        return false;
                    }
                    else if (parseInt(txtModifyProductInventory.Text) < parseInt(txtModifyProductMin.Text))
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

            return pass == 4 ? true : false;
        }
        //making attributes accessible from other forms
        public static ModifyProduct modifyProductInstance = new ModifyProduct();
        public TextBox modifyProductName;
        public TextBox modifyProductID;
        public TextBox modifyProductInventory;
        public TextBox modifyProductPrice;
        public TextBox modifyProductMax;
        public TextBox modifyProductMin;
        public DataGridView modifyProductAssociatedParts;

        public ModifyProduct()
        {
            InitializeComponent();
            modifyProductInstance = this;
            dataviewAddProductCandidate.DataSource = Inventory.AllParts;
            dataviewAddProductCandidate.Columns[0].HeaderText = "Part ID";
            dataviewAddProductCandidate.Columns[3].HeaderText = "Inventory";
            modifyProductID = txtModifyProductID;
            modifyProductName = txtModifyProductName;
            modifyProductInventory = txtModifyProductInventory;
            modifyProductPrice = txtModifyProductPrice;
            modifyProductMax = txtModifyProductMax;
            modifyProductMin = txtModifyProductMin;
            modifyProductAssociatedParts = dataviewAssociatedParts;

        }

        private void btnModifyAddProductCancel_Click(object sender, EventArgs e)
        {
            //clear text boxes and close window
            this.Close();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProductSearch_Click(object sender, EventArgs e)
        {
            if (numberCheck.IsMatch(txtModifyAddProductSearch.Text) == false)
            {
                MessageBox.Show("Please enter a Part ID");
                txtModifyAddProductSearch.Text = "";
            }
            else
            {
                if (parseInt(txtModifyAddProductSearch.Text) > Inventory.AllParts.Count)
                {
                    MessageBox.Show("Part not found");
                    txtModifyAddProductSearch.Text = "";
                }
                else
                {
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (Inventory.AllParts[i].PartID == parseInt(txtModifyAddProductSearch.Text))
                        {
                            dataviewAddProductCandidate.Rows[i].Selected = true;
                            txtModifyAddProductSearch.Text = "";
                            break;
                        }
                    }
                }
            } 
        }

        private void btnModifyAddProduct_Click(object sender, EventArgs e)
        {
            Part p = dataviewAddProductCandidate.CurrentRow.DataBoundItem as Part;
            //search for id and add to that list
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == parseInt(txtModifyProductID.Text))
                {
                    Inventory.Products[i].AssociatedParts.Add(p);
                    parts = Inventory.Products[i].AssociatedParts;
                }
            }
        }

        private void btnModifyDeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dataviewAssociatedParts.Rows.Count == 0)
            {
                MessageBox.Show("Please select a row before deleting");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Part p = dataviewAssociatedParts.CurrentRow.DataBoundItem as Part;
                    //search for id and add to that list
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        if (Inventory.Products[i].ProductID == parseInt(txtModifyProductID.Text))
                        {
                            Inventory.Products[i].AssociatedParts.Remove(p);
                        }
                    }
                }  
            }
            
        }

        private void btnModifyAddProductSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                Product p = new Product();
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].ProductID == parseInt(txtModifyProductID.Text))
                    {
                        parts = Inventory.Products[i].AssociatedParts;
                        Inventory.Products.Remove(Inventory.Products[i]);
                    }
                }
                p.AssociatedParts = parts;
                p.ProductID = parseInt(txtModifyProductID.Text);
                p.Name = txtModifyProductName.Text;
                p.InStock = parseInt(txtModifyProductInventory.Text);
                p.Price = decimal.Parse(txtModifyProductPrice.Text);
                p.Max = parseInt(txtModifyProductMax.Text);
                p.Min = parseInt(txtModifyProductMin.Text);
                Inventory.Products.Add(p);
                this.Close();
            }
            
        }

        private void txtModifyProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
