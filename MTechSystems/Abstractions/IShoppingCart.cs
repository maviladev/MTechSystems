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
		List<IItem> ItemList { get; }
		double PurchaseTotal { get; set; }

		void AddItem(IItem item);
		void DoPurchase();
		int GetItemListCount();
		double GetPurchaseTotal();
	}
}
