using System;
using System.Linq;
using System.Collections.Generic;

namespace BikeRental1
{
    public class BikeManager
{

    public List <Bike> BikeList=new List <Bike>();
    BikeRepository repository=new BikeRepository();

public void CreateBike()
{

    Console.Write("Enter ID:");
    int Id=int.Parse(Console.ReadLine());
          Console.Write("Enter Brand:");
        string brand=Console.ReadLine();

        Console.Write("Enter Model:");
        string model=Console.ReadLine();

        Console.Write("Enter Rental Price:");
        decimal price=decimal.Parse(Console.ReadLine());

        bool chkprice=checkPrice(price);
       

        if(chkprice)
        {
            //  Bike bike=new Bike(brand,model,price);
            // repository.CreateBike(bike);
            Bike bike=new Bike(Id,brand,model,price);
            Bike.TotalBikes++;
            Console.Write("Choose : 1.Elecric Bike 2.Petrol Bike");

            int response=int.Parse(Console.ReadLine());

            if(response==1)
            {
                Console.Write("Battery Capcity :");
                string capacity=Console.ReadLine();

                Console.Write("Horse Power:");
                string horsepower=Console.ReadLine();

                ElectricBike ebike=new ElectricBike(Id,brand,model,price,capacity,horsepower);
              //  ebike.DisplayElectricBikeInfo();
             Console.WriteLine(ebike.DisplayBikeInfo());
            }else if(response==2)
            {
                Console.Write("Fuel Capcity :");
                string fuelcapacity=Console.ReadLine();

                Console.Write("Engine Capacity:");
                string enginecapacity=Console.ReadLine();

                PetrolBike ebike=new PetrolBike(Id,brand,model,price,fuelcapacity,enginecapacity);
                //ebike.DisplayPetrolBikeInfo();
                  Console.WriteLine(ebike.DisplayBikeInfo());

            }else{
                Console.WriteLine("Invalid option");
            }
            BikeList.Add(bike);

           
        }else{
            Console.WriteLine("Price should be positive");
        }

    // bool chkId=checkforId(Id);
    // if(!chkId)
    // {

    //     Console.Write("Enter Brand:");
    //     string brand=Console.ReadLine();

    //     Console.Write("Enter Model:");
    //     string model=Console.ReadLine();

    //     Console.Write("Enter Rental Price:");
    //     decimal price=decimal.Parse(Console.ReadLine());

    //     bool chkprice=checkPrice(price);

    //     if(chkprice)
    //     {
    //         Bike bike=new Bike(Id,brand,model,price);
    //         BikeList.Add(bike);

    //         Console.WriteLine("Bike Details Added Successfully");
    //     }else{
    //         Console.WriteLine("Price should be positive");
    //     }

    // }else{
    //     Console.WriteLine("ID already exists!");
    // }

}


public  bool checkforId(int Id)
{
    var result=BikeList.Any(x=>x.BikeId==Id);

    return result;
}

public bool checkPrice(decimal price)
{
    if(price>0)
    {
        return true;
    }else{
        return false;
    }
}

public void ReadBikes()
{
    // foreach(var bike in BikeList)
    // {
    //     Console.WriteLine(bike);
    // }

    repository.ReadBikes();

}

public void DeleteBike()
{

    Console.Write("Enter ID to delete :");
    int Id=int.Parse(Console.ReadLine());
    repository.DeleteBike(Id);

    // bool chkId=checkforId(Id);

    // if(chkId)
    // {

    //     var bikeremove=BikeList.Single(x=>x.BikeId==Id);
    //     BikeList.Remove(bikeremove);

    //     Console.WriteLine("Bike Deleted Successfully");

    // }else{
    //     Console.WriteLine("Invaid Id");
    // }


}

public void UpdateBike()
{

    Console.Write("Enter Id to Update :");
    int Id=int.Parse(Console.ReadLine());

        Console.Write("Enter Brand:");
        string brand=Console.ReadLine();

        Console.Write("Enter Model:");
        string model=Console.ReadLine();

        Console.Write("Enter Rental Price:");
        decimal price=decimal.Parse(Console.ReadLine());

        bool chkprice=checkPrice(price);

        if(chkprice)
        {
           
            Bike bike=new Bike(Id,brand,model,price);
            repository.Updatebike(bike);
           

        }else{
            Console.WriteLine("Price should be positive");
        }
    // bool checkId=checkforId(Id);

    // if(checkId)
    // {
    //     Console.Write("Enter Brand:");
    //     string brand=Console.ReadLine();

    //     Console.Write("Enter Model:");
    //     string model=Console.ReadLine();

    //     Console.Write("Enter Rental Price:");
    //     decimal price=decimal.Parse(Console.ReadLine());

    //     bool chkprice=checkPrice(price);

    //     if(chkprice)
    //     {
    //         var updatebike=BikeList.Single(x=>x.BikeId==Id);
    //         BikeList.Remove(updatebike);
    //         Bike bike=new Bike(Id,brand,model,price);
    //         BikeList.Add(bike);

    //         Console.WriteLine("Bike Updated Successfully");
    //     }else{
    //         Console.WriteLine("Price should be positive");
    //     }


    // }else{
    //     Console.WriteLine("Id Invalid");
    // }

}


}


}

