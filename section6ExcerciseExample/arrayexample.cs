// using System;

// namespace arrayExample;
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var numbers = new[] { 3, 7, 9, 2, 14, 6};

//             //length
//             Console.WriteLine("length: " + numbers.Length);

//             //indexof()
//             var index = Array.IndexOf(numbers, 9);
//             Console.WriteLine("index of 9L " + index);

//             //clear()
//             Array.Clear(numbers, 0 ,2);

//             Console.WriteLine("Effect of Clear()");
//             foreach (var n in numbers)
//             Console.WriteLine(n);

//             //Copy
//             int[] another = new int[3];
//             Array.Copy(numbers, another, 3);

//             Console.WriteLine("effect of copy()");
//             foreach (var n in another)
//                 Console.WriteLine(n);

//                 //sort()
//                 Array.Sort(numbers);
//                 Console.WriteLine("Effect of sort()")
//                 foreach (var n in numbers)
//                     Console.WriteLine(n);

//                     //Reverse
//                     Array.Reverse(numbers);

//                     Console.WriteLine("Effect of Reverse()")
//                     foreach(var n in numbers)
//                     Console.WriteLine(n);
//         }
//     }
// }