using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9feb
{
    class mygen<T>
    {
        public T Add(T number1,T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            return value1 + value2; 
        }
    }
    class emploeedetails
    {
        public string empname;
        public string companyname;
        public int empid;
        
        public DateTime hiredate;
    }
    class contractemp : emploeedetails
    {
        public double hourlypay;
        public DateTime contractenddate;
    }
    class fulltimeemp : emploeedetails
    {
        public double anualsalary;
    }
    class Employee
    {
        public void employeselected()
        {
            Console.WriteLine("please select the emploee \n 1.Fulltime employee \n 2.contract employee");
            int valueselected = Convert.ToInt32(Console.ReadLine());
            switch (valueselected)
            {
                case 1:
                    Console.WriteLine("You have selected Fulltime employee\n");
                    fulltimeemp employ1 = new fulltimeemp();
                    Console.WriteLine("please enter fullname of employee:");
                    employ1.empname= Convert.ToString(Console.ReadLine());
                    Console.WriteLine("please enter companyname of employee:");
                    employ1.companyname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("please enter id of employee:");
                    employ1.empid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter Hiring date of employee:");
                     employ1.hiredate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("please enter Anual salary of employee:");
                    employ1.anualsalary = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n Details you have entered are:\n");

                    Console.WriteLine("Employee name:"+ employ1.empname);
                    Console.WriteLine("Employee company name:"+ employ1.companyname);
                    Console.WriteLine("Employee id :"+ employ1.empid);
                    Console.WriteLine("Employee hiring date:"+ employ1.hiredate);
                    Console.WriteLine("Employee anual salary:"+ employ1.anualsalary);
                    break;
                case 2:
                    Console.WriteLine("You have selected Contract employee\n");

                    contractemp employ2 = new contractemp();
                    Console.WriteLine("please enter fullname of employee:");
                    employ2.empname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("please enter companyname of employee:");
                    employ2.companyname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("please enter id of employee:");
                    employ2.empid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter Hiring date of employee:");
                    employ2.hiredate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("please enter Hourly salary of employee:");
                    employ2.hourlypay  = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("please enter Contract end date of employee:");
                    employ2.contractenddate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("\n Details you have entered are:\n");

                    Console.WriteLine("Employee name:"+ employ2.empname);
                    Console.WriteLine("Employee company name:"+ employ2.companyname);
                    Console.WriteLine("Employee id :"+ employ2.empid);
                    Console.WriteLine("Employee hiring date:"+ employ2.hiredate);
                    Console.WriteLine("Employee Hourly salary:"+ employ2.hourlypay);
                    Console.WriteLine("Employee contract end date:"+ employ2.contractenddate);



                    break;
            }
        }
        static void Main(string[] args)
        {
            Employee newemp = new Employee();
            newemp.employeselected();


            mygen<Int32> p = new mygen<int>();
            int val = p.Add(10, 20);
            Console.WriteLine("ans is:" + val);
         
            Console.Read();
        }
       
    }
    
}
