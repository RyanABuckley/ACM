using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retreive(int productID)
        {
            Product product = new Product(productID);

            if (productID == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "They're kinda yellow!";
                product.CurrentPrice = 15.96M;
            }
            object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //save
                    }
                    else
                    {
                        //update
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

    }
}
