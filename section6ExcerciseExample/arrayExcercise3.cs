using System;
using System.Collections.Generic;

namespace MoshUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //create a list to hold all inputed numbers
                var numberList = new List<int>();
                //run the operation 5 times
                for(var i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter a number: ");
                    //create a variable to save inputted number
                    var input = Convert.ToInt32(Console.ReadLine());
                    //run check through the list of numbers
                    for(int j = 0; j < numberList.Count; j++)
                    //while running through list of numbers, if a match is found, display error message
                        if(input == numberList[j])
                        {
                            Console.WriteLine("Please enter a number that has not already been entered");
                            // - 1 from 1 so the operation still only runs 5 times
                            i--;
                            //Remove the last number inputted from user
                            numberList.Remove(numberList[j]);
                            continue;
                        }
                        //else add the inputted number into the list
                    numberList.Add(input);
                }
                //once function has accepted 5 correct numbers print them out to console
                foreach(int number in numberList)
                Console.Write(number + ",");
                break;
            }
        }
    }
}

// 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an 
// error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.