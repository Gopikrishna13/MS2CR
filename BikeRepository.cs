using System;
using Microsoft.Data.SqlClient;

namespace BikeRental1
{

    public class BikeRepository
{

    string connectionstring = "Server=DESKTOP-HUP2D4T\\SQLEXPRESS;Database=BikeRentalManagement;Integrated Security=SSPI;TrustServerCertificate=True;";

public string Capitalize(string brand)
{
    return brand.Substring(0,1).ToUpper()+brand.Substring(1);
}
    public void CreateBike(Bike bike)
    {
        try{

            var query=@"Insert into Bikes (Brand,Model,RentalPrice) values(@brand,@model,@price)";
            string capBrand=Capitalize(bike.Brand);

            using(var connection=new SqlConnection(connectionstring))
            {
                using(var command=new SqlCommand(query,connection))
                {
                    connection.Open();
                   // command.Parameters.AddWithValue("@brand",bike.Brand);
                    command.Parameters.AddWithValue("@brand",capBrand);
                    command.Parameters.AddWithValue("@model",bike.Model);
                    command.Parameters.AddWithValue("@price",bike.RentalPrice);

                    var result=command.ExecuteNonQuery();

                    if(result > 0)
                    {
                        Console.WriteLine("Data Added!");
                    }else{
                         Console.WriteLine("Failed!");
                    }

                }
            }

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }


    public void ReadBikes()
    {
        try{

            var query=@"Select * from Bikes";

            using(var connection=new SqlConnection(connectionstring))
            {
                using(var command=new SqlCommand(query,connection))
                {
                    connection.Open();
                    SqlDataReader reader=command.ExecuteReader();

                    while(reader.Read())
                    {
                        Console.WriteLine(reader["BikeId"]+","+reader["Brand"]+","+reader["Model"]+","+reader["RentalPrice"]);
                    }

                }
            }

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }


    public void DeleteBike(int Id)
    {
        bool result=checkId(Id);
        if(result)
        {
            var query=@"Delete from Bikes where BikeId=@Id";

            using(var connection=new SqlConnection(connectionstring))
            {
                using(var command=new SqlCommand(query,connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id",Id);
                    command.ExecuteNonQuery();

                   
                }
            }

        }else{
            Console.WriteLine("Invalid Id");
        }


    }


    public bool checkId(int Id)
    {
        try
            {
                var query = "select count(1) from Bikes where BikeId=@Id";
                var result = 0;
                using (var connection = new SqlConnection(connectionstring))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        connection.Open();
                        result = (int)command.ExecuteScalar();
                    }
                }

                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; 
            }
      
    }

    public void Updatebike(Bike bike)
    {
        try{
             bool result=checkId(bike.BikeId);
             if(result)
             {
                  var query=@"Update Bikes set Brand=@brand,Model=@model,RentalPrice=@price
            where BikeId=@Id";

            using(var connection=new SqlConnection(connectionstring))
            {
                using(var command=new SqlCommand(query,connection))
                {
                    
                    connection.Open();
                    command.Parameters.AddWithValue("@Id",bike.BikeId);
                    command.Parameters.AddWithValue("@brand",bike.Brand);
                    command.Parameters.AddWithValue("@model",bike.Model);
                    command.Parameters.AddWithValue("@price",bike.RentalPrice);

                  command.ExecuteNonQuery();
                   
                }
            }


             }else{
                Console.WriteLine("No ID");
             }
          


        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }


}

}


