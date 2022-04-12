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

        public Inventory myInventory = new Inventory();

        //Creating inventory


        //Variables to keep track of row index

        int partsIndex;
        int prodIndex;

        //Variables to keep track of searchs

        string partsText = "";
        string prodText = "";

        //Helper function to caculate IDs
        private int calculatePartID()
        {
            int result = myInventory.AllParts.Count + 1;
            return result;
        }


        private void buildLists()
        {

            //Prepopulating parts list
            myInventory.AllParts.Add(new OutsourcedPart { PartID = calculatePartID(), Name = "Nut", InStock = 10, Price = 0.1m, Min = 0, Max = 9999, CompanyName = "Jonstans" });
            myInventory.AllParts.Add(new InhousePart { InStock = 31, Max = 500, Min = 0, Name = "Nail", PartID = calculatePartID(), Price = 0.5m, MachineID = 999 });
            myInventory.AllParts.Add(new InhousePart { InStock = 111, Max = 200, Min = 3, Name = "Bolt", PartID = calculatePartID(), Price = 0.1m, MachineID = 223 });
            myInventory.AllParts.Add(new InhousePart { InStock = 480, Max = 2000, Min = 100, Name = "Screw", PartID = calculatePartID(), Price = 0.1m, MachineID = 711 });


            //Prepopulating products list
            BindingList<Part> tempParts = new BindingList<Part>();
            tempParts.Add(new InhousePart { InStock = 1139, Max = 1500, Min = 100, Name = "Spring", PartID = calculatePartID(), Price = 0.75m, MachineID = 336 });
            tempParts.Add(new InhousePart { InStock = 31, Max = 500, Min = 0, Name = "Wheel", PartID = calculatePartID(), Price = 10.0m, MachineID = 7 });

            myInventory.Products.Add(new Product { AssociatedParts = tempParts, InStock = 3, Max = 10, Min = 0, Name = "Bike", Price = 50.00m, ProductID = 99 });
            myInventory.Products.Add(new Product { AssociatedParts = tempParts, InStock = 13, Max = 25, Min = 0, Name = "Pogo Stick", Price = 35.00m, ProductID = 31 });
        }

        //Filling parts table
        private void fillParts()
        {
            dataviewParts.Rows.Clear();
            dataviewParts.Refresh();
            if (myInventory.AllParts.Count == 0 || myInventory.AllParts.Count == 1)
            {
                dataviewParts.Rows.Add(1);
            }
            else
            {
                dataviewParts.Rows.Add(myInventory.AllParts.Count - 1);
            }
            for (int i = 0; i < myInventory.AllParts.Count; i++)
            {
                dataviewParts.Rows[i].Cells[0].Value = myInventory.AllParts[i].PartID;
                dataviewParts.Rows[i].Cells[1].Value = myInventory.AllParts[i].Name;
                dataviewParts.Rows[i].Cells[2].Value = myInventory.AllParts[i].InStock;
                dataviewParts.Rows[i].Cells[3].Value = myInventory.AllParts[i].Price;
                dataviewParts.Rows[i].Cells[4].Value = myInventory.AllParts[i].Min;
                dataviewParts.Rows[i].Cells[5].Value = myInventory.AllParts[i].Max;
            }

        }

        //Filling products table

        private void fillProducts()
        {

            dataviewProducts.Rows.Clear();
            dataviewProducts.Refresh();
            if (myInventory.Products.Count == 0 || myInventory.Products.Count == 1)
            {
                dataviewProducts.Rows.Add(1);
            }
            else
            {
                dataviewProducts.Rows.Add(myInventory.Products.Count - 1);
            }

            for (int i = 0; i < myInventory.Products.Count; i++)
            {
                dataviewProducts.Rows[i].Cells[0].Value = myInventory.Products[i].ProductID;
                dataviewProducts.Rows[i].Cells[1].Value = myInventory.Products[i].Name;
                dataviewProducts.Rows[i].Cells[2].Value = myInventory.Products[i].InStock;
                dataviewProducts.Rows[i].Cells[3].Value = myInventory.Products[i].Price;
                dataviewProducts.Rows[i].Cells[4].Value = myInventory.Products[i].Min;
                dataviewProducts.Rows[i].Cells[5].Value = myInventory.Products[i].Max;
            }

        }

        private void displayLists()
        {
            fillParts();
            fillProducts();
        }


        public MainForm()
        {
            InitializeComponent();

            buildLists();

            displayLists();
            
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            myInventory.AllParts.Remove(myInventory.AllParts[partsIndex]);
            partsIndex = 0;
            displayLists();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.Show();
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
            myInventory.Products.Remove(myInventory.Products[prodIndex]);
            prodIndex = 0;
            displayLists();
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            dataviewParts.ClearSelection();
            partsText = txtboxSearchParts.Text;

            for (int i = 0; i < myInventory.AllParts.Count; i++)
            {
                if (partsText == myInventory.AllParts[i].PartID.ToString())
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
            for (int i = 0; i < myInventory.Products.Count; i++)
            {
                if (prodText == myInventory.Products[i].ProductID.ToString())
                {
                    dataviewProducts.Rows[i].Selected = true;
                    prodIndex = i;
                    txtboxSearchProducts.Text = "";
                }
            }
        }
    }
}
