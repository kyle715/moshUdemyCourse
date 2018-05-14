// using System;
// using System.Collections.Generic;

// namespace MoshUdemy
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var numberList = new List<int>();
//             Console.WriteLine("Please enter some numbers, seperated by -");
//             var input = Console.ReadLine().Split('-');
//             var numbers = Convert.ToInt32(input);
//             numberList.Add(numbers);
//             var firstNum = numberList[0];
//             for(var i = 0; i < numberList.Count; i++)
//                 if(numberList[i] == firstNum + i)
//                 Console.WriteLine("Consecutive");
//                 else
//                 {
//                     Console.WriteLine("Not Consecutive");
//                 }
//             //create for loop, itterating over each number in list, if next number is = to previous number + 1
//             //than numbers are Consecutive
//         }
//     }
// }


// // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
// //  For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
// //  otherwise, display "Not Consecutive".
