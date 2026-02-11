// E-commerce Checkout Process Example
using System;
using System.Collections.Generic;

class CheckoutProcess
{
    static void Main()
    {
        List<string> cart = new List<string>();
        string continueShop = "yes";

        while (continueShop.ToLower() == "yes")
        {
            Console.WriteLine("Enter product name:");
            string product = Console.ReadLine();
            cart.Add(product);

            Console.WriteLine("Select another product? (yes/no):");
            continueShop = Console.ReadLine();
        }

        Console.WriteLine("Enter shipping details:");
        string shippingDetails = Console.ReadLine();

        Console.WriteLine("Select payment method (credit card/PayPal):");
        string paymentMethod = Console.ReadLine();

        Console.WriteLine("Order confirmed!");
        Console.WriteLine($"Items: {string.Join(", ", cart)}");
        Console.WriteLine($"Shipping: {shippingDetails}");
        Console.WriteLine($"Payment: {paymentMethod}");
    }
}
