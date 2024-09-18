using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_18_09_24
{
    public class ShoppingCart
    {
        private List<Product> products { get; set; }

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void Add_Product(Product product)
        {
            products.Add(product);
            Console.WriteLine(product.tensp + " duoc them vao gio hang");
        }

        public void Remove_Product(Product product)
        {
            products.Remove(product);
            Console.WriteLine(product.tensp + " da xoa khoi gio hang");
        }

        public void DisplayCart()
        {
            Console.WriteLine("San pham trong gio hang:");
            foreach (var product in products)
            {
                product.hienthi();
                Console.WriteLine();
            }
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.gia * product.soluong;
            }
            return total;
        }
    }
}
