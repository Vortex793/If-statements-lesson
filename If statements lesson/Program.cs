using System.Reflection.Metadata.Ecma335;

namespace If_statements_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int people = 20;
            //int cats = 30;
            //int dogs = 15;
            //Console.WriteLine("People: " + people + "Dogs: " + dogs + "Cats: " + cats);
            //if (people < cats)
            //{
            //    Console.WriteLine("Too many cats!   The world is doomed!");
            //}
            //if (people > cats)
            //{
            //    Console.WriteLine("Not many cats!   The world is saved");
            //}
            //if (people < dogs)
            //{
            //    Console.WriteLine("The world is drooled on");
            //}
            //if (people > dogs)
            //{
            //    Console.WriteLine("The world is dry!");
            //}
            //Console.WriteLine("Press ENTER to continue. ");
            //Console.ReadLine();
            //Console.Clear();
            //dogs += 5;     // Add 5 to dogs. What does dogs equal now?
            //Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            //if (people >= dogs)
            //{
            //    Console.WriteLine("People are greater than or equal to dogs");
            //}
            //if (people <= dogs)
            //{
            //    Console.WriteLine("People are less than or equal to dogs");
            //}
            //if (people == dogs)
            //{
            //    Console.WriteLine("People are dogs.");

            //string dinosaur;
            //Console.WriteLine("What famous dinosaur has three large horns?");
            //dinosaur = Console.ReadLine();

            //if (dinosaur.ToLower() == "triceratops")
            //    Console.WriteLine("You are correct!");

            //Task 1
            //string magicWord;
            //Console.WriteLine("What's the magic word?");
            //magicWord = Console.ReadLine();
            //if (magicWord.ToLower() == "please") ;
            //if (magicWord.ToUpper() == "PLEASE") ;
            //Console.WriteLine("You are correct");


            //Task 2
            //string name;
            //int age;
            //Console.WriteLine("What is your name? ");
            //name = Console.ReadLine();

            //Console.WriteLine("How old are you, " + name + "? ");
            //int.TryParse(Console.ReadLine(), out age);
            //if (age < 16)
            //{
            //    Console.WriteLine("You can't drive");
            //}
            //if (age < 18)
            //{
            //    Console.WriteLine("You can vote");
            //}
            //if (age < 25)
            //{
            //    Console.WriteLine("You can't rent a car");
            //}
            //if (age > 25)
            //{
            //    Console.WriteLine("You can do anything legal");


            //Task 3
            //int temp;
            //Console.WriteLine("What is the freezing temperature of water");
            //int.TryParse(Console.ReadLine(), out temp);
            //if (temp == 0)
            //{
            //    Console.WriteLine("0 degrees celcius is correct");
            //}
            //if (temp == 32)
            //{
            //    Console.WriteLine("32 degrees fahrenhiet is correct");
            //}
            //if (temp == 273)
            //{
            //    Console.WriteLine("273.2 degrees kelvin is correct");
            //}

            //    int grade;
            //    Console.WriteLine("What was your grade");
            //    int.TryParse(Console.ReadLine(), out grade);
            //    if (grade >= 50)
            //    {
            //        Console.WriteLine("You Passed!");
            //    }
            //    else
            //        Console.WriteLine("Better luck next time");
            //}
            int age;

            Console.WriteLine("How old are you");
            int.TryParse(Console.ReadLine(), out age);
            if (age < 16)
            {
                Console.WriteLine("");
            }

        }
}
}


