// using System;

// namespace MoshUdemy
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var fullName = "Kyle Mayers";
//             Console.WriteLine("trim: '{0}'", fullName.Trim().ToUpper());

//             var index = fullName.IndexOf(' ');
//             var firstName = fullName.Substring(0, index);
//             var lastName = fullName.Substring(index + 1);
//             Console.WriteLine("First Name: " + firstName);
//             Console.WriteLine("Last Name: " + lastName);

//             var names = fullName.Split(' ');
//             Console.WriteLine("First Name: " + names[0]);
//             Console.WriteLine("Last Name: " + names[1]);

//             Console.WriteLine(fullName.Replace("Kyle", "kyyyle"));

//             if (String.IsNullOrWhiteSpace(" "))
//                 Console.WriteLine("invalid");

//             var str = "25";
//             var age = Convert.ToByte(str);
//             Console.WriteLine(age);

//             float price =29.95f;
//             Console.WriteLine(price.ToString("C"));
//         }
//     }
// }
