using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet tyson = new Pet("Tyson", 0, 0, 0, 0);
            Console.WriteLine("Welcome to Virtual Tyson Management Console");
            Console.WriteLine("Please type Yes to manage the dog, {0}", tyson.Name);
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("yes"))
            {
                Console.WriteLine("Please select from the following to manage {0}", tyson.Name);

                Console.WriteLine("Select 1 to get the status of {0}", tyson.Name);
                Console.WriteLine("Select 2 to feed {0}", tyson.Name);
                Console.WriteLine("Select 3 to give water to {0}", tyson.Name);
                Console.WriteLine("Select 4 to walk {0}", tyson.Name);
                Console.WriteLine("Select 5 to let {0} sleep", tyson.Name);
                int userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        tyson.GetTick();
                        if (tyson.HungerAlert)
                        {
                            Console.WriteLine("{0} is hungry and needs to be fed.", tyson.Name);
                            Console.WriteLine("Please enter a new food level for {0}", tyson.Name);
                            int newHunger = int.Parse(Console.ReadLine());
                            tyson.SetHunger(newHunger);
                            
                        }

                        if (tyson.ThirstAlert)
                        {
                            Console.WriteLine("{0} is thirsty and needs water.", tyson.Name);
                            Console.WriteLine("Please enter a new water level for {0}", tyson.Name);
                            int newthirstLevel = int.Parse(Console.ReadLine());
                            tyson.SetThirst(newthirstLevel);
                        }

                        if (tyson.BoredomAlert)
                        {
                            Console.WriteLine("{0} is bored and needs to be walked.", tyson.Name);
                            Console.WriteLine("Please enter a new boredom level for {0}.", tyson.Name);
                            int newBoredomLevel = (int.Parse(Console.ReadLine()));
                            tyson.SetBoredom(newBoredomLevel);
                        }

                        if (tyson.TiredAlert)
                        {
                            Console.WriteLine("{0} is tired and needs to sleep.", tyson.Name);
                            Console.WriteLine("Please enter a new tiredness level for {0}.", tyson.Name);
                            int newTirednessLevel = (int.Parse(Console.ReadLine()));
                            tyson.SetTiredness(newTirednessLevel);
                        }


                        Console.WriteLine("{0} has a hunger level of {1}, has a thirst level of {2}, his boredom level is {3}, and his tiredness level is {4}.", tyson.Name, tyson.Hunger, tyson.Thirst, tyson.Boredom, tyson.Tiredness);
                        break;


                    case 2:
                        tyson.GetTick();
                        Console.WriteLine("Enter a new hunger level.");
                        int hunger = int.Parse(Console.ReadLine());
                        tyson.SetHunger(hunger);
                        Console.WriteLine("The new hunger level of {0} is {1}", tyson.Name, tyson.Hunger);
                        break;
                    case 3:
                        tyson.GetTick();
                        Console.WriteLine("Enter a new thirst level.");
                        int thirst = int.Parse(Console.ReadLine());
                        tyson.SetThirst(thirst);
                        Console.WriteLine("The new thirst level of {0} is {1}", tyson.Name, tyson.Thirst);
                        break;
                    case 4:
                        tyson.GetTick();
                        Console.WriteLine("Enter a new boredom level.");
                        int boredom = int.Parse(Console.ReadLine());
                        tyson.SetBoredom(boredom);
                        Console.WriteLine("The new boredom level of {0} is {1}", tyson.Name, tyson.Boredom);
                        break;
                    case 5:
                        tyson.GetTick();
                        Console.WriteLine("Enter a new tiredness level.");
                        int tiredness = int.Parse(Console.ReadLine());
                        tyson.SetTiredness(tiredness);
                        Console.WriteLine("The new tiredness level of {0} is {1}", tyson.Name, tyson.Tiredness);

                        break;
                    default:
                        break;
                }
                tyson.GetTick();
                Console.WriteLine("Please type Yes to manage {0} ?", tyson.Name);
                userResponse = Console.ReadLine().ToLower();
            }//While end
        }//Static Void Main End
    }//Class end
}//Namespace end
