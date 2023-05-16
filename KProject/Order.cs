
namespace KProject
{
    public class Order : IComparable<Order>
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string DepartureCity { get; set; } = string.Empty;
        public string DeliveryCity { get; set; } = string.Empty;

        public Person Recipient { get; set; }
        public Person Sender { get; set; }

        public int Weight { get; set; }
        public float ShippingCost { get; set; }
        public float Payment { get; set; }
        public OrderType OrderType { get; set; }

        public Order(Person recipient, Person sender)
        {
            Recipient = recipient;
            Sender = sender;
        }

        public float CalcShippingCost()
        {
            return CalcShippingCost(Payment, Weight);
        }

        public void ChangeOrderType(OrderType? type)
        {
            switch (type)
            {
                case OrderType.CANCELED:
                    OrderType = OrderType.CANCELED;
                    break;
                case OrderType.ON_THE_ROAD:
                    OrderType = OrderType.ON_THE_ROAD;
                    break;
                case OrderType.DELIVERED:
                    OrderType = OrderType.DELIVERED;
                    DeliveryDate = DateTime.Now;
                    break;
                case OrderType.RECEIVED: 
                    OrderType = OrderType.RECEIVED;
                    ReceivedDate = DateTime.Now;
                    break;
            }
        }

        public static float CalcShippingCost(float payment, int weight)
        {
            float cost = 50;
            if (payment > 0)
                cost += payment * 0.01F;

            cost += weight * 1.25F;
            return cost;
        }

        public int CompareTo(Order? other)
        {
            if (other == null)
                return 0;

            return DepartureDate.CompareTo(other.DepartureDate);
        }
    }
}
