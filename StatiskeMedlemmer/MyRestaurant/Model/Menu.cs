namespace MyRestaurant.Data
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int MenuGroupId { get; set; }
        public string Name { get; set; }
        public MenuGroup MenuGroup { get; set; }
        public double Price { get; set; }
        public bool OutOfStock { get; set; }

    }
    
}
