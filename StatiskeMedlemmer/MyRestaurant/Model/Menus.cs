using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Data
{
    public class Menus : IEnumerable<Menu>, IDataSupport<Menu>
    {
        private List<Menu> menus;
        public event EventHandler CollectionChange;

        public Menu Find(int id)
        {
            return menus.Where(i => i.MenuId == id).Single();
        }

        public Menus()
        {
            menus = new List<Menu>();
        }

        public Menu this[int index]
        {
            get
            {
                return menus[index];
            }
        }

        public int Count
        {
            get
            {
                return this.menus.Count;
            }
        }

        public void Remove(int id)
        {
            var m = menus.Where(i => i.MenuId == id).FirstOrDefault();
            if (m == null)
                throw new MyRestaurantException("Menu does not exist");
            menus.Remove(m);
            CollectionChange?.Invoke(this, new EventArgs());
        }

        public void Clear()
        {
            menus = new List<Menu>();
            CollectionChange?.Invoke(this, new EventArgs());
        }

        public Menu Insert(Menu menu)
        {
            menu.MenuId = this.menus.Max(i => i.MenuId) + 1;
            if (menu.MenuGroupId == 0)
                throw new MyRestaurantException("MenuGroup missing");
            if (menu.Name == null)
                throw new MyRestaurantException("Name missing");
            this.menus.Add(menu);
            CollectionChange?.Invoke(this, new EventArgs());
            return menu;
        }

        public void Load(string path)
        {
            this.menus = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Menu>>(System.IO.File.ReadAllText(System.IO.Path.Combine(path, "menu.json")));
        }

        public void Save(string path)
        {
            var menus = Newtonsoft.Json.JsonConvert.SerializeObject(this.menus.Select(i => new { MenuId = i.MenuId, Name = i.Name, MenuGroupId = i.MenuGroupId, Price = i.Price }).ToList(), Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(System.IO.Path.Combine(path, "menu.json"), menus);
        }

        public IEnumerator<Menu> GetEnumerator()
        {
            return menus.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return menus.GetEnumerator();
        }
    }
}
