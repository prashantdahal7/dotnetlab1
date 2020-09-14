using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a option:\n1. Simple Intrest.\n" +
                "2. Compound Intrest.\n3. Area of Cricle." +
                "\n4. volume of sphere.\n5. Body mass index.\n6. Bill split value per person.\n" +
                "7. Gravitational Force.\n8. Mass-enegy equivalence.");
            int option= int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    si();
                    break;
                case 2:
                    ci();
                    break;
                case 3:
                    ac();
                    break;
                case 4:
                    vs();
                    break;
                case 5:
                    bmi();
                    break;
                case 6:
                    bspp();
                    break;
                case 7:
                    gf();
                    break;
                case 8:
                    mee();
                    break;
                default:
                    Console.WriteLine("Enter correct option program is exited....");
                    break;
            }

                static void si()
                    {
                        Console.WriteLine("Enter principle:");
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter time:");
                        int t = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter rate:");
                        int r = int.Parse(Console.ReadLine());
                        double i = (p * t * r) / 100;
                        Console.WriteLine("Intrest is" + i);
                    }
                static void ci()
                    {
                        Console.WriteLine("Enter principle:");
                        double p = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter time:");
                        double t = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter rate:");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter no. of times that interest is compounded per unit t:");
                        double n = double.Parse(Console.ReadLine());
                        double nt = n * t;
                        double nr = n / r;
                        double temp = 1 + nr;
                        double a=p * Math.Pow(temp, nt);
                        double ci = a - p;
                        Console.WriteLine("amounts= " + a + "conpound intrest= " + ci);



                    }
                    static void ac()
                    {
                        int r;
                        double A;
                        Console.WriteLine("Enter the radius in cm:");
                        r = int.Parse(Console.ReadLine());
                        A = Math.PI * r * r;
                        Console.WriteLine("The Area of circle of given radius is=" + A+"cm^2");
                        Console.ReadLine();
                    }
                     static void vs()
                    {
                        double r, volume;
                        Console.WriteLine("Enter the Radius of the Sphere: ");
                        r = double.Parse(Console.ReadLine());
                        volume = (4.0 / 3) * Math.PI * r * r * r;
                        Console.WriteLine("Volume of Sphere is : "+ volume);
                       
                    }
                    static void bmi()
                    {
                        Console.WriteLine("Weight in kg: ");
                        int kg = int.Parse(Console.ReadLine());
                        Console.WriteLine("Height in cm: ");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gender (m/f):");
                        string Gender = Console.ReadLine();
                        int BMI = kg / (m / 100) * (m / 100);
                        Console.Write("body mass index: "+ BMI);
                        if (BMI < 19 & Gender == "f")
                            Console.WriteLine("-> Underweight"); 
                        if (BMI >= 19 & BMI <= 24 & Gender == "f")
                            Console.WriteLine("-> Normal"); 
                        if (BMI > 24 & Gender == "f")
                         Console.WriteLine("-> Overweight");
                        if (BMI < 20 & Gender == "m")
                             Console.WriteLine("-> Underweight"); 
                        if (BMI >= 20 & BMI <= 25 & Gender == "m")
                            Console.WriteLine("-> Normal"); 
                        if (BMI > 25 & Gender == "m")
                            Console.WriteLine("-> Overweight");
                        Console.ReadLine();
                    }
                    static void bspp()
                    {
                        Console.WriteLine("Enter total amount in bill: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter no of person: ");
                        int n = int.Parse(Console.ReadLine());
                        int pa = a / n;
                        Console.WriteLine("Amount to be paid per person is "+pa);

                    }
                    static void gf()
                    {
                        Console.WriteLine("Enter mass of 1st object: ");
                        int m1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter mass of 1st object: ");
                        int m2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter radius between: ");
                        int r = int.Parse(Console.ReadLine());
                        double temp = (m1 * m2) / (r * r);
                        Console.WriteLine(temp);
                        const double G = 6.67*10e-11;
                        double gf = G * temp;
                        Console.WriteLine("Gravitational Force : "+ gf);
                    }
                    static void mee()
                    {
                        Console.WriteLine("Enter mass of  object: ");
                        int m = int.Parse(Console.ReadLine());
                        const double c = 3 * 10e8;
                        double e = m * (c * c);
                        Console.WriteLine("mee: "+e);
                    }
        }
                
    }
}