using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using ICT13580575EndB.Models;

namespace ICT13580575EndB.Helper
{
	public class DbHelper
	{
		SQLiteConnection db;

		public DbHelper(String dbPath)

		{
			db = new SQLiteConnection(dbPath);
			db.CreateTable<Product>();
		}

		public int AddProduct(Product product)
		{
			db.Insert(product);
			return product.Id;
		}


		public List<Product> GetProducts()
		{
			return db.Table<Product>().ToList();
		}
		public int UpdateProduct(Product product)
		{
			return db.Update(product);
		}
		public int DeleteProduct(Product product)
		{
			return db.Delete(product);
		}
	}
}