using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    public class Vandpumpe
    {

        private int _styrke;

        public int Styrke
        {
            get { return _styrke; }
            private set {
                if (value > 10)
                    value = 10;
                _styrke = value; }
        }

        //public int Styrke { get; private set; }



        public void Start() { }
        public void Stop() { }

        public Vandpumpe()
        {
            Styrke = 10;
        }

        public Vandpumpe(int styrke)
        {
            
            Styrke = styrke;
        }


    }
}
