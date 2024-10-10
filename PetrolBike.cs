using System;

namespace BikeRental1
{
    public class PetrolBike:Bike
{
public string FuelTankCapacity{get;set;}
public string EngineCapacity{get;set;}

 public PetrolBike(int Id,string brand,string model,decimal rentalprice,string FuelTankCapacity,string EngineCapacity):base(Id,brand,model,rentalprice)
    {
        this.FuelTankCapacity=FuelTankCapacity;
        this.EngineCapacity=EngineCapacity;
    }

    // public void DisplayPetrolBikeInfo()
    // {
    //     string bikeinfo=DisplayBikeInfo();
    //     Console.WriteLine($"{bikeinfo},FuelTankCapacity:{FuelTankCapacity},EngineCapacity:{EngineCapacity}");
    // }
public override string DisplayBikeInfo()
{
    string bikeinfo=base.DisplayBikeInfo();
     return ($"{bikeinfo},FuelTankCapacity:{FuelTankCapacity},EngineCapacity:{EngineCapacity}");

}
}


}

