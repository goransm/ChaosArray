using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosArray
{
    class SpaceUnavailableException : Exception
    {
        public SpaceUnavailableException() {
            Console.WriteLine("SpaceUnavailableException: space is unavailable.");
        }

    }
}
