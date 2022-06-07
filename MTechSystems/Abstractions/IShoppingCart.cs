using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechSystems.Abstractions
{
	public interface IShoppingCart
	{
		DateTime PurchaseDate { get; }
		List<IItem> ItemList { get; set; }
		double PurchaseTotal { get; set; }

		void AddItem(IItem item);
		bool DoPurchase();
		int GetItemListCount();
		double GetPurchaseTotal();
	}
}
