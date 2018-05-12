// using System;
// using System.Collections.Generic;

// namespace excersice
// {
//     class listExercise
//     {
//         static void Main(string[] args)
//         {
//             var numbers = new List<int>() { 1, 2, 3, 4};
//             numbers.Add(1);
//             numbers.AddRange(new int[3] { 5, 6, 7});

//             foreach (var number in numbers)
//                 Console.WriteLine(number);

//                 //indexof
//             Console.WriteLine(numbers.IndexOf(1));
//                 //lastindexof
//             Console.WriteLine(numbers.LastIndexOf(1));

//             Console.WriteLine("count: " + numbers.Count);

//             numbers.Remove(1);
//             //removes all 1's from the list
//             for ( var i = 0; i < numbers.Count; i++)
//             {
//                 if (i == 1);
//                     numbers.Remove(numbers[i]);
//             }
//             //clears the list
//             numbers.Clear();


//         }
//     }
// }