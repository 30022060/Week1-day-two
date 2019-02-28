using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

           Console.WriteLine("Hello User, Please enter your first name:");
            string first = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string last = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0} {1}, Age {2}", first,last,age);
            Console.WriteLine("Please enter a username");
            string user = Console.ReadLine();

            Console.WriteLine("Enter your email address");
            string email = Console.ReadLine();

            Console.WriteLine("For safety measure, we require you to enter a 4 digit PIN number.");
            Console.WriteLine("Please enter a 4 digit PIN number:");
            int PIN = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Thank you {0}, we will email {1} about your details.",user,email);
            Console.WriteLine("Have your PIN number {0} ready",PIN);
            

            Console.WriteLine("not related to anything, but can you enter a decimal number?");
            decimal randnum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0} is your unlucky number",randnum);
            Console.ReadLine();

        
        
        }   


        

    }
}
