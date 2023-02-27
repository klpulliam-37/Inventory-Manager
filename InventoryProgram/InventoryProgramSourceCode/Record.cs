using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram
{
    // Class responsible for storing the data the 
    // user inputs into the item insertion form.
    [Serializable]
    public class Record
    {
        public Record() { }
        public Record(int id, string name, double price, int quantity) { }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
