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

             Console.WriteLine("What is your name?");//1
             string name = Console.ReadLine();

             Console.WriteLine("What is your pronoun? (He or She)");//2
             string gender = Console.ReadLine();

             Console.WriteLine("What is your profession?");//3
             string pro = Console.ReadLine();

             Console.WriteLine("What do you want to become?");//4
             string become = Console.ReadLine();

             Console.WriteLine("What is your least favorate animal?");//5
             string animal = Console.ReadLine();

             Console.WriteLine("Put your number down.");//math
             int num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Put your second number down.");//math
             int num2 = int.Parse(Console.ReadLine());

             Console.WriteLine("What is your favorate food?");//6
             string food = Console.ReadLine();

             int answer = Sum(num1, num2);

             //challenge

             Console.WriteLine($"This is a story about {name}. {gender} is a {pro}. {gender} wants" +
                 $"to become a {become}, but {gender} will probably be a {animal} instead. As you can see {gender} is" +
                 $" no math genious. {gender} thinks {num1} plus {num2} equils {food}, but is really {answer}. ");

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

             int answer2 = Mul(num3, num4);

             Console.WriteLine($"Computer used {name} has said {isTrue} to being good at math. " +
                 $"{gender} says {num3} * {num4} = {wrongAn}. But it is {answer2}. {gender} is a {badName}.");


            Console.WriteLine("How many numbers do you want to add together?");
            int userAmount = int.Parse(Console.ReadLine());

            int[] numbers = new int[userAmount];

            for (int i = 0; i < userAmount; i++)
            {
                Console.WriteLine("Enter a number.");
                int userNumber = int.Parse(Console.ReadLine());

                numbers[i] = userNumber;

            }

            int sumAll = Add(numbers);
            Console.WriteLine(sumAll);
        }
         public static int Sum(int num1, int num2)
         {
             return num1 + num2;
         }
         public static int Mul(int num3, int num4)
         {
             return num3 * num4;
         }

    
        

            public static int Add(params int[] args)//[1,2,3,4,5,6...]
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