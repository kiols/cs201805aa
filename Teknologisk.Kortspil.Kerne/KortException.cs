using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Kortspil.Kerne
{
    public class KortException : ApplicationException
    {

        public DateTime TimeStamp { get; set; }
        

        public KortException()
        {

        }

        public KortException(string message) : base(message)
        {

        }
    }
}
