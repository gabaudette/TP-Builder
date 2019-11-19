using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBuilder
{
    public abstract class Aircraft
    {
        public string Name { get; protected set; }
        public Aircraft(string name)
        {
            this.Name = name;
        }
    }
}
