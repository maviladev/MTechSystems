using MTechSystems.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechSystems.Entities
{
	public class ShoppingCart : IShoppingCart
	{
		public DateTime PurchaseDate { get; private set; }
		public List<IItem> ItemList { get; private set; }
		public double PurchaseTotal { get; set; }
		public ShoppingCart()
		{
			PurchaseDate = DateTime.Now;
			ItemList = new List<IItem>();
		}

		public void AddItem(IItem item)
		{
			ItemList.Add(item);
			PurchaseTotal += item.Total;
		}

		public void DoPurchase()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Fecha Compra: {PurchaseDate}");
			sb.AppendLine($"Total de Compra: {PurchaseTotal}");
			sb.AppendFormat("{0,-20}{1,-10}{2,-10}{3,-10}","Artículo","Cantidad","Precio","Importe").AppendLine();
			ItemList.ForEach(i => sb.AppendFormat("{0,-20}{1,-10}{2,-10}{3,-10}", i.Name,i.Amount, i.Amount, i.Amount * i.Price).AppendLine());
			Console.WriteLine(sb.ToString());
		}

		public int GetItemListCount()
		{
			return ItemList.Count;
		}

		public double GetPurchaseTotal()
		{
			return PurchaseTotal;
		}
	}
}
