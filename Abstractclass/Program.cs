using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass
{
    abstract class washing
    {
        public abstract void Selectwater();
        public abstract void Selectwashtype();
        public abstract void Allottedwashtime();
        public abstract int NumberofRinse();

    }

    
    class Program :washing
    {
        int Valueselected =0;
        int Washtypeselected = 0;
        public override void Selectwater()
        {

            Console.WriteLine("Please select Water Type for Washing: \n 1.Hot Water \n 2.Cold Water \n 3.Warm Water \n Please Enter number value only");
            Valueselected = Convert.ToInt32(Console.ReadLine());
            switch(Valueselected)
            {
                case 1:
                    Console.WriteLine("You have selected Hot Water for washing");
                    break;

                case 2:
                    Console.WriteLine("You have selected Cold Water for washing");
                    break;

                case 3:
                    Console.WriteLine("You have selected Warm Water for washing");
                    break;
            }
        }
        public override void Allottedwashtime()
        {
            switch (Valueselected)
            {
                case 1:
                    Console.WriteLine("Washing Time For Washtype you have selected is 40 Minutes");
                    break;

                case 2:
                    Console.WriteLine("Washing Time For Washtype you have selected is 60 Minutes");
                    break;

                case 3:
                    Console.WriteLine("Washing Time For Washtype you have selected is 50 Minutes");
                    break;
            }

        }
        public override void Selectwashtype()
        
        {
            Console.WriteLine("Please select Wash Type for Washing: \n 1.Normal \n 2.Hard \n 3.Medium \n Please Enter number value only");
            Washtypeselected = Convert.ToInt32(Console.ReadLine());
            switch (Washtypeselected)
            {
                case 1:
                    Console.WriteLine("You have selected Normal for washing");
                    break;

                case 2:
                    Console.WriteLine("You have selected Hard for washing");
                    break;

                case 3:
                    Console.WriteLine("You have selected Medium for washing");
                    break;
            }
        }
        public override int NumberofRinse()
        {
            if(Washtypeselected==1)
            {
                Console.WriteLine("You have selected normal wash so 1 Rinse");
                return 1;
            }
            else if(Washtypeselected == 2)
            {
                Console.WriteLine("You have selected Hard wash so 3 Rinse");
                return 2;
            }
            else
            {
                Console.WriteLine("You have selected Medium wash so 2 Rinse");
                return 3;

            }
        }

        static void Main(string[] args)
        {
            Program wash = new Program();
            wash.Selectwater();
            wash.Allottedwashtime();
     
            wash.Selectwashtype();
          wash.NumberofRinse();
            Console.ReadLine();

        }

    }
}
