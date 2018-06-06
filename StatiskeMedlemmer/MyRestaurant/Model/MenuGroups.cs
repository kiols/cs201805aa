using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Data
{
    public class MenuGroups : IEnumerable<MenuGroup>, IDataSupport<MenuGroup>
    {
        public event EventHandler CollectionChange;
        private List<MenuGroup> menuGroups;

        public MenuGroups()
        {
            menuGroups = new List<MenuGroup>();
        }

        public MenuGroup this[int index] => menuGroups[index];

        public int Count => menuGroups.Count;

        public void Clear()
        {
            menuGroups = new List<MenuGroup>();
            CollectionChange?.Invoke(this, new EventArgs());

        }

        public MenuGroup Find(int id) {
            return menuGroups.Where(i => i.MenuGroupId == id).Single();
        }

        public IEnumerator<MenuGroup> GetEnumerator()
        {
            return menuGroups.GetEnumerator();
        }

        public MenuGroup Insert(MenuGroup menuGroup)
        {
            menuGroup.MenuGroupId = this.menuGroups.Max(i => i.MenuGroupId) + 1;
            if (menuGroup.Name == null)
                throw new MyRestaurantException("Name missing");
            this.menuGroups.Add(menuGroup);
            CollectionChange?.Invoke(this, new EventArgs());

            return menuGroup;
        }

        public void Load(string path)
        {
            this.menuGroups = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MenuGroup>>(System.IO.File.ReadAllText(System.IO.Path.Combine(path, "menugroup.json")));
        }

        public void Remove(int id)
        {
            var m = menuGroups.Where(i => i.MenuGroupId == id).FirstOrDefault();
            if (m == null)
                throw new MyRestaurantException("MenuGroup does not exist");
            CollectionChange?.Invoke(this, new EventArgs());

            menuGroups.Remove(m);
        }

        public void Save(string path)
        {
            var menuGroups = Newtonsoft.Json.JsonConvert.SerializeObject(this.menuGroups.Select(i => new { MenuGroupId = i.MenuGroupId, Name = i.Name }).ToList(), Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(System.IO.Path.Combine(path, "menugroup.json"), menuGroups);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return menuGroups.GetEnumerator();
        }
    }
}
