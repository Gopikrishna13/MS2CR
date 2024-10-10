namespace BikeRental1
{

    public class Program
    {
        static void Main(string[] args)
{


//   Bike bike=new Bike(1,"Revolt","CB",3);
//   Console.WriteLine(bike.ToString());

BikeManager manager=new BikeManager();
bool response=true;

while(response)
{
    Console.Write("Bike Rental Management System:\n 1.Add Bikes \n 2.View All Bikes \n 3.UpdateBike \n 4.DeleteBike \n 5.Exit \n Choose an Option:");
    int option=int.Parse(Console.ReadLine());

    switch(option)
    {
        case 1: manager.CreateBike();
        break;

        case 2:manager.ReadBikes();
        break;

        case 3:manager.UpdateBike();
        break;

        case 4:manager.DeleteBike();
        break;

        case 5: response=false;
        break;
        deafult:
        Console.WriteLine("Invalid Option");
        break;
    }
}


}


    }
}
