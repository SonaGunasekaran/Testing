using System;

namespace Testing
{

    class Program
    {
        
        public static void Main(string[] args)
        {
            int empPresent = 1;
            int empAbsent = 0;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if(empInput==0)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
         
}

