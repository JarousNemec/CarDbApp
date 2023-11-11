using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CarDbApp.Models;

namespace CarDbApp.Services
{
    public class DbService
    {
        string _connectionString;
        SqlConnection _connection;

        public DbService()
        {
            SqlConnectionStringBuilder builder = new();
            builder.UserID = "SA";
            builder.Password = "Heslo1234.";
            builder.DataSource = "127.0.0.1,1433";
            builder.InitialCatalog = "carDatabase";
            builder.TrustServerCertificate = true;

            _connectionString = builder.ToString();
        }

        //Volat metodu
        public bool Connect()
        {
            _connection = new SqlConnection(_connectionString);

            try
            {
                _connection.Open();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                //TODO: udělat na to UI :) užij si to!
                return false;
            }
        }

        public bool CarExists(int CarId)
        {
            using (SqlCommand cmd = new($"select count(*) from cars.carsTable C where CarId = {CarId}", _connection))
            {
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        int result = reader.GetInt32(0);

                        return result > 0;
                    }
                }
                catch (Exception e)
                {
                    //TODO: udělat na to UI :) užij si to!
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }
        
        public List<CarModel> LoadCars()
        {
            List<CarModel> cars = new List<CarModel>();
            using (SqlCommand cmd = new($"select * from cars.carsTable ", _connection))
            {
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Add(new()
                            {
                                CarId = reader.GetInt32(0),
                                State = reader.GetInt32(1),
                                Error = false,
                                Exists = true,
                                Spz = reader.GetString(2),
                                Model = reader.GetString(3),
                                LastUpdate = reader.GetDateTime(4),
                                FirstDriver = reader.GetString(5)
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }

            return cars;
        }

        public void InsertOrUpdate(CarModel car)
        {
            if (CarExists(car.CarId))
            {
                using (SqlCommand cmd =
                       new($"UPDATE cars.carsTable SET State = '{car.State}', SPZ = '{car.Spz}', Model = '{car.Model}', LastUpdate = '{car.LastUpdate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}', FirstDriver = '{car.FirstDriver}' where CarId = {car.CarId}",
                           _connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
            }
            else
            {
                using (SqlCommand cmd =
                       new(
                           $"INSERT INTO cars.carsTable (CarId, State, SPZ, Model, LastUpdate, FirstDriver) VALUES('{car.CarId}', '{car.State}', '{car.Spz}', '{car.Model}', '{car.LastUpdate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}', '{car.FirstDriver}')",
                           _connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
            }
            // INSERT INTO carDatabase.cars.carsTable (CarId, State, SPZ, Model, LastUpdate, FirstDriver) VALUES(2, 3, N'gfdfas', N'skoda', N'2023-11-10 10:06:59.000', N'Jarda');
            // UPDATE table_name SET column1 = value1, column2 = value2, ... WHERE condition;
        }

        public bool DeleteCar(CarModel car)
        {
            if (CarExists(car.CarId))
            {
                using (SqlCommand cmd =
                       new($"DELETE FROM cars.carsTable where CarId = {car.CarId}",
                           _connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                        return false;
                    }
                }
            }
            return false;
        }
    }
}