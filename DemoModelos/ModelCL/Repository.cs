using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Repository
    {
        public Product GetProductByID(int ID)
        {
            var Context = new NORTHWNDEntities();
            return Context.Products.FirstOrDefault(p => p.ProductID == ID);
        }

        public List<Product> GetProducts()
        {
            List<Product> Result = null;
            using (var Context = new NORTHWNDEntities())
            {
                Result = Context.Products.ToList();
            }
            return Result;
        }

        List<Product> Products = new List<Product>
        {
            new Product{
                ProductID = 1, ProductName = "Azucar",
                UnitPrice = 10, UnitsInStock = 20
            },
            new Product{
                ProductID = 2, ProductName = "Leche",
                UnitPrice = 10, UnitsInStock = 20
            },
            new Product{
                ProductID = 3, ProductName = "Frijol",
                UnitPrice = 10, UnitsInStock = 20
            },
            new Product{
                ProductID = 4, ProductName = "Queso",
                UnitPrice = 10, UnitsInStock = 20
            },
            new Product{
                ProductID = 5, ProductName = "Mantequilla",
                UnitPrice = 10, UnitsInStock = 20
            },
        };

    }
}
