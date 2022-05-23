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

    //Parts and Products Lists and properties
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
            Inventory.Products.Add(product);
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
        

        public static Product lookupProduct(int id)
        {
            Product product = null;
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (id == Inventory.Products[i].ProductID)
                {
                    _ = Inventory.products[i];
                }
            }
            return product;
        }

        
      

        public static void updateProduct( int id, Product product)
        {
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (id == Inventory.Products[i].ProductID)
                {
                    removeProduct(id);
                }
                addProduct(product);
            }
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

        
        public static Part lookupPart(int id)
        {
            Part part = null;
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (id == Inventory.AllParts[i].PartID)
                {
                    _ = Inventory.AllParts[i];
                }
            }
            return part;
            
        }
        

        public static void updatePart(int id, Part part)
        {
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (id == Inventory.AllParts[i].PartID)
                {
                    removePart(Inventory.AllParts[i]);
                }
                addPart(part);
            }
        }

        //Helper functions to caculate IDs
        public static int calculatePartID()
        {
            
            int result = Inventory.AllParts.Count + 1;
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (result == Inventory.AllParts[i].PartID)
                {
                    result = Inventory.AllParts.Count + 2;
                }
            }
            return result;
        }

        public static int calculateProdID()
        {
            int result = Inventory.Products.Count + 1;
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (result == Inventory.Products[i].ProductID)
                {
                    result = Inventory.Products.Count + 2;
                }
            }
            return result;
        }
    }
}


