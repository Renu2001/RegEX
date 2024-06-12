using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class StringProblem
    {
        public static string CapitalWord(string input)
        {
            string word = input;
           
            string newword = word.Substring(0,1).ToUpper() + word.Substring(1);
            
            return newword;
           
        }
        public static void Main(string[] args)
        {

            string result = CapitalWord("ddjksdxxD");
            Console.WriteLine(result);

        }
    }
}
