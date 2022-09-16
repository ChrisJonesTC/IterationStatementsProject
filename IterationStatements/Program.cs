using System;
using System.Collections.Generic;
using System.Threading;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
        //Exercise 1
        //Write 15 times
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");    
            //}
            //for (int i = 0; i < 5; i++) 
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");    
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");   
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i}");
            //}   

            //Exercise 2

                //DONE  - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
            var numbers = new List<int>();
            
                //Create a variable of type int and name it num
                //initialize the variable with a value of 0
            var myNumbers = 0;
           
            // Create a do-while loop and use the template below:
            do
            {
                myNumbers++; // Increment num by 1

                numbers.Add(myNumbers); // Then add num to the collection - numbers

                //numbers.Add(/* 0++ */); Hint: reference num inside of the Add method's parentheses

            } while (myNumbers < 100); //<---- While your variable is less than 100

            // Create a while loop
           while (myNumbers < 200)  // <--- While num is less than 200
            {
                myNumbers++;  // Increment num by 1
                numbers.Add(myNumbers);  // Then add num to the collection numbers (HINT: copy how this was done in the do while loop)
            }

           Console.WriteLine("Increase:"); // This is to show the user that the numbers will start increasing on the console

            // Create a foreach loop using the collection - numbers
            foreach (var options in numbers)
            {
                Console.WriteLine($"{options}");     //In the scope of the foreach loop, print each number in numbers
            }    

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            
            for (int i = 199; i <= numbers.Count && i >=0 ; i--)
            {
                Console.WriteLine($"{numbers[i]}"); // place numbers[i] inside of the Console.WriteLine() method
            }
        }
    }
}
