namespace MCronberg
{

    using System;

    public class RandomEx
    {
        private static System.Random rnd = new Random();

        public static int RandomInt(int minIncludedValue, int maxIncludedValue)
        {
            return rnd.Next(minIncludedValue, maxIncludedValue + 1);
        }

        public static bool RandomBool()
        {
            int v = rnd.Next(1, 101);
            if (v <= 50)
                return true;
            else
                return false;
        }

     
        public static int RandomDice()
        {
            return RandomInt(1, 6);
        }

    }
}
