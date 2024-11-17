using System.Threading.Channels;
using static Labb_4___OOP_V._2.OrderMenu;

namespace Labb_4___OOP_V._2
{
    public class Restaurant : Program
    {
        private List<MenuItem> _menu;        // Representerar menyn
        private Queue<Order> _orderQueue;   // Hanterar beställningar
        private Queue<Order> _orders;

        public Restaurant()
        {
            _menu = new List<MenuItem>();
            _orders = new Queue<Order>();
            _orderQueue = new Queue<Order>();
        }

        // Lägger till en ny maträtt i menyn
        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Added to menu: {menuItem}");
        }

        // Visar alla maträtter i menyn
        public void ShowMenu()
        {
            foreach (var menuItem in _menu)
            {
                Console.WriteLine($"{menuItem.Id}. {menuItem.Name} - {menuItem.Price:C}");
            }
        }

        // Lägger till en ny beställning i kön
        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine($"Order created: {order}");
        }

        // Hanterar den första beställningen i kön
        public void HandleOrder()
        {
            if (_orders.Count > 0)
            {
                Order order = _orders.Dequeue();
                Console.WriteLine($"Handled order: {order}");
            }
            else
            {
                Console.WriteLine("No orders to handle.");
            }
        }

        // Visar alla beställningar i kön
         
        public void ShowOrders()
        {
            int orderNumber = 1;
            foreach (var order in _orderQueue)
            {
                Console.WriteLine($"Order {orderNumber}:");
                decimal total = 0;

                // Hämta menyobjekt via getter-metoden
                foreach (var item in order.GetOrderItems())
                {
                    Console.WriteLine($"1 st {item.Name}");
                    total += item.Price;
                }

                Console.WriteLine($"Summa: {total:C}");

                // Hämta bordnummer via getter-metoden
                Console.WriteLine($"For Table number {order.GetTableNumber()}");
                Console.WriteLine();
                orderNumber++;
            }
        }

        // Visar beställningen som är näst i kön
        public void ShowNextOrder()
        {
            if (_orders.Count > 0)
            {
                Order nextOrder = _orders.Peek();
                Console.WriteLine($"Next order: {nextOrder}");
            }
            else
            {
                Console.WriteLine("No orders in the queue.");
            }
        }

        // Visar antalet beställningar i kön
        public void ShowOrderCount()
        {
            Console.WriteLine($"Number of orders in the queue: {_orders.Count}");
        }
        public int GetOrderCount()
        {
            return _orderQueue.Count;
        }

    }
}
