using System;

namespace MoshUdemy
{

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class switchExample
    {
        static void Example(string[] args)
        {
            var hour = 10;

            if (hour > 0 && hour <12)
            {
                Console.WriteLine("its morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("its afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            // Here we are showing the example between using an if else statement *shown below commented out*
            // and the short hand notation of using the if statment in the same line of code. Very efficent Great exmaple
            bool isGoldCustomer = true;


            //Condition //if true code between ? and : is executed, if false code after the colin is executed
            float price = (isGoldCustomer) ? 19.95f : 29.95f;


            // float price;
            // if (isGoldCustomer)
            // {
            //     price = 19.95f;
            // }
            // else
            // {
            //     price = 29.95f;
            // }
            

            //above we have declared an enum for the season and below is an example of a switch case referring to which season it is
            var season = Season.Autumn;
            //Here we pass the variable of season
            switch (season)
            {
                //if you would like to display the same message during certain seasons or under two diffferent conditions, you can check for both before executing code like so
                case Season.Autumn:
                case Season.Summer:
                {
                Console.WriteLine("we have a promotion!");
                break;
                }
                // Once you have handled all events for special triggers, you can set the default respone or code to be executed, when none of your other cases are true
                default:
                {
                Console.WriteLine("we do not have any promotions right now");
                break;
                }
            }
        }
    }
}