using System;

namespace Vehicle_Fleet_factory.BLL
{
    [Serializable] // Marking the class as serializable
    // HybridVehicle class inherits from Vehicle, adding fuel and battery consumption rates
    public class HybridVehicle : Vehicle
    {
        // Fields for fuel and battery consumption rates
        private double fuelConsumptionRate;
        private double batteryConsumptionRate;

        // Default constructor: Initializes base class properties and sets default values for hybrid vehicle properties
        public HybridVehicle()
            : base() // Calls the base class constructor
        {
            this.fuelConsumptionRate = 0.0;
            this.batteryConsumptionRate = 0.0;
        }

        // Properties for fuel and battery consumption rates
        public double FuelConsumptionRate
        {
            get { return this.fuelConsumptionRate; }
            set { this.fuelConsumptionRate = value; }
        }

        public double BatteryConsumptionRate
        {
            get { return this.batteryConsumptionRate; }
            set { this.batteryConsumptionRate = value; }
        }

        // Constructor: Initializes both base class properties and hybrid-specific properties
        public HybridVehicle(string serialNumber, string made, EnumModel model, Date madeDate, double tripCounter, EnumVehicleType vehicleType, double fuelConsumptionRate, double batteryConsumptionRate)
            : base(serialNumber, made, model, madeDate, tripCounter, vehicleType) // Inherits and initializes base class properties
        {
            this.fuelConsumptionRate = fuelConsumptionRate;
            this.batteryConsumptionRate = batteryConsumptionRate;
        }

        // Override method to calculate mileage efficiency based on fuel and battery consumption
        public override double CalculateMileageEfficiency()
        {
            double totalConsumption = FuelConsumptionRate + BatteryConsumptionRate;

            // If total consumption is greater than 0, calculate efficiency; otherwise, return 0
            return totalConsumption > 0 ? TripCounter / totalConsumption : 0.0;
            // second way
            /* if (totalConsumption > 0)
            {
                return TripCounter / totalConsumption;  
            }
            else
            {
                return 0.0;  
            }*/
        }

        // Override ToString to include hybrid vehicle-specific consumption rates
        public override string ToString()
        {
            // Call the base class ToString() to get basic vehicle info, then add hybrid-specific details
            return $"{base.ToString()}, Fuel Consumption Rate: {this.fuelConsumptionRate}, Battery Consumption Rate: {this.batteryConsumptionRate}";
        }
    }
}
