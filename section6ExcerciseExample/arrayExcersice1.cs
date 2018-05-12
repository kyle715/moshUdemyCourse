// using System;
// using System.Collections.Generic;


// namespace MoshUdemy
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var people = new List<string>();
//             while (true)
//             {
//                 Console.WriteLine("Please enter a name or press enter to end program: ");
//                 var input = Console.ReadLine();
//                 if (!String.IsNullOrWhiteSpace(input))
//                 {
//                     people.Add(input);
//                     continue;
//                 }
//                 if (people.Count == 1)
//                 Console.Write(people[0] + " likes your post");
//                 if (people.Count == 2)
//                 Console.Write(people[0] + " and " + people[1] + " like your post");
//                 if (people.Count > 2)
//                 Console.Write(people[0] + ", " + people[1] + " and " + (people.Count - 2) + " others like your post!");
//                 break;
//             }
            
//         }
//     }
// }



// // 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
// // If no one likes your post, it doesn't display anything.
// // If only one person likes your post, it displays: [Friend's Name] likes your post.
// // If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
// // If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
// // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
// // Depending on the number of names provided, display a message based on the above pattern.