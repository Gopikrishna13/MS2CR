using System;

namespace BikeRental1
{
    public class ElectricBike:Bike
{

    public string BatteryCapacity{get;set;}
    public string HorsePower{get;set;}

    public ElectricBike(int Id,string brand,string model,decimal rentalprice,string batterycapacity,string horsepower):base(Id,brand,model,rentalprice)
    {
        this.BatteryCapacity=batterycapacity;
        this.HorsePower=horsepower;
    }

    // public void DisplayElectricBikeInfo()
    // {
    //     string bikeinfo=DisplayBikeInfo();
    //     Console.WriteLine($"{bikeinfo},BatteryCapacity:{BatteryCapacity},HorsePower:{HorsePower}");
    // }

    public override string DisplayBikeInfo()
    {
        string bikeinfo=base.DisplayBikeInfo();
        return ($"{bikeinfo},BatteryCapacity:{BatteryCapacity},HorsePower:{HorsePower}");

    }

}

}


