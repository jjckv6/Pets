using System;
using System.Collections.Generic;

namespace Cats
{
    public class Cats
    {
        public string type;
        public string name;
        public string owner;
        public float weight;


        public string GetTag()
        {
            return String.Format("If lost, call {0}.", name);
        }

        public void meow(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write("Meow.");
            }
            Console.WriteLine("");
        }
    }
}
