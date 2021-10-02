using System;
using System.Collections.Generic;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();


            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Select number for buy flower");
                Console.WriteLine("------------------------------------------------");
                foreach (string i in flowerStore.flowerList)
                
                {
                    Console.Write("Select ");
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + "");
                    Console.WriteLine(i);
                }
                Console.Write("input your number : ");
                selectFlower = Console.ReadLine();
                switch (selectFlower)
                {
                    case "1":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added" + flowerStore.flowerList[0]);
                        break;

                    case "2":
                        flowerStore.addToCart(flowerStore.flowerList[1]);
                        Console.WriteLine("Added" + flowerStore.flowerList[1]);
                        break;

                    default:
                        Console.WriteLine("Not Added to cart.found select number of flower");
                        break;
                }
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("You can stop this progess ?");
                Console.WriteLine("- exit     for >> exit  << progess ");
                Console.WriteLine("- Continue for >> press << progess");
                Console.Write("Exit or Press : ");
                decide = Console.ReadLine();

                if(decide == "exit") 
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Current my cart");
                    flowerStore.showCart();
                }
            }

            while (decide != "exit");
        }
    }
    class FlowerStore 
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();

        public FlowerStore() 
        {
            flowerList.Add(" Rose");
            flowerList.Add(" Lotus");
        }

        public void addToCart(string name) 
        {
            cart.Add(name);
        }

        public void showCart() 
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else 
            {
                Console.Write("My Cart : ");
                foreach (string i in cart) 
                {
                    Console.Write(i);
                }
            }
        }
    }
}
