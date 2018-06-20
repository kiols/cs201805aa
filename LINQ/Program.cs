using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // EF (...LINQ2Sql)

            List<int> tal = new List<int>() { 1, 7, 8, 17, 6, 4, 6 };

            var res1 = (from x in tal
                       where x < 10
                       orderby x
                       select x).ToList();

            var res2 = tal.Where(i => i < 10).OrderBy(i => i).ToList();

            var res3 = tal.OrderBy(i=>i).GroupBy(i => i);

            var lst = new PersonNuGetPackage.PersonRepositoryRandom().GetPeople(100);
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item.Name);
            //}

            var res4 = lst.Where(i => i.Height < 170 && i.Gender == PersonNuGetPackage.Gender.Female).OrderBy(i => i.Name).ThenBy(i => i.Height);

            var res5 = lst
                .OrderBy(i => i.Name)
                .Where(i => i.Height < 180)
                .GroupBy(i => i.Gender);




        }
    }
}
