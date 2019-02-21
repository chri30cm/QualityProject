using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class SaleOrderLine
    {
		public string Product { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }

		public SaleOrderLine(string product, int quantity, int price)
		{
			Product = product;
			Quantity = quantity;
			Price = price; 
		}
			

	}
}
