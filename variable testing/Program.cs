using System;

namespace variable_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Newstring = "my name is Thomas";
            bool Istrue = false;
            char A = 'a';
            int B = 1;
            double C = 2.22;
            decimal D = 4m;
            Console.WriteLine($"{Newstring}, and it is {Istrue} that I am a cat who is {B} years old");
            string Wholeattempt = Newstring + " and it is " + Istrue + " that I am a cat who is " + B + "years old";
            Console.WriteLine(Wholeattempt);
        }
    }
}
