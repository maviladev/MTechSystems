using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechSystems.Abstractions
{
	public interface IItem
	{
		string Name { get; set; }
		int Amount { get; set; }
		double Price { get; set; }
	}
}
