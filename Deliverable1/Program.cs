// See https://aka.ms/new-console-template for more information
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the restocking tool.");
        int sodaStock = 100;
        int chipStock = 40;
        int candyStock = 60;
        Console.WriteLine($"How many sodas have been sold today? {sodaStock} are in stock.");
        int sodaSold = int.Parse(Console.ReadLine());

        
        if (sodaSold <= sodaStock)
        {
            sodaStock = sodaStock - sodaSold;

            Console.WriteLine($"There are  {sodaStock}  sodas left.");
        }
        else
        {
            Console.WriteLine("The value is too high. Stock not adjusted.");
        }

        Console.WriteLine($"How many Chips have been sold today? {sodaStock} are in stock.");

        int chipSold = int.Parse(Console.ReadLine());
        
        if (chipSold <= chipStock)
        {
            chipStock = chipStock - chipSold;
            Console.WriteLine($"There are  {chipStock}  chips left.");
        }
        else
        {
            Console.WriteLine("The value is too high. Stock not adjusted.");
        }

        Console.WriteLine($"How many Candy have been sold today? {candyStock} are in stock.");

        int candySold = int.Parse(Console.ReadLine());
        
        if (candySold <= candyStock)
        {
            candyStock = candyStock - candySold;
            Console.WriteLine($"There are  {candyStock}  candies left.");
        } 
        else
        {
            Console.WriteLine("The value is too high. Stock not adjusted.");
        }
        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
        int sodaRestock = 40;
        int chipRestock = 20;
        int candyRestock = 40;
        
        if (sodaStock <= sodaRestock) {
            Console.WriteLine("Soda needs to be restocked");
        }
        
        if (chipStock <= chipRestock)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
       
        if (candyStock <= candyRestock)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }

        Console.WriteLine("Goodbye!");
        
    }
}
