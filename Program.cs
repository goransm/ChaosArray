using System;

namespace ChaosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ChaosArray<string> stringArray = new ChaosArray<string>();
            // ChaosArray<int> intArray = new ChaosArray<int>();

            for(int i = 0; i < 4; i++)
            {
                try
                {
                    stringArray.insert($"string {i}");
                }
                catch(SpaceUnavailableException)
                {
                    Console.WriteLine($"Caught a custom exception, trying to insert a string");
                }
                /*
                try
                {
                    intArray.insert(i);
                }
                catch (SpaceUnavailableException)
                {
                    Console.WriteLine($"Caught a custom exception, trying to insert a number.");
                }
                */
            }

            for(int i = 0; i < 3; i++)
            {
                try
                {
                    string stringFromChaos = stringArray.retrieve();
                    Console.WriteLine($"The retrieved string: {stringFromChaos}");
                }
                catch (ItemNotFoundException)
                {
                    Console.WriteLine($"Caught a custom exception, trying to retrieve a string.");
                }
                /*
                try
                {
                    int numberFromChaos = intArray.retrieve();
                    Console.WriteLine($"The retrieved number: {numberFromChaos}");
                }
                catch (ItemNotFoundException)
                {
                    Console.WriteLine($"Caught a custom exception, trying to retrieve a number.");
                }
                */
            }


            
            

            
        }
    }
}
