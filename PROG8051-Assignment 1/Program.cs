using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Type of Pets*/
            string firstPet = "Cat";
            string secondPet = "Dog";
            string thirdPet = "Rabbit";
            Console.WriteLine($"Please choose a type of pet: \n 1.{firstPet} \n 2.{secondPet} \n 3.{thirdPet}");

            /*Get the user's pet choice*/
            Console.WriteLine("User Input: ");
            int a = Convert.ToInt32(Console.ReadLine());

            /* Display the chosen pet type and ask for the pet's name*/

            if (a == 1)
            {
                Console.WriteLine($"You have chosen a {firstPet}. What would you like to name your pet?");
            }
            else if (a == 2)
            {
                Console.WriteLine($"You have chosen a {secondPet}. What would you like to name your pet?");
            }
            else
            {
                Console.WriteLine($"You have chosen a {thirdPet}. What would you like to name your pet?");
            }
            /*Get the name of the pet and display a welcome message*/
            Console.WriteLine("User Input: ");
            string petName = Console.ReadLine();
            Console.WriteLine($"Welcome,{petName}! Let's take good care of {petName}");

            /* Pet Care actions*/
            string firstAction = "Feed";
            string secondAction = "Play";
            string thirdAction = "Rest";
            string fourthAction = "Status";
            string fifthAction = "Exit";
            /*Console.WriteLine($"Main Menu: \n 1.{firstAction} {petName} \n 2.{secondAction} with {petName} \n 3.Let {petName} { thirdAction} " +
                $"\n 4.Check {petName}'s {fourthAction} \n 5.{fifthAction}");*/
            string action = $"Main Menu: \n 1.{firstAction} {petName} \n 2.{secondAction} with {petName} \n 3.Let {petName} {thirdAction} " +
                $"\n 4.Check {petName}'s {fourthAction} \n 5.{fifthAction}";
            int hunger = 4;
            int happy = 3;
            int health = 5;
            /*Get the action request from user*/
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(action);
                Console.WriteLine("User Input:");
                int b = Convert.ToInt32(Console.ReadLine());

                /*Check for the initial status of pet*/


                while (b == 4)
                {
                    Console.WriteLine($"{petName}'s  {fourthAction}: \n - Hunger : {hunger} \n - Happiness : {happy} \n - Health : {health}");

                    break;

                }

                /*Implementing the pet care actions*/


                /*if (b == 1)
                {
                    Console.WriteLine($"Great!! {petName} is fed well and is now energetic");
                    hunger = hunger - 1;
                    health = health + 2;
                }
                else if (b==2)
                {
                    Console.WriteLine($"Wonderful!!{petName} played well and he is happy");
                    hunger = hunger + 1;
                    happy = happy + 2;
                    health = health - 1;
                    
                }
                else
                {
                    Console.WriteLine("Exit");
                }*/
                switch (b)
                {
                    case 1:
                        Console.WriteLine($"Great!! {petName} is fed well and is now energetic");
                        hunger = hunger - 1;
                        health = health + 2;
                        happy = happy - 1;
                        break;
                    case 2:
                        Console.WriteLine($"Wonderful!!{petName} played well and he is happy");
                        hunger = hunger + 1;
                        happy = happy + 2;
                        health = health - 2;
                        break;
                    case 3:
                        Console.WriteLine($"Shh!!{petName} is taking a nap");
                        happy = happy - 2;
                        health = health + 2;
                        hunger = hunger - 1;
                        break;

                    case 5:
                        Console.WriteLine($"Bye{petName} see you tomorrow!!");
                        break;


                }
                /* Checking for health conditions and suggesting appropriate action for crititcal conditions*/

                if (hunger > 4 && health < 5)
                {
                    Console.WriteLine($"Grrrr..{petName} is hungry and his health is deterioating. Please feed {petName}!!");
                }
                else if (happy < 3 && hunger < 4)
                {
                    Console.WriteLine($"Hmmm... {petName} is sad he needs to play ");
                }
                else if (happy > 4 && health < 3)
                {
                    Console.WriteLine($"Uff {petName} needs rest. Please allow {petName} to take a nap");
                }
                else
                {
                    Console.WriteLine($"{petName} is fit and happy");
                }

                
            }



















        }
    }
}
