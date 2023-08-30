using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    //An abstract class for employee attributes and methods to be implemented as per role
    public abstract class RestaurantEmployees
    {
        public static List<RestaurantEmployees> EmpList= new List<RestaurantEmployees>();
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        //constructor

        public RestaurantEmployees() { }

        public RestaurantEmployees(int empid, string empname)
        {
            EmpId = empid;
            EmpName = empname;
        }


        public static void AddEmployee(RestaurantEmployees emp)
        {
            EmpList.Add(emp);
        }

        //Method to display employees in the EmpList List
        public static void Display()
        {
            foreach(RestaurantEmployees e in EmpList)
            {
                Console.WriteLine(e.EmpName);
            }
        }


        //Protected method to be Overriden according to role
        protected virtual void Role() {
            Console.Write("Hey, I am doing my role");
        }

    }

    //Child Class Chef

    public class Chef : RestaurantEmployees { 
        protected override void Role()
        {
            Console.Write("Hey, I am a Chef here.");
        }
        

        public Chef(int empid, string empname):base (empid,empname)
        {
          
        }

    }

    //Child Class Waiter

    public class Waiter : RestaurantEmployees
    {
        protected override void Role()
        {
            Console.Write("Hey, I am a Waiter here.");
        }

        public Waiter(int empid, string empname) : base(empid, empname)
        {

        }
    }

    //Child Class Receptionist
    public class Receptionist : RestaurantEmployees
    {
        protected override void Role()
        {
            Console.Write("Hey, I am a Receptionist here.");
        }

        public Receptionist(int empid, string empname) : base(empid, empname)
        {

        }
    }
}
