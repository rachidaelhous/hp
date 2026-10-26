using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Fleet_factory.BLL
{
    /// Utility class -- class utilitaire   
    /// Utility class for managing a static collection of Vehicle instances.
    /// Provides methods to add, remove, update, search, and display vehicles. 
    public class DataCollection
    {
        /// Attributes de la classe
        // encapsulate the collection list of employee and offer the public static services (functions - methods) to manipulate the collection

        private static List<Vehicle> listOfVehicles = new List<Vehicle>();

        //Properties public 
        public static List<Vehicle> ListOfVehicles
        {
            get { return listOfVehicles; }
            set { listOfVehicles = value; }
        }

        /*public Vehicle Vehicle
        {
            get => default(Vehicle_Fleet_factory.BLL.Vehicle);
            set
            {
            }
        }*/

        // Public methods to manipulate the collection
        // This method is used to add a vehicle to the list of vehicles
        public static void AddVehicle(Vehicle v)
        {
            listOfVehicles.Add(v);
            Console.WriteLine("Vehicle added!");
        }

        // This method is used to remove a vehicle to the list of vehicles
        public static void RemoveVehicle(Vehicle v)
        {
            if (listOfVehicles.Remove(v))
            {
                Console.WriteLine("Vehicle removed!");
            }
            else
            {
                Console.WriteLine("Vehicle not found in the list.");
            }
        }

        // This method is used to remove a vehicle to the list of vehicles by index
        public static void RemoveVehicleByIndex(int index)
        {
            if (index >= 0 && index < listOfVehicles.Count)
            {
                Vehicle vehicle = listOfVehicles[index];
                RemoveVehicle(vehicle);  // Reusing RemoveVehicle
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        // This method is used to update a vehicle in the list of vehicles
        public static void UpdateVehicle(Vehicle oldVehicle, Vehicle newVehicle)
        {
            int index = listOfVehicles.IndexOf(oldVehicle);
            if (index != -1)
            {
                listOfVehicles[index] = newVehicle;
                Console.WriteLine("Vehicle updated!");
            }
            else
            {
                Console.WriteLine("Vehicle not found in the list.");
            }
        }

        // This method is used to update a vehicle in the list of vehicles by index
        public static void UpdateVehicle(int index, Vehicle newVehicle)
        {
            if (index >= 0 && index < listOfVehicles.Count)
            {
                listOfVehicles[index] = newVehicle;
                Console.WriteLine($"Vehicle at index {index} updated.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        // This method is used to search a vehicle in the list of vehicles by serial number
        public static Vehicle SearchVehicle(string serialNumber)
        {
            foreach (Vehicle vehicle in listOfVehicles)
            {
                if (vehicle.SerialNumber != null && vehicle.SerialNumber == serialNumber)
                {
                    return vehicle;
                }
            }
                return null;
        }

        // This method is used to search a vehicle in the list of vehicles by index
        public static List<Vehicle> GetListVehicles()
        {
            return listOfVehicles;
        }

        // This method is used to get the number of vehicles in the list
        public static int GetNumberOfVehicles()
        {
            return listOfVehicles.Count;
        }

        // This method is used to clear all vehicles in the list
        public static void ClearAllVehicles()
        {
            listOfVehicles.Clear();
            Console.WriteLine("All vehicles have been removed.");
        }

        // This method is used to get the number of vehicles in the list
        public static Vehicle GetVehicleByIndex(int index)
        {
            if (index >= 0 && index < listOfVehicles.Count)
            {
                return listOfVehicles[index];
            }
            return null;
        }

        // This method is used to display all vehicles in the list
        public static void DisplayVehicles()
        {
            Console.WriteLine($"Total vehicles: {GetNumberOfVehicles()}");
            if (listOfVehicles.Count == 0)
            {
                Console.WriteLine("No vehicles in the list.");
            }
            else
            {
                foreach (Vehicle vehicle in listOfVehicles)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
        }
    }

}


