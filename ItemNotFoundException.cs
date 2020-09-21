using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosArray
{
    class ItemNotFoundException : Exception
    {
        public ItemNotFoundException()
        {
            Console.WriteLine("ItemNotFoundException: item was not found.");
        }
    }
}
