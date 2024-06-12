using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object1
{
    public delegate void AddNum(int num, int num2);
    public delegate string Fullname(string str,string str2);
    internal class Delegate1
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine(a+ b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }


        public string Fname(string fname ,string lname)
        {
            return fname + lname;
        }
        public string Address(string Add1, string city)
        {
            return Add1 + city + "this is add";
        }

       /* public static void Main(string[] args)
        {
            Delegate1 p =new Delegate1();
            AddNum a = Add;
            a += Multiply;
            a.Invoke(2, 3);
            Fullname f = p.Fname;
            f += p.Address;
            Console.WriteLine(f("Renu", "Bagave"));

        }*/
    }
}
