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
            string petType = " \n 1.Cat \n 2.Dog \n 3.Rabbit ";

            Console.WriteLine($"Please choose a type of pet: {petType}");

            /*Get the user's pet choice*/
            Console.WriteLine("User Input: ");
            int a = Convert.ToInt32(Console.ReadLine());

            /* Display the chosen pet type and ask for the pet's name*/

            if (a == 1)
            {
                Console.WriteLine($"You have chosen a Cat. What would you like to name your pet?");
            }
            else if (a == 2)
            {
                Console.WriteLine($"You have chosen a Dog. What would you like to name your pet?");
            }
            else if(a == 3)
            {
                Console.WriteLine($"You have chosen a Rabbit. What would you like to name your pet?");
            }
            else 
            {
                Console.WriteLine("Bad Input");
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
            string action = $"Main Menu: \n 1.{firstAction} {petName} \n 2.{secondAction} with {petName} \n 3.Let {petName} {thirdAction} " +
                $"\n 4.Check {petName}'s {fourthAction} \n 5.{fifthAction}";
            int hunger = 4;
            int happy = 4;
            int health = 5;

            /*Get the action request from user*/
            for (int i = 0; i <= 10; i++)

            {
                Console.WriteLine(action);
                Console.WriteLine("User Input:");
                int b = Convert.ToInt32(Console.ReadLine());

                /*Implementing the pet care actions and change status as per request*/
                switch (b)
                {
                    case 1:
                        Console.WriteLine($"Great!! {petName} is fed well and is now energetic.");
                        hunger = hunger - 1;
                        health = health + 1;
                        happy = happy - 1;
                        break;
                    case 2:
                        Console.WriteLine($"Wonderful!!{petName} played well and he is happy.");
                        hunger = hunger + 1;
                        happy = happy + 2;
                        health = health - 1;
                        break;
                    case 3:
                        Console.WriteLine($"Shh!!{petName} is taking a nap.");
                        happy = happy - 1;
                        health = health + 2;
                        hunger = hunger - 1;
                        break;
                    case 4:
                        Console.WriteLine($"{petName}'s  {fourthAction}: \n - Hunger : {hunger} \n - Happiness : {happy} \n - Health : {health}");
                        break;
                    case 5:
                        Console.WriteLine($"Bye {petName} see you tomorrow!!");
                        return;

                    default:
                        Console.WriteLine("Bad Input");
                        break;
                }
                /* Maintain the pet status on a scale of 1-10. If status rise or drop, it should be defaulted*/
                if (hunger > 10 || hunger < 1)
                {
                    if (hunger > 10)
                    {
                        hunger = 10;
                    }
                    else 
                    {
                        hunger = 1;
                    }
                }
                if (happy > 10 || happy < 1)
                {
                    if (happy > 10)
                    {
                        happy = 10;
                    }
                    else
                    {
                        happy = 1;
                    }
                }
                if (health > 10 || health <1 ) 
                {
                  if (health > 10)
                    {
                        health = 10;
                    }
                    else
                    {
                        health = 1;
                    }
                }
                /* Check for critical conditions for the pet status. Warning message and guidance to overcome it. */
                if (hunger > 6 && health < 3)
                {
                    Console.WriteLine($"Grrrr..{petName} is hungry and his health is deterioating. Please feed {petName}!!");
                }
                else if ((happy < 3 && hunger < 3) || (happy < 3 && health > 5))
                {
                    Console.WriteLine($"Hmmm... {petName} is sad he needs to play.");
                }
                else if (happy > 6 && health < 3)
                {
                    Console.WriteLine($"Uff {petName} needs rest. Please allow {petName} to take a nap.");
                }
                else
                {
                     Console.WriteLine(" ");     
                }
            }
        }
    }
}
