using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set = new Set();
            set.Elements = new List<int>(new int[] { 1, 2, 3, 4 });
            set.Count = 4;
            Set set2 = new Set();
            set2.Elements = new List<int>() { 1, 2, 3, 4 };
            Set set0 = new Set();
            set0.Elements = new List<int>() { 0, -2, -23, 5, 1 };
            set.Add(5);
            set0.Remove(5);
            set0.Print();
            Console.WriteLine("Первый список: ");
            set.Print();
            Console.WriteLine("Второй список: ");
            set2.Print();
            Set set3 = new Set();
            Console.WriteLine("Результат объединения списков: ");
            set3 = set.Union(set2);
            set3.Print();
            Console.WriteLine("Результат пересечения списков: ");
            set3 = set.Intersect(set2);
            set3.Print();
            Console.WriteLine("Результат разности списков: ");
            set3 = set.Except(set2);
            set3.Print();
            Console.WriteLine("Результат симметрической разности списков: ");
            set3 = set.SymmetricDifference(set2);
            set3.Print();
            set2.IsSubsetOf(set);

            Console.ReadKey();
        }
    }
}
