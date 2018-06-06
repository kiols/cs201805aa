using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Data
{
    public class MyRestaurantException : ApplicationException
    {
        public MyRestaurantException(string message): base(message)
        {
            
        }
    }
}
