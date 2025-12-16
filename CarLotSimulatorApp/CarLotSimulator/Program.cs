using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            
            //TODO
            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "Civic";
            carOne.Year = 1972;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vrooom");
            carOne.MakeHonkNoise("Beep");

            

            var carTwo = new Car()
            {
                Make = "Jeep",
                Model = "Wrangler",
                Year = 1986,
                IsDriveable = true,
            };
            
            carTwo.MakeEngineNoise("Vrooom Vrooom");
            carTwo.MakeHonkNoise("Beep Beep");
            
            

            var carThree = new Car("Nissan", "Altima", 1982, true);
            carThree.MakeEngineNoise("Vrooom Vrooom Vroooom");
            carThree.MakeHonkNoise("Beeep Beeep Beeep");
            
            
            carLotOne.ParkingLot.Add(carOne);
            carLotOne.ParkingLot.Add(carTwo);
            carLotOne.ParkingLot.Add(carThree);
            
            carLotOne.CheckCars();



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
