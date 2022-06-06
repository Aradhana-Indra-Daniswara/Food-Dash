using System.Collections.Generic;

namespace Food_Dash.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public ICollection<OrderLink> OrderLinks { get; set; }
    }
}
