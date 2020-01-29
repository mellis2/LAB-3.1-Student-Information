using System;

namespace Lab3._1_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Adam", "Burt", "Cathleen", "Donna", "Ernie", "Francine", "Glen", "Han", "Isabel", "Jack" };
            string[] favoriteFood = { "Almond Joy", "Butterfinger", "Caramello", "Dots", "English Toffee", "Fruit Stripes", "Gummy Bears", "Hot Tamales", "Ice Bombs", "Jin Tarts" };
            string[] previousTitle = { "Assistant Manager", "Babysitter", "Chef", "Director", "Egg Sorter", "Farmer", "German Teacher", "Hematoligist", "Inspector", "Janitor" };

            bool flag = true;

            while (flag == true)
            {

                Console.Write("Welcome to our Dev.Build class. Which student would you like to learn more about? (enter a number 1-10): ");

                string studentInputReceived = (Console.ReadLine());
                int studentInput;

                bool parseSuccessful = int.TryParse(studentInputReceived, out studentInput);

                while(studentInput < 1 || studentInput > 10) 
                {
                    Console.WriteLine("Format Error!  Please enter a number 1 - 10");
                    studentInputReceived = (Console.ReadLine());
                    parseSuccessful = int.TryParse(studentInputReceived, out studentInput);
                    
                }

                Console.WriteLine($"Student {studentInput} is {students[studentInput - 1]}. What would you like to know about {students[studentInput - 1]}? (enter “favorite candy” or “previous title”):");
                string candyOrTitle = (Console.ReadLine());

                while (flag == true)

                {



                    if (candyOrTitle == "favorite candy")
                    {
                        Console.WriteLine($"{students[studentInput - 1]}’s favorite candy is {favoriteFood[studentInput - 1]}.");
                        break;

                    }
                    else if (candyOrTitle == "previous title")
                    {
                        Console.WriteLine($"{students[studentInput - 1]}'s previous title was {previousTitle[studentInput - 1]}.");
                        break;
                    }
                    else
                    {
                        Console.Write("Format Error! Please enter \"favorite candy\" or \"previous title\": ");
                        candyOrTitle = Console.ReadLine();

                    }

                }
                Console.Write("Would you like to know about another student ? (enter “yes” or “no): ");
                string proceed = Console.ReadLine();

                while (flag == true)
                {



                    if (proceed == "no")
                    {
                        Console.WriteLine("Thanks!");
                        flag = false;

                    }
                    else if (proceed == "yes")
                    {
                        flag = true;

                    }
                    else 
                    {
                        Console.Write("Format Error! Please enter \"yes\" or \"no\": ");
                        proceed = Console.ReadLine();
                        continue;
                    }
                }
                
            }          

        }
    }
}
