// using System;

// namespace MoshUdemy
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var demerit = 0;

//             Console.WriteLine("please enter the speedLimit:  ");

//             int speedLimit = Int32.Parse(Console.ReadLine());
           
//             Console.WriteLine("Please enter the speed of the car ");
           
//             int drivingSpeed = Int32.Parse(Console.ReadLine());
           
//             var demeritCheck = drivingSpeed - speedLimit;
           
//             if (demeritCheck <= 0)
//             {
//                 Console.WriteLine("OK");
//             }
//             else if (demeritCheck <= 9)
//             {
                
//                 demerit++;
//                 Console.WriteLine(demerit);
//             }
//             else if (demeritCheck >= 10 && demeritCheck <= 12)
//             {
//                 demerit += 2;
//                 Console.WriteLine(demerit);
//             }
//             else
//             {
//                 Console.WriteLine("License suspended");
//             }
//         }
//     }
// }

// //- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors,
// // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set,
// // the program asks for the speed of a car. If the user enters a value less than the speed limit,
// // program should display Ok on the console. If the value is above the speed limit
// //, the program should calculate the number of demerit points. For every 5km/hr above the speed limit,
// // 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12,
// // the program should display License Suspended.