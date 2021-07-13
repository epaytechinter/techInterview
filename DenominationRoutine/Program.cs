using System;

namespace DenominationRoutine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void DenominationRoutine(int amount)
        {
            int tenCount = amount / 10;

            var tenTempRemainder = 0;
            var fiftyTempRemainder = 0;
            var tenOutput = "";
            var fiftyOutput = "";

            Console.WriteLine(tenCount + "*10" + "EUR");

            var fiftyCount = tenCount / 5;
            while (fiftyCount >= 1)
            {
                tenTempRemainder = (amount - (fiftyCount * 50)) / 10;

                tenOutput = tenTempRemainder > 0 ? "+ " + tenTempRemainder + "*10" + "EUR " : "";

                Console.WriteLine(fiftyCount + "*50" + "EUR " + tenOutput);

                fiftyCount--;
            }

            var hundredCount = tenCount / 10;
            while (hundredCount >= 1)
            {
                fiftyTempRemainder = (amount - hundredCount * 100) / 50;

                tenTempRemainder = fiftyTempRemainder > 0 ? (amount - (fiftyTempRemainder * 50 + hundredCount * 100)) / 10 : (amount - (hundredCount * 100)) / 10;

                fiftyOutput = fiftyTempRemainder > 0 ? "+ " + fiftyTempRemainder + "*50" + "EUR " : "";

                tenOutput = tenTempRemainder > 0 ? "+ " + tenTempRemainder + "*10" + "EUR " : "";

                Console.WriteLine(hundredCount + "*100" + "EUR  " + fiftyOutput + tenOutput);

                hundredCount--;
            }

        }
    }
}
