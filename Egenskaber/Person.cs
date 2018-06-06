namespace Egenskaber
{
    public class Person
    {
        //// NEJ NEJ
        //public int Alder;


        private string _navn;

        public string Navn
        {
            get
            {
                return _navn;
            }
            set
            {
                _navn = value;
            }
        }

        private int _alder;

        public int Alder
        {
            get
            {
                //....
                return _alder;
            }
            set
            {
                if (value < 0 || value > 110)
                    value = 0;
                _alder = value;
            }
        }
        
        private string _adresse;

        public string Adresse
        {
            get {

                return _adresse; }
            set {
                if (value == null)
                    value = "";
                _adresse = value; }
        }


        public string NavnMedStort()
        {
            return _navn.ToUpper();
        }

    }

}
