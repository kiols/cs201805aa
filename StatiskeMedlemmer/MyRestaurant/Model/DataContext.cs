using System;
using System.Collections.Generic;
using System.Linq;

namespace MyRestaurant.Data
{
    public class DataContext : IDisposable
    {

        public MenuGroups MenuGroups { get; set; }
        public Menus Menus { get; set; }
        public Calendar Calendar { get; set; }
        private string path;
        public bool AutoSave { get; set; }

        public void Save()
        {
            this.Menus.Save(path);
            this.MenuGroups.Save(path);
            this.Calendar.Save(path);
            this.UpdateRelations();
        }

        private void Load(string path)
        {
            this.MenuGroups.Load(path);
            this.Menus.Load(path);
            this.Calendar.Load(path);
            UpdateRelations();
        }

        public void RemoveRelations() {
            foreach (var item in MenuGroups)
                item.Menus = null;
        }

        public void UpdateRelations()
        {
            for (int i = 0; i < Menus.Count; i++)
            {
                Menus[i].MenuGroup = MenuGroups.Where(x => x.MenuGroupId == Menus[i].MenuGroupId).FirstOrDefault();
            }

            foreach (var item in MenuGroups)
                item.Menus = Menus.Where(i => i.MenuGroupId == item.MenuGroupId).ToList();
        }


        public void Dispose()
        {
            if (this.AutoSave)
                this.Save();
        }

        public DataContext(string path) : this(path, false)
        {

        }

        public DataContext() : this(null, false) {
            
        }

        public DataContext(bool autoSave) : this(null, autoSave)
        {

        }

        public DataContext(string path, bool autoSave)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = System.AppDomain.CurrentDomain.BaseDirectory;                
                path = path + @"/MyRestaurant/JsonData";
            }

            this.path = path;
            this.AutoSave = autoSave;
            this.Menus = new Menus();
            this.Menus.CollectionChange += (s, e) =>
            {
                this.UpdateRelations();
            };
            this.MenuGroups = new MenuGroups();
            this.MenuGroups.CollectionChange += (s, e) =>
            {
                this.UpdateRelations();
            };

            Calendar = new Calendar();
            if (!System.IO.File.Exists(System.IO.Path.Combine(this.path, "calendar.json")))
            {
                Calendar.CreateNewCalender(360);
                Calendar.Save(this.path);
            }
            
            this.Load(path);
        }
    }

}
