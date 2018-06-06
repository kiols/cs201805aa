using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Data
{
    public class Calendar : IDataSupport<CalendarDay>, IEnumerable<CalendarDay>
    {
        private List<CalendarDay> calendar;

        public CalendarDay Find(int id)
        {
            return calendar.Where(i => i.CalendarDayId == id).Single();
        }

        public Calendar()
        {
            calendar = new List<CalendarDay>();
        }
        public CalendarDay this[int index] => calendar[index];

        public int Count => calendar.Count;

        public event EventHandler CollectionChange;

        public List<CalendarDay> NextWeek()
        {
            return this.calendar.Where(i => i.OpenAt > DateTime.Now.Date && i.OpenAt < DateTime.Now.Date.AddDays(7)).ToList();
        }

        public List<CalendarDay> NextMonth()
        {
            DateTime start = new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1);
            DateTime end = start.AddMonths(1);
            return this.calendar.Where(i => i.OpenAt > start && i.OpenAt < end).ToList();
        }

        public void Clear()
        {
            calendar = new List<CalendarDay>();
            CollectionChange?.Invoke(this, new EventArgs());
        }

        public IEnumerator<CalendarDay> GetEnumerator()
        {
            return calendar.GetEnumerator();
        }

        public CalendarDay Insert(CalendarDay d)
        {
            throw new MyRestaurantException("You cannot create a day in the calendar");
        }

        public void Load(string path)
        {
            this.calendar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CalendarDay>>(System.IO.File.ReadAllText(System.IO.Path.Combine(path, "calendar.json")));
        }

        public void Remove(int id)
        {
            throw new MyRestaurantException("You cannot remove a day from the calendar");
        }

        public void Save(string path)
        {
            var r = Newtonsoft.Json.JsonConvert.SerializeObject(this.calendar, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(System.IO.Path.Combine(path, "calendar.json"), r);

        }

        public void CreateNewCalender(int days)
        {
            Clear();
            DateTime d = DateTime.Now.Date;
            for (int i = 0; i < days; i++)
            {
                d = d.AddDays(1);
                DateTime start = DateTime.MinValue;
                DateTime end = DateTime.MinValue;
                bool open = false;
                string desc = null;

                start = d.AddHours(18);
                end = d.AddHours(22);
                open = true;

                if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
                {
                    start = d.AddHours(15);
                    end = d.AddHours(23);
                    open = true;
                }
                if (d.DayOfWeek == DayOfWeek.Monday)
                {
                    open = false;
                    desc = "Closed (monday)";
                }

                if (d.Month == 11 && d.Day == 24)
                {
                    open = false;
                    desc = "Closed (Christmas)";
                }

                if (d.Month == 12 && d.Day == 25)
                {
                    open = false;
                    desc = "Closed (Christmas)";
                }

                if (d.Month == 12 && d.Day == 31)
                {
                    open = false;
                    desc = "Closed";
                }

                calendar.Add(new CalendarDay() { CalendarDayId = i + 1, OpenAt = start, CloseAt = end, OpenForPublic = open, OptionalDescription = desc });

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return calendar.GetEnumerator();
        }
    }
}
