using Project4.Entitiys;
using System;
using System.Collections.Generic;
using System.Text;
using Project4.DataAccess;

namespace Project4.Business
{
   public class ProductManager
   {
       public List<Product> GetAll()
       {
            EFProductDal ProductDal=new EFProductDal();
            return ProductDal.GetAll();
       }
   }
}
