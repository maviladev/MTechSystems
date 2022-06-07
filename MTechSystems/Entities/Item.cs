using MTechSystems.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechSystems.Entities
{
    public class Item : IItem
    {
        private int amount;
        private double price;

        public string Name { get; set; }
        public int Amount
        {
            get => amount; 
            set
            {
                amount = value;
                UpdateTotal();
            }
        }
        
        public double Price
        {
            get => price;
            set
            {
                price = value;
                UpdateTotal();
            }
        }
        public double Total { get; set; }

        public Item()
        {

        }

        private void UpdateTotal() 
        {
            Total = amount * price;
        }
    }
}
