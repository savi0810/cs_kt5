using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Animals
{
    internal abstract class Animal : IAnimal
    {
        public string Name { get; protected set; }

        protected Animal(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя не может быть пустым", nameof(name));

            Name = name;
        }

        public abstract void MakeSound();
    }
}
