using System;

namespace storytest2
{
    class Program
    {
        static void Main(string[] args)
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

                Console.WriteLine("What is your favorate food?");//6
                string food = Console.ReadLine();

                Console.WriteLine("Put your number down.");//math
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Put your second number down.");//math
                int num2 = int.Parse(Console.ReadLine());

                int answer = Sum(num1, num2);


                //write an adlib story.

                //use var so it can be different things for more obscure questions.
                //step 2
                //make methods that use different math operators. 
                //step 3
                //challenge

                Console.WriteLine($"This is a story about {name}. {gender} is a {pro}. {gender} wants" +
                    $"to become a {become}, but {gender} will probably be a {animal} instead. As you can see {gender} is" +
                    $"no math genious. {gender} thinks {num1}and {num2} equils {food}, but is really {answer}. ");
            }
            static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
            
        }
    }
}
