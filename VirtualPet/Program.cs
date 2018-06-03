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
            Pet tyson = new Pet("Tyson", 25, 15, 25, 15);
            Console.WriteLine("Welcome to Virtual Tyson Management Console");
            Console.WriteLine("Please type Yes to manage the {0} dog?", tyson.Name);
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("yes"))
            {
                Console.WriteLine("Please select from the following to manage the {0} dog", tyson.Name);

                Console.WriteLine("Select 1 to get the status of the {0} dog", tyson.Name);
                Console.WriteLine("Select 2 to feed the {0} dog", tyson.Name);
                Console.WriteLine("Select 3 to give water the {0} dog", tyson.Name);
                Console.WriteLine("Select 4 to walk the {0} dog", tyson.Name);
                Console.WriteLine("Select 5 to let the {0} dog sleep", tyson.Name);
                int userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        tyson.GetTick();
                        if (tyson.HungerAlert)
                        {
                            Console.WriteLine("The {0} is  hungry and needs to be fed.", tyson.Name);
                            Console.WriteLine("Please enter a new food level for the {0} dog", tyson.Name);
                            int newHunger = int.Parse(Console.ReadLine());
                            tyson.SetHunger(newHunger);
                        }

                        if (tyson.ThirstAlert)
                        {
                            Console.WriteLine("The {0} is thirsty and needs water.", tyson.Name);
                            Console.WriteLine("Please enter a new water level for the {0} dog", tyson.Name);
                            int thirstLevel = int.Parse(Console.ReadLine());
                            tyson.SetThirst(int.Parse(Console.ReadLine()));

                        }
                        Console.WriteLine("The {0} dog is {1} hungry and has a thirst level of {2}", tyson.Name, tyson.Hunger, tyson.Thirst);
                        break;

                    case 2:
                        tyson.GetTick();
                        Console.WriteLine("Enter a new boredom level.");
                        int boredom = int.Parse(Console.ReadLine());
                        tyson.SetBoredom(boredom);
                        Console.WriteLine("The new boredom level of the {0} dog is {1}", tyson.Name, tyson.Boredom);
                        break;
                    case 3:
                        tyson.GetTick();
                        Console.WriteLine("Enter a new tiredness level.");
                        int tiredness = int.Parse(Console.ReadLine());
                        tyson.SetTiredness(tiredness);
                        Console.WriteLine("The new tiredness level of the {0} dog is {1}", tyson.Name, tyson.Tiredness);
                        break;
                    default:
                        break;
                }
                tyson.GetTick();
                Console.WriteLine("Please type Yes to manage the {0} dog?", tyson.Name);
                userResponse = Console.ReadLine().ToLower();
            }//While end
        }//Static Void Main End
    }//Class end
}//Namespace end
