using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Animals
{
    internal interface IAnimal
    {
        string Name { get; }
        void MakeSound();
    }
}
