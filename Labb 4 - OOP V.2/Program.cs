using Labb_4___OOP_V._2;
using System;
using System.Collections.Generic;
using static Labb_4___OOP_V._2.OrderMenu;

public class Program
{
    static void Main()
    {
        // Skapa ett nytt restaurangobjekt (1)
        Restaurant restaurant = new Restaurant();

        // Lägg till fyra rätter i menyn (2)
        restaurant.AddToMenu(new MenuItem(1, "Carbonara", 129.00m));
        restaurant.AddToMenu(new MenuItem(2, "Margherita", 99.00m));
        restaurant.AddToMenu(new MenuItem(3, "Cheeseburgare", 149.00m));
        restaurant.AddToMenu(new MenuItem(4, "Caesarsallad", 89.00m));

        // Visa menyn (3)
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Meny:");
        restaurant.ShowMenu();

        Console.WriteLine("-----------------------------");
        // Skapa tre nya ordrar (4)
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

        // Visa alla aktuella ordrar (5)
        Console.WriteLine("-----------------------------");
        restaurant.ShowOrders();


        // Visa antalet ordrar i kön (6)
        Console.WriteLine("-----------------------------");
        restaurant.ShowOrderCount();

        //Visa nästa order på kö (7)
        restaurant.ShowNextOrder();

        // Hantera en order (8)
        restaurant.HandleOrder();

        // Visa antalet ordrar i kön (9)
        //Console.WriteLine("-----------------------------5");
        restaurant.ShowOrderCount();

        Console.WriteLine("-----------------------------");
        // Lägg till en ny order  (10)
        List<MenuItem> orderItems4 = new List<MenuItem>
        {
            new MenuItem(3, "Cheeseburgare", 149.00m),
            new MenuItem(4, "Caesarsallad", 89.00m)
        };
        restaurant.CreateOrder(new Order(orderItems4, 30));

        // Visa alla aktuella ordrar igen (11)
        restaurant.ShowOrderCount();

        //Hantera 2 ordrar (12)
        restaurant.HandleOrder();
        restaurant.HandleOrder();

        //Visa antalet ordrar i kön (13)
        restaurant.ShowOrderCount();

        // Visa nästa order på kö (14)
        Console.WriteLine("-----------------------------");
        restaurant.ShowNextOrder();

        // Hantera en order (15)
        restaurant.HandleOrder();

        // Visa antalet ordrar i kön (16)
        restaurant.ShowOrderCount();

    }
}

