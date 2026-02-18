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
            //int bet;
            //Console.WriteLine("How much would you like to bet? ");
            //if (int.TryParse(Console.ReadLine(), out bet))
            //{
            //    Console.WriteLine("You bet " + bet.ToString("C"));
            //}
            //else
            //{
            //    Console.WriteLine("That is not a valid number.");
            //    Console.WriteLine("Your bet will be set to the minimum of $1.00.");
            //    bet = 1;
            //int grade;
            //Console.WriteLine("What was your grade?");
            //int.TryParse(Console.ReadLine(), out grade);
            //if (grade < 50)
            //    Console.WriteLine("That is an F!");
            //else if(grade <= 65)
            //    Console.WriteLine("That is a D!");
            //else if (grade <= 75)
            //    Console.WriteLine("That is a C!");
            //else if (grade <= 85)
            //    Console.WriteLine("That is a B!");
            //else 
            //    Console.WriteLine("That is a A!");

            //string choice;
            //Console.WriteLine("What is the name of the 1968 album by The Beatles?:");
            //Console.WriteLine("a - Band on the Run          b - The Beatles");
            //Console.WriteLine("c - Abbey Road               d - The White Album");
            //Console.WriteLine();
            //Console.Write(": ");
            //choice = Console.ReadLine().ToLower();
            //Console.WriteLine();
            //if (choice == "a")
            //{
            //    Console.WriteLine("Thats a Wings album! Not an album by The Beatles");
            //}
            //else if (choice == "b")
            //{
            //    Console.WriteLine("Correct! The Beatles 1968 album was indeed called The Beatles");
            //}
            //else if (choice == "c")
            //{
            //    Console.WriteLine("Abbey Road was released in 1969 not 1968!");
            //}
            //else if (choice == "d")
            //{
            //    Console.WriteLine("Very close, the album is mostly reffered to as The White album but not the offical title");
            //}
            //else
            //{
            //    Console.WriteLine("This is an invalid choice, try a,b,c,d,");
            //}


            int temp;
            Console.WriteLine("Please enter the temperature of the H2O: ");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                if (temp <= 0)
                    Console.WriteLine("You have a solid.");
                else if (temp < 100)
                    Console.WriteLine("You have liquid");
                else
                    Console.WriteLine("You have gas!");

            }
            else
            {
                Console.WriteLine("Invalid input");
            }









            string name;
            int age;
            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ok, " + name + ", how old are you? ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine();
                if (age < 0)
                {
                    Console.WriteLine("I didn't know that fetuses could code!");
                }
                else if (age < 16)
                {
                    Console.WriteLine("You can't drive.");
                }
                else if (age < 18)
                {
                    Console.WriteLine("You can't vote.");
                }
                else if (age < 25)
                {
                    Console.WriteLine("You can't rent a car.");
                }
            }
            else
            {
                Console.WriteLine("You can do anything that is legal.");
            }
        }
                else
            {
                    Console.WriteLine("Invalid Numeric Input");
            }

}




