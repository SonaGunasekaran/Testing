using System;

namespace Testing
{
    class Dog
    {

        private string dogName;
        private int dogAge;

        public string Name
        {
            get
            {
                return dogName;
            }
            set
            {
                dogName =value;

            }
        }

        public int Age
        {
            get
            {
                return dogAge;
            }
            set
            {
                 dogAge = value;

            }
        }
    }

    


        class Program
        {


            static void Main(string[] args)
            {
               Dog myObj = new Dog();
                
                myObj.Name = "brown";
                myObj.Age =12;

                 Console.WriteLine("My dog name is"  + myObj.Name +  "his age is"  + myObj.Age);
                Console.WriteLine("Hello World!");
            }
        }
    }

