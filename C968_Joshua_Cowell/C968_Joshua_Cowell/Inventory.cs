using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Joshua_Cowell
{
     public class Inventory

    //Parts and Products Lists
    {
        private BindingList<Product> products = new BindingList<Product>();

        public BindingList<Product> Products
        {
            set { products = value; }
            get { return products; }
        }


        private BindingList<Part> parts = new BindingList<Part>();

        public BindingList<Part> AllParts
        {
            set { parts = value; }
            get { return parts; }
        }

        

        //Product functions

        public void addProduct(Product product)
        {
            //TODO
        }

     
        public bool removeProduct(int id)
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
      

        public void updateProduct( int id, Product product)
        {
            //TODO
        }

        //Part functions

        public void addPart(Part part)
        {
            //TODO
        }

        public bool removePart(Part part)
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
        public Part lookupPart(int id)
        {
            //TODO
        }
        */

        public void updatePart(int id, Part part)
        {
            //TODO
        }

    }
}


