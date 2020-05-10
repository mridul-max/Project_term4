using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    class MenuItem
    {
        int ID;
        public string Name { get; private set; }
        public string Category { get; private set; }
        public float Price { get; private set; }
        public string description;
        public int stock;
    }
}
