using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPratice
{
    // internal eller public
    internal class BestPraticeClass
    {

        // felter = data
        private int a;  // kan kun tilgås internt

        // --------------------------------
        // nej tak - ingen offentlig felter
        // --------------------------------
        public int b;   // kan tilgås eksternt (problem....)

        // ------------------------------------------------------

        // Komplet egenskab (propfull)
        private int _felt;

        public int Felt
        {
            get {
                // validering
                // log
                // sikkerhed
                return _felt; }
            set {
                // validering
                // log
                // sikkerhed
                _felt = value; }
        }


        // ------------------------------------------------------

        // metoder - offentig = udefra
        public void MetodeA() { }
        
        // Kan kun tilgås internt
        private void MetodeB() { }

        // Default constructor
        public BestPraticeClass() : this(1,1)   // Chaining constructors
        {

        }

        // Custom
        public BestPraticeClass(int a, int b)
        {
            // kode

            // sikkerhed
            // log
            // validering
            // logik
        }

    }
}
