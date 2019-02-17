using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5
{
    public class Set
    {

        public List<int> Elements;
        public int Count { get; set; }


        public Set()
        {
            Elements = new List<int>();
            Count = 0;
        }

        public void Add(int newVal)
        {
            bool n = false;
            for (int j = 0; j < this.Count; j++)
            {
                if (this.Elements[j] == newVal)
                {
                    n = true;
                }
            }
            if (n == false)
            {
                this.Elements.Add(newVal);
            }
        }

        public void Remove(int newVal)
        {
            Elements.Remove(newVal);
        }

        public void Print()
        {
            foreach (int element in this.Elements)
            {
                Console.Write($"{ element }  ");
            }
            Console.WriteLine();
        }


        public Set Union(Set set2)
        {
            Set set3 = new Set();
            IEnumerable<int> ElFin = this.Elements.Union(set2.Elements);
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public Set Intersect(Set set2)
        {
            Set set3 = new Set();
            IEnumerable<int> ElFin = Elements.Intersect(set2.Elements);
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public Set Except(Set set2)
        {
            Set set3 = new Set();
            IEnumerable<int> ElFin = Elements.Except(set2.Elements);
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public Set SymmetricDifference(Set set2)
        {
            Set set3 = new Set();
            IEnumerable<int> ElFin = Elements.Union(set2.Elements).Except(Elements.Intersect(set2.Elements));
            set3.Elements.AddRange(ElFin);
            return set3;
        }

        public bool IsSubsetOf(Set set)
        {

            int count = 0;
            for (int i = 0; i < Elements.Count; ++i)
            {
                for (int j = 0; j < Elements.Count; ++j)
                {
                    if (Elements[i] == set.Elements[j])
                    {
                        ++count;
                        //Console.WriteLine("A element of the set belongs to a set");
                    }
                }
            }

            if (count == Elements.Count)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

       
    }
}



            
       
 

