using System;
using System.Collections.Generic;

namespace prog_prov_01_ht2020
{
    class Program
    {

        //This is a method vor assigning a value to a book. 
        //It uses a simple formula based on the random value (val), the price of the rarity (price) and the int value of the typ 
        //the price is divided by 5 if the book is cursed
        static int Evaluator(int val, int price, int type, bool cursed)
        {
            //the curse variable, if cursed it will increase to 5
            int c = 1;

            if (cursed)
            {
                c = 5;
            }

            //this is the formula used to calculate a books true value
            int n = (price ^ (val / 2) * type) / c;
            return n;
        }

        //this is a method for assigning types to books, to be used both with customers who want diffrent types and also in price gauging
        static int TypeAssign(string[] allTypes)
        {
            //the type is randomed among every type in the array below
            //the type is assigned belw aswell
            int t;
            int n = allTypes.Length;

            Random random = new Random();
            t = random.Next(0, n);

            return t;
        }

        static void Main(string[] args)
        {
            //the money is diplayed on screen and shows if you can buy books
            int moneyAmount = 100;

            //more rare books sell for higher prices
            int[] rarityPrices = { 10, 20, 50, 100, 1000, 5000 };

            //diffrent types sell for diffrent prices, they are used in the Evaluator() method above, their position is their individual price
            string[] types = { "cookbook", "fantasy book", "note book", "dictionary", "old spelltome" };

            //this is where all books are kept
            var bookInventory = new List<Book>();

            //while this bool is false the game runs
            bool exit = false;

            //introducing text and rules
            Console.WriteLine("Welcome to the book store game! (GoTY sertified)");
            Console.WriteLine("The game is simple and the rules are as follow");
            Console.WriteLine("Books are presented and you get to choose if you want to buy them");
            Console.WriteLine("Just type Yes (Y) or No (n) to chose (if you can afford it)");
            Console.WriteLine("Your money will be displayed");


            //this gives the player a few books to start out with, they are put in the inventory
            for (int i = 0; i < 3; i++)
            {
                bookInventory.Add(new Book { number = i });
            }

            //this is the main gameloop
            while (!exit)
            {





            }


            Console.ReadLine();

        }

    }
}
