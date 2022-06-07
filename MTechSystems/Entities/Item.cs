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
		public string Name { get; set; }
		public int Amount { get; set; }
		public double Price { get; set; }
	}
}
