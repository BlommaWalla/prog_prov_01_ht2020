using System;

namespace prog_prov_01_ht2020
{
    //this is the book class
    public class Book
    {
        //these variables specify the type, value, rarity, number in the inventory, curse and player assigned value
        public int number;
        public string type;
        public int rarity;
        public float value;
        public bool curse = false;
        public float assignedValue = 0;

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




        }

    }
}
