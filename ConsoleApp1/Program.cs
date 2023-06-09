namespace ConsoleApp1
{
    using System;

    class Building
    {
        public int Floors;
        public int Area;
        public int Occupants;

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();
            int areaPP;

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            areaPP = house.AreaPerPerson();

            Console.WriteLine("Дом имеет \n  " +
                house.Floors + " этажа \n  " +
                house.Occupants + " жильца \n  " +
                house.Area +
                " кв. футов общей площади, из них \n  " +
                areaPP + " приходится на одного человека");
            Console.WriteLine();

            areaPP = office.AreaPerPerson();

            Console.WriteLine("Учереждение имеет \n  " +
                office.Floors + " этажа \n  " +
                office.Occupants + " работников \n  " +
                office.Area +
                " кв футов общей площади из них \n  " +
                areaPP + " приходится на одного человека");

            if (house.AreaPerPerson() > office.AreaPerPerson())
            {
                Console.WriteLine("В доме больше места для каждого человека");
            }
        }
    }
    
}