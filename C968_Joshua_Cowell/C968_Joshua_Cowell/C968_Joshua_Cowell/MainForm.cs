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

       


        private void buildLists()
        {

            //Prepopulating parts list
            Inventory.AllParts.Add(new OutsourcedPart { PartID = Inventory.calculatePartID(), Name = "Nut", InStock = 10, Price = 0.1m, Min = 0, Max = 9999, CompanyName = "Jonstans" });
            Inventory.AllParts.Add(new InhousePart { InStock = 31, Max = 500, Min = 0, Name = "Nail", PartID = Inventory.calculatePartID(), Price = 0.5m, MachineID = 999 });
            Inventory.AllParts.Add(new InhousePart { InStock = 111, Max = 200, Min = 3, Name = "Bolt", PartID = Inventory.calculatePartID(), Price = 0.1m, MachineID = 223 });
            Inventory.AllParts.Add(new InhousePart { InStock = 480, Max = 2000, Min = 100, Name = "Screw", PartID = Inventory.calculatePartID(), Price = 0.1m, MachineID = 711 });


            //Prepopulating products list
            BindingList<Part> tempParts = new BindingList<Part>();
            tempParts.Add(new InhousePart { InStock = 1139, Max = 1500, Min = 100, Name = "Spring", PartID = Inventory.calculatePartID(), Price = 0.75m, MachineID = 336 });
            tempParts.Add(new InhousePart { InStock = 31, Max = 500, Min = 0, Name = "Wheel", PartID = Inventory.calculatePartID(), Price = 10.0m, MachineID = 7 });

            Inventory.Products.Add(new Product { AssociatedParts = tempParts, InStock = 3, Max = 10, Min = 0, Name = "Bike", Price = 50.00m, ProductID = 99 });
            Inventory.Products.Add(new Product { AssociatedParts = tempParts, InStock = 13, Max = 25, Min = 0, Name = "Pogo Stick", Price = 35.00m, ProductID = 31 });
        }

        




        public void areListsUpdated(DataGridView d)
        {
            if (d.Rows.Count != Inventory.AllParts.Count || d.Rows.Count != Inventory.Products.Count)
            {
                Inventory.displayLists(dataviewParts, dataviewProducts);

            }
        }

        
      

        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
            dgvParts = dataviewParts;
            dgvProds = dataviewProducts;
            buildLists();
            Inventory.displayLists(dataviewParts, dataviewProducts);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Inventory.AllParts.Remove(Inventory.AllParts[partsIndex]);
            //shift all other values down one IF the index was larger than the index of the deleted item\
            
            partsIndex = 0;
            Inventory.displayLists(dataviewParts, dataviewProducts);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.Show();

            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID - 1 == partsIndex)
                {


                    //setting modify form fields
                    ModifyPart.modifyPartInstance.modifyID.Text = Inventory.AllParts[i].PartID.ToString();
                    ModifyPart.modifyPartInstance.modifyName.Text = Inventory.AllParts[i].Name;
                    ModifyPart.modifyPartInstance.modifyInv.Text = Inventory.AllParts[i].InStock.ToString();
                    ModifyPart.modifyPartInstance.modifyPriceCost.Text = Inventory.AllParts[i].Price.ToString();
                    ModifyPart.modifyPartInstance.modifyMin.Text = Inventory.AllParts[i].Min.ToString();
                    ModifyPart.modifyPartInstance.modifyMax.Text = Inventory.AllParts[i].Max.ToString();
                    if (Inventory.AllParts[i] is InhousePart)
                    {
                        ModifyPart.modifyPartInstance.inhouseButton.Checked = true;
                        ModifyPart.modifyPartInstance.machineIDCompanyNameLabel.Text = "Machine ID";
                        InhousePart x = (InhousePart)Inventory.AllParts[i];
                        ModifyPart.modifyPartInstance.modifyMachineIDCompanyName.Text = x.MachineID.ToString();
                    }
                    else
                    {
                        ModifyPart.modifyPartInstance.outsourceButton.Checked = true;
                        ModifyPart.modifyPartInstance.machineIDCompanyNameLabel.Text = "Company Name";
                        OutsourcedPart x = (OutsourcedPart)Inventory.AllParts[i];
                        ModifyPart.modifyPartInstance.modifyMachineIDCompanyName.Text = x.CompanyName;
                    }
                    //ModifyPart.modifyPartInstance.modifyMachineIDCompanyName.Text
                }
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
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            Inventory.Products.Remove(Inventory.Products[prodIndex]);
            prodIndex = 0;
            Inventory.displayLists(dataviewParts, dataviewProducts);
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            dataviewParts.ClearSelection();
            partsText = txtboxSearchParts.Text;

            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (partsText == Inventory.AllParts[i].PartID.ToString())
                {
                    dataviewParts.Rows[i].Selected = true;
                    partsIndex = i;
                    txtboxSearchParts.Text = "";
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
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (prodText == Inventory.Products[i].ProductID.ToString())
                {
                    dataviewProducts.Rows[i].Selected = true;
                    prodIndex = i;
                    txtboxSearchProducts.Text = "";
                }
            }
        }

        private void btnPartsUpdate_Click(object sender, EventArgs e)
        {
            areListsUpdated(dataviewParts);
        }
    }
}
