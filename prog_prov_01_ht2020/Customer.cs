using System;

namespace prog_prov_01_ht2020
{
    //this is the class for the customer who come to buy and sell books
    //the have different intrests, different amount of money and they might come sell or buy a book
    public class Customer
    {
        public string intrest;
        public int money;

        public bool buying;

        //this method runs simultaniously as the class is instantiated, it decides if the customer is here to buy or sell a book
        public Customer()
        {
            Random random = new Random();
            int buy = random.Next(0, 1);

            if (buy == 0)
            {
                buying = false;
            }
            else
            {
                buying = true;
            }
        }

    }
}
