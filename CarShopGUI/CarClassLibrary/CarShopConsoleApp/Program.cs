using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store CarStore = new Store();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Primordial Engines! First you must create some cars and put them into the store inventory, then " +
                "you may add cars to the cart. Finally you may checkout, which " +
                "will calculate your total bill.");

            int action = chooseAction();
            while (action != 0)
            {
                switch (action)
                {
                    case 1:

                        Console.Out.Write("You chose to add a new car to the store:");

                        String carMake = "";
                        String carColor = "";
                        String carModel = "";
                        int carYear = 0;
                        Decimal carPrice = 0;

                        Console.Out.Write("What is the car make? Ford, GM, Toyota etc ");
                        carMake = Console.ReadLine();

                        Console.Out.Write("What is the car Color? ");
                        carColor = Console.ReadLine();

                        Console.Out.Write("What is the car Modle? Corvette, Raptor, Ranger ");
                        carModel = Console.ReadLine();

                        Console.Out.Write("What is the car Year? Only numbers please between 1981 and {0} ", (DateTime.Now.Year + 1));
                        // TryParse to make sure only numbers are entered
                        if (!int.TryParse(Console.ReadLine(), out carYear))
                        {
                            Console.Out.Write("Please enter a valid year between 1981 and {0} " + Environment.NewLine, (DateTime.Now.Year + 1));
                            break;                           
                        }
                        // Make sure we get a valid Year
                        if (!(carYear >= 1981) | !(carYear <= (DateTime.Now.Year + 1)))
                        {
                            Console.Out.Write("Please enter a valid year between 1981 and {0} " + Environment.NewLine, (DateTime.Now.Year + 1));
                            break;
                        }
                        

                        Console.Out.Write("What is the car price? Only numbers please ");
                        // TryParse to make sure only numbers are entered
                        if (!Decimal.TryParse(Console.ReadLine(), out carPrice))
                        {                      
                            Console.Out.Write("Please enter a valid price point" + Environment.NewLine);
                            break;
                        }
                        // Make sure we get a valid price
                        else if (!(carPrice >= 0))
                        {
                            Console.Out.Write("Please enter a valid price point" + Environment.NewLine);
                            break;
                        }

                        Car newCar = new Car();
                        newCar.Make = carMake;
                        newCar.Color = carColor;
                        newCar.Model = carModel;
                        newCar.Year = carYear;
                        newCar.Price = carPrice;
                        CarStore.CarList.Add(newCar);
                        printStoreInventory(CarStore);
                        break;

                    case 2:

                        printStoreInventory(CarStore);

                        int choice = 0;
                        Console.Out.Write("Which car would you like to add to the cart? (number) ");
                        choice = int.Parse(Console.ReadLine());

                        CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                        printShoppingCart(CarStore);

                        break;

                    case 3:

                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Your totla cost is ${0}", CarStore.checkout());

                        break;

                    case -1:
                        // Default error zone
                        break;

                    default:
                        Console.Out.Write("Error, please enter a number 1 through 3 only" + Environment.NewLine);
                        break;
                }

                action = chooseAction();
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.Out.Write("Choose an action and action (0) quit (1) add a car (2) add items to cart (3) checkout ");
            // TryParse to make sure only numbers are entered
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Out.Write("Error: Please enter a number between 0 and 3 " + Environment.NewLine);
                chooseAction();
                return -1;
            }
            else
            {
                return choice;
            }
        }

        static public void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory:" + Environment.NewLine);
            int i = 0;
            foreach (var c in carStore.CarList)
            {
                Console.Out.Write(String.Format("Car # = {0} {1}" + Environment.NewLine, i, c.Display));
                i++;
            }
        }

        static public void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart;" + Environment.NewLine);
            int i = 0;
            foreach (var c in carStore.ShoppingList)
            {
                Console.Out.Write(String.Format("Car # = {0} {1}" + Environment.NewLine, i, c.Display));
                i++;
            }
        }
    }
}
