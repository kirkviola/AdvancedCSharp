using System;

namespace AdvancedCSharp
{
    record Student(int Id, string Firstname, string Lastname, int SAT);
    record Student1(int Id, string Name, string Major);

    class Program
    {

        static void Main(string[] args)
        {
            // ref parameter example
            var anInt = 0;
            Add1(ref anInt);
            Console.WriteLine(anInt);

            // out parameter example
            double pi = 0;
            GetPi(out pi);
            var newInt = "123";
            int i;
            var aBool = int.TryParse(newInt, out i);
            Console.WriteLine(newInt);

            var joe = new Student(1, "Joe", "Smith", 1000);
            // new record syntax --> explicit declaration
            Student jane = new(2, "Jane", "Jones", 1200);
            // can only change records by making a copy
            Student jane1 = jane with { SAT = 1250 };
            // can actually change values with with clause
            jane = jane with { SAT = 2000 };
            Console.WriteLine(jane);

            var boolean = true;
            var nbr = 0;
            if(boolean && ++nbr > 10)
            {
                Console.WriteLine(nbr);
            }

        }

        static void Add1(ref int i)
        {
            i++;
        }

        static int Add1(int i)
        {
            return i++;
        }

        static void GetPi(out double val)
        {
            val = 3.1415;
        }
    }
}
