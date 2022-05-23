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

    public partial class MainForm : Form
    {



        //Variables to access from other forms
        public static MainForm mainForm;
        public DataGridView dgvParts;
        public DataGridView dgvProds;

        //Variables to keep track of row index

        internal int partsIndex;
        internal int prodIndex;

        //Variables to keep track of searchs

        string partsText = "";
        string prodText = "";

        private Regex numberCheck = new Regex("^(0|[1-9][0-9]*)$");


        private void buildLists()
        {

            //Prepopulating parts list
            Inventory.AllParts.Add(new OutsourcedPart { PartID = Inventory.calculatePartID(), Name = "Nut", InStock = 10, Price = 0.1m, Min = 0, Max = 9999, CompanyName = "Jonstans" });
            Inventory.AllParts.Add(new InhousePart { InStock = 31, Max = 500, Min = 0, Name = "Nail", PartID = Inventory.calculatePartID(), Price = 0.5m, MachineID = 999 });
            Inventory.AllParts.Add(new InhousePart { InStock = 111, Max = 200, Min = 3, Name = "Bolt", PartID = Inventory.calculatePartID(), Price = 0.1m, MachineID = 223 });
            Inventory.AllParts.Add(new InhousePart { InStock = 480, Max = 2000, Min = 100, Name = "Screw", PartID = Inventory.calculatePartID(), Price = 0.1m, MachineID = 711 });


            //Prepopulating products list
            BindingList<Part> tempParts = new BindingList<Part>();
            tempParts.Add(new InhousePart { InStock = 1139, Max = 1500, Min = 100, Name = "Spring", PartID = 99, Price = 0.75m, MachineID = 336 });
            tempParts.Add(new InhousePart { InStock = 31, Max = 500, Min = 0, Name = "Wheel", PartID = 100, Price = 10.0m, MachineID = 7 });

            Inventory.Products.Add(new Product { AssociatedParts = tempParts, InStock = 3, Max = 10, Min = 0, Name = "Bike", Price = 50.00m, ProductID = Inventory.calculateProdID() });        
        }

        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
            dgvParts = dataviewParts;
            dgvProds = dataviewProducts;
            buildLists();
            dataviewParts.DataSource = Inventory.AllParts;
            dataviewParts.Columns[0].HeaderText = "Part ID";
            dataviewParts.Columns[3].HeaderText = "Inventory";
            dataviewProducts.DataSource = Inventory.Products;
            dataviewProducts.Columns[0].HeaderText = "Product ID";
            dataviewProducts.Columns[3].HeaderText = "Inventory";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow.Selected == false)
            {
                MessageBox.Show("Please select a row before deleting");

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Part p = dgvParts.CurrentRow.DataBoundItem as Part;
                    Inventory.AllParts.Remove(p);
                    dgvParts.ClearSelection();
                }
            }

        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.Show();
            

            //Filling the form with the object's data

            if (dgvParts.CurrentRow.DataBoundItem is InhousePart)
            {
                ModifyPart.modifyPartInstance.inhouseButton.Checked = true;
                ModifyPart.modifyPartInstance.machineIDCompanyNameLabel.Text = "Machine ID";
                InhousePart p = dgvParts.CurrentRow.DataBoundItem as InhousePart;

                ModifyPart.modifyPartInstance.modifyID.Text = p.PartID.ToString();
                ModifyPart.modifyPartInstance.modifyInv.Text = p.InStock.ToString();
                ModifyPart.modifyPartInstance.modifyPriceCost.Text = p.Price.ToString();
                ModifyPart.modifyPartInstance.modifyMin.Text = p.Min.ToString();
                ModifyPart.modifyPartInstance.modifyMax.Text = p.Max.ToString();
                ModifyPart.modifyPartInstance.modifyName.Text = p.Name;
                ModifyPart.modifyPartInstance.modifyMachineIDCompanyName.Text = p.MachineID.ToString();
                

            }
            else
            {
                ModifyPart.modifyPartInstance.outsourceButton.Checked = true;
                ModifyPart.modifyPartInstance.machineIDCompanyNameLabel.Text = "Company Name";
                OutsourcedPart p = dgvParts.CurrentRow.DataBoundItem as OutsourcedPart;

                ModifyPart.modifyPartInstance.modifyID.Text = p.PartID.ToString();
                ModifyPart.modifyPartInstance.modifyInv.Text = p.InStock.ToString();
                ModifyPart.modifyPartInstance.modifyPriceCost.Text = p.Price.ToString();
                ModifyPart.modifyPartInstance.modifyMin.Text = p.Min.ToString();
                ModifyPart.modifyPartInstance.modifyMax.Text = p.Max.ToString();
                ModifyPart.modifyPartInstance.modifyName.Text = p.Name;
                ModifyPart.modifyPartInstance.modifyMachineIDCompanyName.Text = p.CompanyName;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Parts grid view

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partsIndex = e.RowIndex;


        }

        //Product grid view

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            prodIndex = e.RowIndex;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            
        }

        private void btnModifyProducts_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct();
            modifyProduct.Show();

            Product p = dgvProds.CurrentRow.DataBoundItem as Product;
            ModifyProduct.modifyProductInstance.modifyProductID.Text = p.ProductID.ToString();
            ModifyProduct.modifyProductInstance.modifyProductName.Text = p.Name;
            ModifyProduct.modifyProductInstance.modifyProductInventory.Text = p.InStock.ToString();
            ModifyProduct.modifyProductInstance.modifyProductPrice.Text = p.Price.ToString();
            ModifyProduct.modifyProductInstance.modifyProductMax.Text = p.Max.ToString();
            ModifyProduct.modifyProductInstance.modifyProductMin.Text = p.Min.ToString();
            ModifyProduct.modifyProductInstance.modifyProductAssociatedParts.DataSource = p.AssociatedParts;
            ModifyProduct.modifyProductInstance.modifyProductAssociatedParts.Columns[0].HeaderText = "Part ID";
            ModifyProduct.modifyProductInstance.modifyProductAssociatedParts.Columns[3].HeaderText = "Inventory";
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgvProds.Rows.Count == 0)
                {
                    MessageBox.Show("Please select a row before deleting");
                }
                else
                {
                    Product p = dataviewProducts.CurrentRow.DataBoundItem as Product;
                    if (p.AssociatedParts.Count == 0)
                    {
                        Inventory.Products.Remove(p);
                        dataviewProducts.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Please remove associated items before deleting product");
                    }
                }
                
            } 
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            dataviewParts.ClearSelection();
            partsText = txtboxSearchParts.Text;

            if (numberCheck.IsMatch(partsText) == false)
            {
                MessageBox.Show("Please enter a Part ID");
                txtboxSearchParts.Text = "";
            }
            else
            {
                if (int.Parse(partsText) > Inventory.AllParts.Count)
                {
                    MessageBox.Show("Part not found");
                    txtboxSearchParts.Text = "";
                }
                else
                {
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (partsText == Inventory.AllParts[i].PartID.ToString())
                        {
                            dataviewParts.Rows[i].Selected = true;
                            txtboxSearchParts.Text = "";
                            break;
                        }
                    }
                }
            }
        }

        private void txtboxSearchParts_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            dataviewProducts.ClearSelection();
            prodText = txtboxSearchProducts.Text;
            if (numberCheck.IsMatch(prodText) == false)
            {
                MessageBox.Show("Please enter a Product ID");
                txtboxSearchProducts.Text = "";
            }
            else
            {
                if (int.Parse(prodText) > Inventory.Products.Count)
                {
                    MessageBox.Show("Product not found");
                    txtboxSearchProducts.Text = "";
                }
                else
                {
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        if (prodText == Inventory.Products[i].ProductID.ToString())
                        {
                            dataviewProducts.Rows[i].Selected = true;
                            prodIndex = i;
                            txtboxSearchProducts.Text = "";
                            break;
                        }
                        else if (i == Inventory.Products.Count)
                        {

                        }

                    }
                }
            }
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
