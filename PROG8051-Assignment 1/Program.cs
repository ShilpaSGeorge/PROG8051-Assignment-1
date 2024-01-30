using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine($"Main Menu: \n 1.{firstAction} {petName} \n 2.{secondAction} with {petName} \n 3.Let {petName} { thirdAction} " +
                $"\n 4.Check {petName}'s {fourthAction} \n 5.{fifthAction}");

            /*Get the action request from user*/
            Console.WriteLine("User Input:");
            int b = Convert.ToInt32(Console.ReadLine());

            /*Check for the initial status of pet*/
            int hunger = 4;
            int happy = 3;
            int health = 5;
            
            while(b==4)
            {
                Console.WriteLine($"{petName}'s  {fourthAction}: \n - Hunger : {hunger} \n - Happiness : {happy} \n - Health : {health}");
                return;
            }

            /*Implementing the pet care actions*/

            /*while (b<5)
            {
                if(b==1)
                {
                    Console.WriteLine("Feed Buddy");

                }
            }*/
           


            Console.WriteLine($"{petName}'s status");












        }
    }
}
