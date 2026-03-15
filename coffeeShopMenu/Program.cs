namespace coffeeShopMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            string drink = "";
            int size = 250;

            Console.WriteLine("Welcome to Barista Coffee Shop");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Double Espresso ");
            Console.WriteLine("3. Espresso Macchiato");
            Console.WriteLine("4. Americano");
            Console.WriteLine("5. Lungo");
            Console.WriteLine("6. Flat White");
            Console.WriteLine("7. Cappuccino");
            Console.WriteLine("8. Hot Chocolate ");
            Console.WriteLine("9. Mocha");
            Console.WriteLine("10. Latte Macchiato ");
            Console.WriteLine("11. Decaffeniated Espresso ");
            Console.WriteLine("12. Tea ");
            Console.WriteLine("13. Herbal Tea");


            Console.WriteLine("Which coffee would you like to order?");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    drink = "Espresso";
                    Console.WriteLine("Espresso is available only in 250ml.");
                    price = 1.95;
                    break;

                case 2:
                    drink = "Double Espresso";
                    Console.WriteLine("Double Espresso is available only in 250ml.");
                    price = 2.85;
                    break;

                case 3:
                    drink = "Espresso Macchiato";
                    Console.WriteLine("Espresso Macchiato is available only in 250ml.");
                    price = 2.25;
                    break;

                case 4:
                    drink = "Americano";
                    Console.WriteLine("Would you like 250ml or 350ml? Select size: 1. 250ml  2. 350ml");
                    int cupSize = Convert.ToInt32(Console.ReadLine());

                    switch (cupSize)
                    {
                        case 1:
                            size = 250;
                            price = 2.50;
                            break;
                        case 2:
                            size = 350;
                            price = 3.00;
                            break;
                    }
                    break;
                case 5:
                    drink = "Lungo";
                    Console.WriteLine("Lungo is available only in 250ml.");
                    price = 2.25;
                    break;
                case 6:
                    drink = "Flat White";
                    Console.WriteLine("Would you like 250ml or 350ml? Select size: 1. 250ml  2. 350ml");
                    int flatCupSize = Convert.ToInt32(Console.ReadLine());

                    switch (flatCupSize)
                    {
                        case 1:
                            size = 250;
                            price = 2.50;
                            break;
                        case 2:
                            size = 350;
                            price = 3.00;
                            break;
                    }
                    break;
                case 7:
                    drink = "Cappuccino";
                    Console.WriteLine("Would you like 250ml or 350ml? Select size: 1. 250ml  2. 350ml");
                    int cappuccinoCupSize = Convert.ToInt32(Console.ReadLine());

                    switch (cappuccinoCupSize)
                    {
                        case 1:
                            size = 250;
                            price = 2.50;
                            break;
                        case 2:
                            size = 350;
                            price = 3.00;
                            break;
                    }
                    break;

                case 8:
                    drink = "Hot Chocolate";
                    Console.WriteLine("Would you like 250ml or 350ml? Select size: 1. 250ml  2. 350ml");
                    int hotCupSize = Convert.ToInt32(Console.ReadLine());

                    switch (hotCupSize)
                    {
                        case 1:
                            size = 250;
                            price = 3.50;
                            break;
                        case 2:
                            size = 350;
                            price = 4.00;
                            break;
                    }
                    break;

                case 9:
                    drink = "Mocha";
                    Console.WriteLine("Would you like 250ml or 350ml? Select size: 1. 250ml  2. 350ml");
                    int mochaCupSize = Convert.ToInt32(Console.ReadLine());

                    switch (mochaCupSize)
                    {
                        case 1:
                            size = 250;
                            price = 4.00;
                            break;
                        case 2:
                            size = 350;
                            price = 4.50;
                            break;
                    }
                    break;
                
                case 10:
                    drink = "Latte Macchiato";
                    Console.WriteLine("Would you like 250ml or 350ml? Select size: 1. 250ml  2. 350ml");
                    int latteCupSize = Convert.ToInt32(Console.ReadLine());

                    switch (latteCupSize)
                    {
                        case 1:
                            size = 250;
                            price = 3.00;
                            break;
                        case 2:
                            size = 350;
                            price = 3.50;
                            break;
                    }
                    break;
                case 11:
                    drink = "Decaffeniated Espresso";
                    Console.WriteLine("Decaffeniated Espresso is available only in 250ml.");
                    price = 2.25;
                    break;
                case 12:
                    drink = "Tea";
                    Console.WriteLine("Tea is available only in 250ml.");
                    price = 1.85;
                    break;

                case 13:
                    drink = "Herbal Tea";
                    Console.WriteLine("Herbal Tea is available only in 250ml.");
                    price = 2.10;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("Do you want to add extra topping?");
            Console.WriteLine("1. Additional Syrup Topping");
            Console.WriteLine("2. Additional Cream");
            Console.WriteLine("3. Soya/Almond/Lactose-Free Milk");
            Console.WriteLine("4. None");

            int toppingChoice = Convert.ToInt32(Console.ReadLine());
            string topping = "No Topping";

            switch (toppingChoice)
            {
                case 1:
                    topping = "Additional Syrup Topping";
                    price =price+ 1.50;
                    break;

                case 2:
                    topping = "Additional Cream";
                    price = price + 1.50;
                    break;

                case 3:
                    topping = "Soya/Almond/Lactose-Free Milk";
                    price = price + 1.00;
                    break;
            }

            Console.WriteLine("\nOrder Description:");
            Console.WriteLine($"{drink} {size}ml, {topping}, {price:F2}");
        }
    }
}
