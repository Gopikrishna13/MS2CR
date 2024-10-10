using System;

namespace BikeRental1
{

    public class Bike
{

    public int BikeId{get;set;}
    public string Brand{get;set;}
    public string Model{get;set;}
    public decimal RentalPrice{get;set;}

    public static int TotalBikes=0;

    public Bike(int Id,string Brand,string Model,decimal RentalPrice)
    {
        this.BikeId=Id;
        this.Brand=Brand;
        this.Model=Model;
        this.RentalPrice=RentalPrice;

    }

    public Bike(string Brand,string Model,decimal RentalPrice)
    {
        this.Brand=Brand;
        this.Model=Model;
        this.RentalPrice=RentalPrice;
    }

    public override string ToString()
    {
        return $"ID: {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
    }

     public virtual string DisplayBikeInfo()
        {
            return ($"ID :{BikeId} , Brand:{Brand} , Model :{Model}  , RentalPrice :{RentalPrice}");

        }


}


}

