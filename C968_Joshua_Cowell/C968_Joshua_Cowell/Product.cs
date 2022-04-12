using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace C968_Joshua_Cowell
{
    public class Product
    {
        private BindingList<Part> PartList = new BindingList<Part>();

        public BindingList<Part> AssociatedParts
        {
            get { return PartList; }
            set { PartList = value; }
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public void addAssociatedPart(Part part) 
        {
            //TODO
        }
        
        public void removeAssociatedPart(int id)
        {
            //TODO
        }

        public void lookupAssociatedPart(int id)
        {
            //TODO
        }
    }
}
