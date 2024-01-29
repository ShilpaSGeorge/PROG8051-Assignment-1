﻿using System;
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
            Console.WriteLine($"Please choose a type of pet: 1.{firstPet} 2.{secondPet} 3.{thirdPet}");

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



        }
    }
}