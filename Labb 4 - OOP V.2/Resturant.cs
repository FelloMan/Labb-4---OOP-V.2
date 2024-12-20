using System.Threading.Channels;
using static Labb_4___OOP_V._2.OrderMenu;

namespace Labb_4___OOP_V._2
{
    public class Restaurant : Program
    {
        private List<MenuItem> _menu;        // Representerar menyn
        private Queue<Order> _orderQueue = new Queue<Order>(); // Hanterar beställningar
        private Queue<Order> _orders;

        public Restaurant()
        {
            _menu = new List<MenuItem>();
            _orderQueue = new Queue<Order>(); // Only one queue        
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
            _orderQueue.Enqueue(order); // Add the order to the queue
            Console.WriteLine($"Order {order.GetOrderId()} has been added."); // Custom message
        }


        // Hanterar den första beställningen i kön
        public void HandleOrder()
        {           
            if (_orderQueue.Count > 0)
            {
                Order handledOrder = _orderQueue.Dequeue();
                Console.WriteLine($"Order {handledOrder.GetOrderId()} is ready.");
            }
            else
            {
                Console.WriteLine("No orders to handle.");
            }
        }


        public void ShowOrders()
        {
            Console.WriteLine(); // Print an empty line for spacing
            int orderNumber = 1; // Counter for order numbers
            Console.WriteLine("Current Orders:");

            if (_orderQueue.Count == 0)
            {
                Console.WriteLine("No orders in the queue.");
                return; // Exit early if there are no orders
            }

            foreach (var order in _orderQueue)
            {
                Console.WriteLine($"Order {orderNumber}:");
                decimal total = 0;

                foreach (var item in order.GetOrderItems())
                {
                    Console.WriteLine($"1 st {item.Name} - {item.Price:C}");
                    total += item.Price;
                }

                Console.WriteLine($"Total: {total:C}");
                Console.WriteLine($"For Table Number: {order.GetTableNumber()}");
                Console.WriteLine(); // Spacing between orders
                orderNumber++;
            }
        }




        // Visar beställningen som är näst i kön
        public void ShowNextOrder()
        {      
            if (_orderQueue.Count > 0)
            {
                Order nextOrder = _orderQueue.Peek();
                Console.WriteLine($"Next order: {nextOrder}");
            }
            else
            {
                Console.WriteLine("No orders in the queue.");
            }
            Console.WriteLine();
        }


        // Visar antalet beställningar i kön
        public void ShowOrderCount()
        {
            Console.WriteLine();
            if (_orderQueue.Count == 0)
            {
                Console.WriteLine("No new orders in queue.");
            }
            else
            {
                Console.WriteLine($"Number of orders in the queue: {_orderQueue.Count}");
            }
            Console.WriteLine();
        }

        public int GetOrderCount()
        {
            Console.WriteLine();
            return _orderQueue.Count;
        }

    }
}
