using System;

namespace MoshUdemy
{
    class example
    {
        static void Example(string[] args)
        {
            // the number is too large to convert to a byte so here we are basically error checking our program so it does
            // not crash and insttead gives the user a friendly message about the function
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
        }
    }
}