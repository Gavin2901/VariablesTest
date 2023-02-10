using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            // int count = 10;
            // float totalPrice = 20.95f;   //initially c# treats any real numbers like this as a double, we have to delcare it as a float by adding an "f" at the end
            // char character = 'a'; //chars are enclosed in single quotes while stirngs are in double quotes
            //string firstName = "Gavin";
            //  bool isWorking = false; //both true and false are key words and are indicated by their blue colour

            var number = 2; //here c# automatically detects this as an int, however if you really want it to be a byte you can just declare it as such
            var count = 10;
            var totalPrice = 20.95f;   
            var character = 'a'; 
            var firstName = "Gavin";
            var isWorking = false;
            //we can also use var and c# will automatically detect which data type is being declared (hover over var to check)


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            //type shortcut "cw" and press tab to quickly write console.writeline


            Console.WriteLine(""); //new line in output


            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // firstly in the quotes we have a fomat string, its a kind of string that can be used as a template
            // at runtime we 0 and 1 will be replaced by the arguments that are placed after the string in order, so Minvalue replaces 0 and Max replaces 1
            
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            //same concept but for floats this time

            Console.WriteLine("");

            const float Pi = 3.14f; //delcared as a float rather than a double
            //Pi = 1; cannot be done as Pi is a const and cannot be changed
            Console.WriteLine(Pi);
        }
    }
}