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
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int id)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == id)
                {
                    AssociatedParts.Remove(AssociatedParts[i]);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int id)
        {
            Part result = null;
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == id)
                {
                    _ = AssociatedParts[i];

                }
            }
            return result;
        }

    }
}