using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public CategoryType CategoryType { get; set; }
        public float Price { get; set; }
        //VAT as 0.06 or 0.21
        public float VAT { get; set; }
        public float PriceWithVAT 
        { 
            get
            {
                return Price + (Price * VAT);
            } 
        }
        public string Description { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
