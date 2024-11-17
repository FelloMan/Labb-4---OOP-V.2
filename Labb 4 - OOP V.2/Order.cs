using Microsoft.VisualBasic;

namespace Labb_4___OOP_V._2
{
    public class OrderMenu : Program
    {
        public class Order
        {
            private static int _orderIdCounter = 1;
            private int _orderId;
            private List<MenuItem> _orderItems;
            private int _tableNumber;

            public Order(List<MenuItem> orderItems, int tableNumber)
            {
                _orderId = _orderIdCounter++;
                _orderItems = orderItems;
                _tableNumber = tableNumber;
            }

            // Visar den information om en order, inklusive order - ID, bordnummer, beställda varor och totalpris.
            public override string ToString()
            {
                string result = $"Order ID: {_orderId}, Table Number: {_tableNumber}\n";
                decimal total = 0;

                foreach (var item in _orderItems)
                {
                    result += $"1 st {item.Name} - {item.Price:C}\n";
                    total += item.Price;
                }

                result += $"Total: {total:C}\n";
                return result;
            }

            // Getter för order-id
            public int GetOrderId()
            {
                return _orderId;
            }

            // Getter för menyobjekten
            public List<MenuItem> GetOrderItems()
            {
                return _orderItems;
            }

            // Getter för bordnummer
            public int GetTableNumber()
            {
                return _tableNumber;
            }
        }
    }
}
 
