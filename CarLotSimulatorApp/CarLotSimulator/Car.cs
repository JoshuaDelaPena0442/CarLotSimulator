using System;

namespace CarLotSimulator;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"{Make} {Model}'s, make this engine sound {EngineNoise}");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"{Make} {Model}'s, honk like this {HonkNoise}");
    }

    public Car()
    {
        CarLot.numberOfCars++;
    }

    public Car(string make, string model, int year, bool isDriveable)
    {
        Make = make;
        Model = model;
        Year = year;
        IsDriveable = isDriveable;
    }
}