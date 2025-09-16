using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Compare
{
    internal abstract class Entity : IComparable<Entity>
    {
        protected abstract IEnumerable<object> GetComparisonComponents();

        public string CompareTo(Entity other)
        {
            if (other == null)
                return "Другой объект не существует";

            if (this.GetType() != other.GetType())
                return "Объекты разного типа не могут быть сравнены";

            var thisComponents = GetComparisonComponents().ToArray();
            var otherComponents = other.GetComparisonComponents().ToArray();

            if (thisComponents.Length != otherComponents.Length)
                return "Объекты имеют разное количество свойств для сравнения";

            int matchedCount = 0;
            for (int i = 0; i < thisComponents.Length; i++)
            {
                if (object.Equals(thisComponents[i], otherComponents[i]))
                    matchedCount++;
            }

            return $"{matchedCount} свойства совпали";
        }
    }
}
