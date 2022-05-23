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
    public partial class AddProduct : Form
    {
        private BindingList<Part> parts = new BindingList<Part>();

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
            if (numberCheck.IsMatch(txtProductInventory.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Inventory");
                return false;
            }

            //validating price
            if (decimalCheck.IsMatch(txtProductPrice.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Price/Cost");
                return false;
            }


            if (numberCheck.IsMatch(txtProductMax.Text))
            {
                pass++;
            }
            else
            {
                MessageBox.Show("Please enter a proper value for Max");
                return false;
            }

            //validating min
            if (numberCheck.IsMatch(txtProductMin.Text))
            {
                if (parseInt(txtProductMin.Text) < parseInt(txtProductMax.Text))
                {
                    if (parseInt(txtProductInventory.Text) > parseInt(txtProductMax.Text))
                    {
                        MessageBox.Show("Please make sure the inventory is lower than  the max");
                        return false;
                    }
                    else if (parseInt(txtProductInventory.Text) < parseInt(txtProductMin.Text))
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

        public AddProduct()
        {
            InitializeComponent();
            txtProductID.Text = Inventory.calculateProdID().ToString();
            dataviewAddProductCandidate.DataSource = Inventory.AllParts;
            dataviewAssociatedParts.DataSource = parts;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Cancel Button
        private void button2_Click(object sender, EventArgs e)
        {
            //clear text boxes and close window
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Part p = dataviewAddProductCandidate.CurrentRow.DataBoundItem as Part;
            parts.Add(p);
            dataviewAddProductCandidate.ClearSelection();
        }

        private void btnDeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dataviewAssociatedParts.Rows.Count == 0)
            {
                MessageBox.Show("Please select a row before attempting to delete");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Part p = dataviewAssociatedParts.CurrentRow.DataBoundItem as Part;
                    dataviewAssociatedParts.ClearSelection();
                    parts.Remove(p);
                }
            }
           
            
        }

        private void btnSaveAd_Click(object sender, EventArgs e)
        {
           if (isValid())
            {
                Product p = new Product();
                p.ProductID = parseInt(txtProductID.Text);
                p.Name = txtProductName.Text;
                p.InStock = parseInt(txtProductInventory.Text);
                p.Price = decimal.Parse(txtProductPrice.Text);
                p.Max = parseInt(txtProductMax.Text);
                p.Min = parseInt(txtProductMin.Text);
                p.AssociatedParts = parts;
                Inventory.Products.Add(p);
                this.Close();
            }
            
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataviewAddProductCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            txtProductName.BackColor = Color.White;
        }

        private void txtProductInventory_TextChanged(object sender, EventArgs e)
        {
            txtProductInventory.BackColor = Color.White;
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            txtProductPrice.BackColor = Color.White;
        }

        private void txtProductMax_TextChanged(object sender, EventArgs e)
        {
            txtProductMax.BackColor = Color.White;
        }

        private void txtProductMin_TextChanged(object sender, EventArgs e)
        {
            txtProductMin.BackColor = Color.White;
        }

        private void txtAddProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProductSearch_Click(object sender, EventArgs e)
        {

            if (numberCheck.IsMatch(txtAddProductSearch.Text) == false)
            {
                MessageBox.Show("Please enter a Part ID");
                txtAddProductSearch.Text = "";
            }
            else
            {
                if (parseInt(txtAddProductSearch.Text) > Inventory.AllParts.Count)
                {
                    MessageBox.Show("Part not found");
                    txtAddProductSearch.Text = "";
                }
                else
                {
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (Inventory.AllParts[i].PartID == parseInt(txtAddProductSearch.Text))
                        {
                            dataviewAddProductCandidate.Rows[i].Selected = true;
                            txtAddProductSearch.Text = "";
                            break;
                        }
                        else
                        {
                            dataviewAddProductCandidate.ClearSelection();
                        }
                    }
                }
            } 
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
