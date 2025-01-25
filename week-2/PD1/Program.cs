using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
{
    internal class Program
    {
        static int maxUsers = 10;
        static string[] username=new string[maxUsers];
        static string[] password = new string[maxUsers];
        static string[] address = new string[maxUsers];
        static int[] age= new int[maxUsers];
        static int users=0;
        static void signUp()
        {
            Console.WriteLine("Welcome to Signup Page");
            Console.Write("Enter name: ");
            username[users]=Console.ReadLine();
            Console.Write("Enter password: ");
            username[users] = Console.ReadLine();
            Console.Write("Enter Address: ");
            username[users] = Console.ReadLine();
            Console.Write("Enter Age: ");
            age[users] = int.Parse(Console.ReadLine());
            users++;

        }
        static bool signIn()
        {
            Console.WriteLine("Signin page");
            Console.Write("Enter Username: ");
            string uName = Console.ReadLine();
            Console.Write("Enter password: ");
            string uPass = Console.ReadLine();
            for(int i = 0; i <= users; i++)
            {
                if (username[i] == uName && password[i] == uPass)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("Choose an option:");
            while (true)
            {
                Console.WriteLine("1.Signup");
                Console.WriteLine("2.Signin");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice: ");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        signUp();
                        break;
                    case "2":
                        if (signIn())
                        {
                            Console.WriteLine("Welcome to application");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Exiting.....");
                        return;
                    default:
                       Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
