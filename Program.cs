using System.ComponentModel;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Prog120_W24_L5_013024
{
    internal class Program
    { // <----
        // Global Scope
        static string classVarible = "Class Variable";

        static void Main(string[] args)
        { // <----
            
            Console.WriteLine(classVarible);
            string mainVariable = "Main Variable";
            if(false)
            {
                int a = 5;
                int b = 7;
                int sum = a + b;
                Console.WriteLine(sum);
            }
            else
            {
                string name = "Adam";
                Console.WriteLine(name);
            }

            // Calling a method
            VariableScope();

            Console.WriteLine(classVarible);
            Console.WriteLine(mainVariable);
        } // Main // <----

        public static void VariableScope()
        {
            string name = "Jake";
            string anotherMethodScope = "Another Method Scope";
            Console.WriteLine(anotherMethodScope);

            classVarible = "Changed in Variable Scope";

            Console.WriteLine(classVarible);
        }

        // Create a method ( to be discussed after midterms )
        public static void ScopeExample()
        {
            // Variable Scope

            //string name = "Dylan";
            //Console.WriteLine(name); // Print Dylan

            // string, int, double, bool

            // Condition ( if , else if , else ) relies bool

            //string ifScope = "I declared this message in our MAIN code block";

            //if (true)
            //{ // <-- Start of Code Block
            //    // Declared my ifScope variable INSIDE of my if code block
            //    ifScope = "I changed this message in my if code block";

            //    // Console.WriteLine(ifScope);
            //} // <--- End of my if Code Block


            //// Current: ifScope is throwing an error
            //// The name 'identifier' does not exist in the current context
            //// To FIX this error, we need to change the "scope" of our variable
            //Console.WriteLine(ifScope);

            // Part 1 : Declared our variable
            string ifScope = "I declared this message in our MAIN code block";

            // Part 2: Reassigned the value to the variable
            if (false) // <--- Change it from true to false
            { // <-- Start of Code Block
                ifScope = "I changed this message in my IF code block";
                int age = 12;
            } // <--- End of my if Code Block
            else
            {
                ifScope = "Changed in ELSE code block";
            }

            // Part 3: Print the variable
            // Will it say
            // 1: I declared this in main
            // or
            // 2: I changed this is IF
            Console.WriteLine(ifScope);
            //Console.WriteLine(age); // age is DECLARED in a lower scope

        }

    } // class <-----

} // namespace
