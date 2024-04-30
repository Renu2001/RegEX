using System.Text.RegularExpressions;

namespace REGEX
{
    internal class Program
    {

        public bool ValidName()
        {
            Console.WriteLine("Enter FirstName");
            string firstname = Console.ReadLine();
            string pattern = "^[A-Z][a-z]{2,}";
            Regex r = new Regex(pattern);
            if (r.IsMatch(firstname))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("User Registration UC");
            Program program = new Program();
            Console.Write(program.ValidName());
            
        }
    }
}
