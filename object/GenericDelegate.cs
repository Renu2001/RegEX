using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object1
{
    internal class GenericDelegate
    {
        public bool IsTrue(float x)
        {
            if (x > 1) 
                return true;
            else 
                return false;
        }

        public void AddNum(int a ,int b)
        {
            Console.WriteLine(a + b);
        }

        public int GetNum(int a,int b)
        {
            return a * b;
        }

        /*public static void Main(string[] args)
        {
            GenericDelegate g = new GenericDelegate();
            Predicate<float> p = g.IsTrue;
            Console.WriteLine(p.Invoke(45));
            Func<int, int, int> f = g.GetNum;
            Console.WriteLine(f(3,4));
            Action<int,int> a = g.AddNum;
            a(3,4);
        }*/
    }
}
