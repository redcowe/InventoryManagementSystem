using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Joshua_Cowell
{
     public static class Inventory

    //Parts and Products Lists
    {
        static private  BindingList<Product> products = new BindingList<Product>();

        static public BindingList<Product> Products
        {
            set { products = value; }
            get { return products; }
        }

        static private  BindingList<Part> parts = new BindingList<Part>();

        public static BindingList<Part> AllParts
        {
            set { parts = value; }
            get { return parts; }
        }

        

        //Product functions

        public static void addProduct(Product product)
        {
            //TODO
        }

     
        public static bool removeProduct(int id)
        {
            if (Products.Contains(Products[id]))
            {
                Products.Remove(Products[id]);
                return true;
            }
            else
            {
                return false;
            }

        }
        /*

        public Product lookupProduct(int id)
        {
            //TODO

           
        }

        */
      

        public static void updateProduct( int id, Product product)
        {

            //TODO
        }

        //Part functions

        public static void addPart(Part part)
        {
            Inventory.AllParts.Add(part);
        }

        public static bool removePart(Part part)
        {
            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        public static PartlookupPart(int id)
        {
            //TODO
        }
        */

        public static void updatePart(int id, Part part)
        {
            //TODO
            Part currentPart = part;



        }

        //Helper function to caculate IDs
        public static int calculatePartID()
        {
            int result = Inventory.AllParts.Count + 1;
            return result;
        }

        //Filling parts table
        public static void fillParts(DataGridView d)
        {
            d.Rows.Clear();
            d.Refresh();
            if (Inventory.AllParts.Count == 0 || Inventory.AllParts.Count == 1)
            {
                d.Rows.Add(1);
            }
            else
            {
                d.Rows.Add(Inventory.AllParts.Count - 1);
            }
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                d.Rows[i].Cells[0].Value = Inventory.AllParts[i].PartID;
                d.Rows[i].Cells[1].Value = Inventory.AllParts[i].Name;
                d.Rows[i].Cells[2].Value = Inventory.AllParts[i].InStock;
                d.Rows[i].Cells[3].Value = Inventory.AllParts[i].Price;
                d.Rows[i].Cells[4].Value = Inventory.AllParts[i].Min;
                d.Rows[i].Cells[5].Value = Inventory.AllParts[i].Max;
            }

        }

        //Filling products table

        public static void fillProducts(DataGridView d)
        {

            d.Rows.Clear();
            d.Refresh();
            if (Inventory.Products.Count == 0 || Inventory.Products.Count == 1)
            {
                d.Rows.Add(1);
            }
            else
            {
                d.Rows.Add(Inventory.Products.Count - 1);
            }

            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                d.Rows[i].Cells[0].Value = Inventory.Products[i].ProductID;
                d.Rows[i].Cells[1].Value = Inventory.Products[i].Name;
                d.Rows[i].Cells[2].Value = Inventory.Products[i].InStock;
                d.Rows[i].Cells[3].Value = Inventory.Products[i].Price;
                d.Rows[i].Cells[4].Value = Inventory.Products[i].Min;
                d.Rows[i].Cells[5].Value = Inventory.Products[i].Max;
            }
        }

        //Filling displays
        public static void displayLists(DataGridView parts, DataGridView products)
        {
            Inventory.fillParts(parts);
            Inventory.fillProducts(products);
        }
    }
}


