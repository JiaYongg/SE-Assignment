using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class Admin
    {
        private string adminID;
        private string adminPass;
        public string AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        public string AdminPass
        {
            get { return adminPass; }
            set { adminPass = value; }
        }
        public Admin(string aid, string apass)
        {
            adminID = aid;
            adminPass = apass;
        }
        public void registerGuest(List<Guest> gList)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter NRIC: ");
            string nric = Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string contact = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Guest g = new Guest(name, Convert.ToString(gList.Count + 1), contact, email, nric, 0);
            gList.Add(g);

            Console.WriteLine("Guest Successfully Registered");

        }
    }
}
