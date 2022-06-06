using System.ComponentModel.DataAnnotations;

namespace Food_Dash.Models
{
    public class OrderLink
    {
        [Key]
        public string OrderLinkId { get; set; }
        public string OrderId { get; set; }
        public string MenuName { get; set; }
        public int Quantity { get; set; }
    }
}
