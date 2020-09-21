using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosArray
{
    class ChaosArray<T>
    {
        private T[] items = new T[10];
        private Random random = new Random();
        public void insert(T item)
        {
            int pos = random.Next(10);
            T existingItem = items[pos];
            if(existingItem != null)
            {
                Console.WriteLine($"Trying to insert {item} into pos {pos}");
                throw new SpaceUnavailableException();
            } else
            {
                Console.WriteLine($"Inserting {item} into pos {pos}");
                items[pos] = item;
            }
            
        }

        public T retrieve()
        {
            T item = items[random.Next(10)];
            if (item == null)
            {
                throw new ItemNotFoundException();
            }
            return item;
        }

    }
}
