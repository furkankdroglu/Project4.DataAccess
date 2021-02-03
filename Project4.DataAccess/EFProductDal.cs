using Project4.Entitiys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class EFProductDal : IProductDal
    {
        List<Product> _products;

        public EFProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,ProductName="ac ef bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=2},
                new Product{ProductId=2,ProductName="asus ef bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=0},
                new Product{ProductId=3,ProductName="hb ef bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=3},
                new Product{ProductId=4,ProductName="lenovo ef bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=10},
                new Product{ProductId=5,ProductName="mac ef bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=12}
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("ef eklendi");
        }

        public List<Product> GetAll()
        {
            Console.WriteLine("furkan");
        }
    }
}
