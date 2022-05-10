using System.ComponentModel.DataAnnotations;

namespace Food_Dash.Models
{
    public class Menu
    {
        [Key]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
