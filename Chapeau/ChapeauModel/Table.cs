using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        //class for restaurant view.
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public bool IsOccupied { get; set; } //if false it's not occupied if it's occupied it's true.

        public Table(){}

        public Table(int TableNumber)
        {
            this.TableNumber = TableNumber;
        }
    }

    
}
