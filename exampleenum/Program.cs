using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleenum
{
   
    class Program
    {
        public enum tshirtsize { small, large, extralarge,none }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the tshirt size between small, large, extralarge");
            string value = Convert.ToString(Console.ReadLine());
            tshirtsize size;
            try
            {
                size = (tshirtsize)Enum.Parse(typeof(tshirtsize), value);
            }
            catch(Exception ex)
            {
                Console.WriteLine("please select from the given options");
                Console.WriteLine(ex.Message);
                size = tshirtsize.none;
            }
            if(size ==tshirtsize.small||size==tshirtsize.large||size==tshirtsize.extralarge)
            {
                Console.WriteLine("you have selected {0}",size);
            }
            else
            {
                Console.WriteLine("you have entered wrong value");
            }
            Console.ReadLine();
        }
    }
}
