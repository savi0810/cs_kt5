using cs_kt5.Animals;
using cs_kt5.Compare;
using cs_kt5.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5
{
    internal class Program
    {
        static void GoAnimals()
        {
            var dog = new Dog("Жучка");
            var cat = new Cat("Муся");

            Console.Write($"Собака {dog.Name} сказала: ");
            dog.MakeSound();

            Console.Write($"Кошка {cat.Name} сказала: ");
            cat.MakeSound();
        }

        static void GoShapes()
        {
            var circle = new Circle(5);
            Console.WriteLine(circle.ToString());

            var rectangle = new Rectangle(6, 9);
            Console.WriteLine(rectangle.ToString());

            var triangle = new Triangle(2, 3, 4);
            Console.WriteLine(triangle.ToString());
        }

        static void GoCompareStudents()
        {
            var st1 = new Student("Саша", 19, 3.2);
            var st2 = new Student("Саша", 16, 3.2);
            var st3 = new Student("Вася", 19, 4.1);

            Console.WriteLine("\n--- Сравнение студентов ---");
            Console.WriteLine("Первый со вторым");
            Console.WriteLine(st1.CompareTo(st2));
            Console.WriteLine("Второй с третьим");
            Console.WriteLine(st2.CompareTo(st3));
            Console.WriteLine("Первый с третьим");
            Console.WriteLine(st1.CompareTo(st3));
        }

        static void GoCompareBooks()
        {
            var b1 = new Book("Игрок", "Достоевский", 500);
            var b2 = new Book("Преступление и наказание", "Достоевский", 450);
            var b3 = new Book("Капитанская дочка", "Пушкин", 500);

            Console.WriteLine("\n--- Сравнение книг ---");
            Console.WriteLine("Первый со вторым");
            Console.WriteLine(b1.CompareTo(b2));
            Console.WriteLine("Второй с третьим");
            Console.WriteLine(b2.CompareTo(b3));
            Console.WriteLine("Первый с третьим");
            Console.WriteLine(b1.CompareTo(b3));
        }
        
        static void Main(string[] args)
        {
            int a;

            int b = 0;

            GoAnimals();
            GoShapes();
            GoCompareStudents();
            GoCompareBooks();
            // aaaaaaaaaa
        }
    }
}
