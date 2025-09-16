using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Compare
{
    internal interface IComparable<T>
    {
        string CompareTo(T other);
    }
}
