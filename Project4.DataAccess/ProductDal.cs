using System;
using System.Collections.Generic;
using System.Text;
using Project4.Entitiys;

namespace Project4.DataAccess
{
   public class ProductDal:IProductDal
   {
        List<Product> _products;

        public ProductDal()
        {
            _products=new List<Product>
            {
                new Product{ProductId=1,ProductName="ac bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=2},
                new Product{ProductId=2,ProductName="asus bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=0},
                new Product{ProductId=3,ProductName="hb bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=3},
                new Product{ProductId=4,ProductName="lenovo bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=10},
                new Product{ProductId=5,ProductName="mac bilgisayar",QuantityPerUnit="32 gb",UnitPrice=10000,UnitsInStock=12}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("ado net eklendi");
        }

        public List<Product>  GetAll()
        {
            return _products;
        }
    }
}
