using System;
using System.Collections.Generic;

namespace Pets
{
    public class Pets
    {
        public string type;
        public string name;
        public string owner;
        public float weight;

 
        public string GetTag()
        {
            return String.Format("If lost, call {0}.", name);
        }
    }
}
