using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a few guests
            Guest guest1 = new Guest("Sam", "1", "93836739", "sam56@outlook.com", "S9584736A", 200.50);
            Guest guest2 = new Guest("Nat", "2", "83759257", "nat24@gmail.com", "S8347483N", 145.20);
            Guest guest3 = new Guest("Kim", "3", "84563445", "kim62@hotmail.com", "S9182745E", 50.60);
            Guest guest4 = new Guest("Lay", "4", "94785965", "lay@connect.np.edu.sg", "T0104957Z", 70.20);
            Guest guest5 = new Guest("Ken", "5", "93857365", "ken51@gmail.com", "S9858373G", 66.50);
            Guest guest6 = new Guest("Haz", "6", "81957484", "haz9485@outlook.com", "T0204857J", 10);


            while (true)
            {
                int main_choice;
                // simple login option
                //Console.WriteLine();
                Console.WriteLine("------------Log in as------------");
                Console.WriteLine("1) Guest");
                Console.WriteLine("2) Hotel Administrator");
                Console.WriteLine("3) Exit");
                Console.WriteLine();

                // Validation to ensure the input are NUMBERS ONLY
                Console.Write("Enter choice: ");
                string main_input = Console.ReadLine();
                bool success = Int32.TryParse(main_input, out main_choice);
                if (!success)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter Integer Input only!");
                    continue;
                }

                // choosing the options
                switch (main_choice)
                {
                    case 1:
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
