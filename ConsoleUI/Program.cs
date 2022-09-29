using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Net.Http.Headers;
//SOLID
//O : Open Closed Principle
class Program
{
	static void Main(string[] args)
	{
		ProductManager productManager = new ProductManager(new EfProductDal());

		foreach(var item in productManager.GetAllByCategoryId(2)) 
		{
			Console.WriteLine(item.ProductName);
		}

	}
}