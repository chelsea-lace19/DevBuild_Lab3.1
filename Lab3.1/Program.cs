using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Dev.Build class.");
            bool done = false;

            while (!done)
            {

                string[] students = { "Chelsea", "Alissa", "Grady", "Burke" };
                string[] faveFood = { "Pizza", "Tacos", "Tuna", "Everything"};
                string[] faveHobby = { "Snowboarding", "Rock Climbing", "Bird Watching", "Napping" };


                Console.WriteLine("Which student would you like to learn more about? (enter a number 0-3): ");
                try
                {
                    int selection = Int32.Parse(Console.ReadLine());

                    if (selection > 3 || selection < 0)
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                        Console.WriteLine("Which student would you like to learn more about? (enter a number 0-3): ");
                        selection = Int32.Parse(Console.ReadLine());
                    }



                    Console.WriteLine($"Student {selection} is {students[selection]}");
                    Console.WriteLine($"What would you like to know about {students[selection]}?");
                    Console.WriteLine("You can learn their favorite food or their favorite hobby!");
                    string choice = Console.ReadLine();

                    if (choice == "favorite food")
                    {
                        Console.WriteLine($"Their favoirite food is: {faveFood[selection]}.");
                    }

                    else if (choice == "favorite hobby")
                    {
                        Console.WriteLine($"Their favorite hobby is: {faveHobby[selection]}.");
                    }
                    else
                    {
                        Console.WriteLine($"That data does not exist. Please choose between: \nfavorite food\nfavorite hobby");
                        choice = Console.ReadLine();

                        if (choice == "favorite food")
                        {
                            Console.WriteLine($"Their favoirite food is: {faveFood[selection]}.");
                        }

                        else if (choice == "favorite hobby")
                        {
                            Console.WriteLine($"Their favorite hobby is: {faveHobby[selection]}.");

                        }
                    }
                    Console.WriteLine("Would you like to know about another student? (enter yes or no): ");
                    string userContine = Console.ReadLine();

                    if (userContine == "no")
                    {
                        Console.WriteLine("Thank you for learning about our students, goodbye!");
                        done = true;
                    }
                    else if (userContine == "yes")
                    {
                        done = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter only yes or no: ");
                        userContine = Console.ReadLine();

                        if (userContine == "no")
                        {
                            Console.WriteLine("Thank you for learning about our students, goodbye!");
                            done = true;
                        }
                        else if (userContine == "yes")
                        {
                            done = false;
                        }

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please only enter a number 0-3: ");
                }

            }



        }
    }
}
