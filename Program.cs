using System;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;

namespace storytest2
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are the prompts to get the veraibles for the paragraph
             Console.WriteLine("What is your name?");//asks the Question
             string name = Console.ReadLine();//lets the user input their value

             Console.WriteLine("What is your pronoun? (He or She)");
             string gender = Console.ReadLine();

             Console.WriteLine("What is your profession?");
             string pro = Console.ReadLine();

            Console.WriteLine("What do you want to become?");
             string become = Console.ReadLine();

             Console.WriteLine("What is your least favorate animal?");
             string animal = Console.ReadLine();

             Console.WriteLine("Put your number down.");//math
             int num1 = int.Parse(Console.ReadLine());/*need to do int.Parse to change it from 
            a string to an integer*/
             Console.WriteLine("Put your second number down.");//math
             int num2 = int.Parse(Console.ReadLine());//same here

             Console.WriteLine("What is your favorate food?");//just another prompt
             string food = Console.ReadLine();

             int answer = Sum(num1, num2);//this is the output of Method #1

             //Bellow is the paragraph(output)

             Console.WriteLine($"This is a story about {name}. {gender} is a {pro}. {gender} wants" +
                 $" to become a {become}, but {gender} will probably be a {animal} instead. As you can see {gender} is" +
                 $" no math genious. {gender} thinks {num1} plus {num2} equils {food}, but is really {answer}. ");
            // here we have more prompts
             Console.WriteLine("Do you know math?");
             string isTrue = Console.ReadLine();

             Console.WriteLine("give me a number.");
             int num3 = int.Parse(Console.ReadLine());

             Console.WriteLine("Give me another number.");
             int num4 = int.Parse(Console.ReadLine());

             Console.WriteLine("What is the sum of these?");
             var wrongAn = (Console.ReadLine());

             Console.WriteLine("What is something you hate?");
             string badName = Console.ReadLine();

             int answer2 = Mul(num3, num4);//this is the output of method #2
            //another paragraph(output)
             Console.WriteLine($"Computer used {name} has said {isTrue} to being good at math. " +
                 $"{gender} says {num3} * {num4} = {wrongAn}. But it is {answer2}. {gender} is a {badName}.");

            //start here is for the section using array type methods and some loops
            Console.WriteLine("How many numbers do you want to add together?");//this asks the user 
            int userAmount = int.Parse(Console.ReadLine());//this is where the user inputs

            int[] numbers = new int[userAmount];

            for (int i = 0; i < userAmount; i++)//this is the for loop
            {
                Console.WriteLine("Enter a number.");
                int userNumber = int.Parse(Console.ReadLine());

                numbers[i] = userNumber;

            }

            int sumAll = Add(numbers);
            Console.WriteLine(sumAll);//this outputs the answer.
        }//this is the end of that method, array, loop thingy. 
         public static int Sum(int num1, int num2) //mehtod #1
         {
             return num1 + num2;
         }
         public static int Mul(int num3, int num4) //method #2
         {
             return num3 * num4;
         }

    
        

            public static int Add(params int[] args)//[1,2,3,4,5,6...] Method #3
            {
                int addit = 0;

                foreach (int num in args)//for each loop, nums is a temporary variable. 
                {
                    //addit = addit + num; //same num in the array this is the long version of below.
                    addit += num;
                }

                return addit;

            }


        
        }
    }