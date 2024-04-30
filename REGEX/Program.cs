using System.Text.RegularExpressions;

namespace REGEX
{
    internal class Program
    {

        public void ValidName(string name)
        {
            string pattern = "^[A-Z][a-z]{2,}";
            Regex r = new Regex(pattern);
            if (r.IsMatch(name))
                Console.WriteLine("Valid Name");
            else
                Console.WriteLine("First letter should be capital and Minimum 3 characters");
        }

        public void ValidEmail(string name)
        {
            string pattern = "\\w+.(\\w+)?@\\w+.(\\w+){2,3}.((\\w+){2,3})?";
            Regex r1 = new Regex(pattern);
            if (r1.IsMatch(name))
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("Invalid");
        }

        public void ValidPhoneNo(string name)
        {
            string pattern = @"\+\d{2}\s[0-9]{10}";
            Regex r1 = new Regex(pattern);
            if (r1.IsMatch(name))
                Console.WriteLine("Valid Number");
            else
                Console.WriteLine("Invalid");
        }

        public void ValidPassword(string name)
        {
            var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+={}[\]\\|:;<>,.?/]).{8,}$";
            Regex r1 = new Regex(pattern);
            if (r1.IsMatch(name))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("User Registration UC");
            Program program = new Program();
            Console.WriteLine("Enter FirstName");
            string firstname = Console.ReadLine();
            program.ValidName(firstname);
            Console.WriteLine("Enter LastName");
            string lastname = Console.ReadLine();
            program.ValidName(lastname);
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            program.ValidEmail(email);
            Console.WriteLine("Enter Phone No");
            string phoneno = Console.ReadLine();
            program.ValidPhoneNo(phoneno);
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            program.ValidPassword(password);

        }
    }
}
