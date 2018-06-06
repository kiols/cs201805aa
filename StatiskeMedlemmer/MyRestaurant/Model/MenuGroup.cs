using System.Collections.Generic;

namespace MyRestaurant.Data
{
    public class MenuGroup
    {
        public int MenuGroupId { get; set; }
        public string Name { get; set; }
        public List<Menu> Menus { get; set; }
    }

}
