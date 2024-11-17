using Labb_4___OOP_V._2;
using System;
using System.Collections.Generic;
using static Labb_4___OOP_V._2.OrderMenu;

public class Program
{
    static void Main()
    {
        // Skapa ett nytt restaurangobjekt
        Restaurant restaurant = new Restaurant();

        // Lägg till fyra rätter i menyn
        restaurant.AddToMenu(new MenuItem(1, "Carbonara", 129.00m));
        restaurant.AddToMenu(new MenuItem(2, "Margherita", 99.00m));
        restaurant.AddToMenu(new MenuItem(3, "Cheeseburgare", 149.00m));
        restaurant.AddToMenu(new MenuItem(4, "Caesarsallad", 89.00m));

        // Visa menyn
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Meny:");
        restaurant.ShowMenu();

        Console.WriteLine("-----------------------------");
        // Skapa tre nya ordrar
        List<MenuItem> orderItems1 = new List<MenuItem>
        {
            new MenuItem(1, "Carbonara", 129.00m),
            new MenuItem(3, "Cheeseburgare", 149.00m)
        };
        restaurant.CreateOrder(new Order(orderItems1, 23));

        List<MenuItem> orderItems2 = new List<MenuItem>
        {
            new MenuItem(2, "Margherita", 99.00m),
            new MenuItem(3, "Cheeseburgare", 149.00m),
            new MenuItem(4, "Caesarsallad", 89.00m)
        };
        restaurant.CreateOrder(new Order(orderItems2, 25));

        List<MenuItem> orderItems3 = new List<MenuItem>
        {
            new MenuItem(1, "Carbonara", 129.00m),
            new MenuItem(2, "Margherita", 99.00m),
            new MenuItem(2, "Margherita", 99.00m)
        };
        restaurant.CreateOrder(new Order(orderItems3, 28));

        // Visa alla aktuella ordrar

        Console.WriteLine("Current Orders:");
        restaurant.ShowOrders();

        // Visa antalet ordrar i kön
        Console.WriteLine("-----------------------------");
        restaurant.ShowOrderCount();

        // Hantera en order
        restaurant.HandleOrder();

        // Visa antalet ordrar i kön igen
        Console.WriteLine("-----------------------------");
        restaurant.ShowOrderCount();

        // Lägg till en ny order
        List<MenuItem> orderItems4 = new List<MenuItem>
        {
            new MenuItem(3, "Cheeseburgare", 149.00m),
            new MenuItem(4, "Caesarsallad", 89.00m)
        };
        restaurant.CreateOrder(new Order(orderItems4, 30));

        // Visa alla aktuella ordrar igen
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Currently Active Orders: {restaurant.GetOrderCount()}");
        restaurant.ShowOrders();


    }
}

