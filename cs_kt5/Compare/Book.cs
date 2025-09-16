using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Compare
{
    internal class Book : Entity
    {
        public string Title { get; }
        public string Author { get; }
        public double Price { get; }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        protected override IEnumerable<object> GetComparisonComponents()
        {
            yield return Title;
            yield return Author;
            yield return Price;
        }
    }
}
