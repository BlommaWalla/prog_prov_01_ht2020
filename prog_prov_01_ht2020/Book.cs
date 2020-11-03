using System;

namespace prog_prov_01_ht2020
{
    //this is the book class
    public class Book
    {
        //these variables specify the type, value, rarity, number in the inventory, curse and player assigned value
        public string type;
        public int rarity;
        public float value;
        public bool curse = false;
        public float assignedValue = 0;


        //more rare books sell for higher prices
        public int[,] rarities = { { 0, 10 }, { 1, 20 }, { 2, 50 }, { 3, 100 }, { 4, 1000 }, { 5, 5000 } };

        //diffrent types sell for diffrent prices, they are used in the Evaluator() method above, their position is their individual price
        public string[] types = { "cookbook", "fantasy book", "note book", "dictionary", "old spelltome", "children's book", "horror book", "learn JavaScript book" };



        //this method runs simultainously as the class is instantiated, it assignes curse, rarity and value
        public Book()
        {
            Random random = new Random();

            rarity = random.Next(0, 6);
            value = random.Next(0, 4);

            int curseChance = random.Next(0, 1);
            if (curseChance == 0)
            {
                curse = true;
            }


            rarity = rarities[1, random.Next(0, rarities.GetLength(1))];

            type = types[random.Next(0, types.Length)];
        }

    }
}
