using System;

class Program {
  public static void Main (string[] args) {
     Console.WriteLine("Enter the name of item.");
     string item = Console.ReadLine();
    Console.WriteLine ("Enter the quantity.");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter the price.");
    double price = Convert.ToDouble(Console.ReadLine());
   double total = (quantity * price); //tp total price
    Console.WriteLine("Total price of " + item + " =$ " + total);
  }
}