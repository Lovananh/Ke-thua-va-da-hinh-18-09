using System;
using bai_tap_18_09_24;
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một số sản phẩm mẫu
        Electronic laptop = new Electronic("Laptop", 1500, "High performance laptop", 1, 24);
        Clothing tshirt = new Clothing("T-Shirt", 25, "Cotton T-Shirt", 2, "L", "Blue");
        Food apple = new Food("Apple", 1, "Fresh apple", 5, DateTime.Now.AddDays(7));

        // Tạo giỏ hàng và thêm sản phẩm vào giỏ
        ShoppingCart cart = new ShoppingCart();
        cart.Add_Product(laptop);
        cart.Add_Product(tshirt);
        cart.Add_Product(apple);

        // Hiển thị giỏ hàng và tính tổng giá trị đơn hàng
        cart.DisplayCart();
        Console.WriteLine($"Tong gia don hang: {cart.CalculateTotal()}");
    }
}
