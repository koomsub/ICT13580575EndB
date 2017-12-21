using System;
using SQLite;
namespace ICT13580575EndB.Models
{
    public class Product
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[NotNull]
		[MaxLength(200)]
		public string CateoryCar { get; set; }
		public string Brand { get; set; }
		public string Grand { get; set; }

		[NotNull]
		[MaxLength(100)]
		public string Year { get; set; }

		public decimal Km { get; set; }
		public string Color { get; set; }
		public string Delor { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Province { get; set; }
		public string Numberphone { get; set; }
    }
}
