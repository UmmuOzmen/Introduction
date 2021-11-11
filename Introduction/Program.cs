/*using System;

namespace Introduction
{
    class Program
    {
       /* static int Topla(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x = 5;
            int y = 3;
            int z = x + y;
            double k = 8.1;

            Console.WriteLine("z = " + z);
            Console.WriteLine(Topla(z, y));

            /* for(int i = 0; i < 5; i++)
             {
                 this.
                 int x = i;
                 int y = 2 * i;
                 Console.WriteLine(x + y);
             }*/
/*
     Aritmetik art = new Aritmetik();
     art.prm1 = 15;
     art.prm2 = 16;
     Console.WriteLine(art.prm1);

     Console.WriteLine(art.topla(7, 9));

     Console.WriteLine(art.topla());

     art.prm3set(7);
     Console.WriteLine(art.prm3get());

     //2.Ders


     Aritmetik art_0 = new Aritmetik();
     Console.WriteLine("param1= " + art_0.prm1 + " param2= " + art_0.prm2);
     Aritmetik art_1 = new Aritmetik(6,9);
     Console.WriteLine("param1= "+ art_1.prm1 + " param2= "+art_1.prm2);

     */


/*

        }
    }
}
*/
//05.11.2021
/*
 using System;

namespace ConsoleAppOOP
{

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();


            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Vehicle VObj = new Vehicle();
            Console.WriteLine(VObj.brand);


            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
*/
using System;

namespace ConsoleAppExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Console.ReadLine().ToString;
            int b = Console.ReadLine().ToString;
            int sonuc = a / b;
            try
            {
                int b = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hatalı Index");
            }
            Console.WriteLine("----------------------");

        }
    }
}