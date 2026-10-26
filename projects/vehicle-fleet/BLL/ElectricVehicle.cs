using System;

namespace Vehicle_Fleet_factory.BLL
{
    [Serializable] //Marking the class as serializable
    // Represents an electric vehicle, inheriting from the Vehicle class
    public class ElectricVehicle : Vehicle
    {
        // Field to store battery consumption rate
        private double batteryConsumptionRate;

        // Default constructor initializes battery consumption rate to 0.0
        public ElectricVehicle()
            : base() // Calls the base class constructor
        {
            this.batteryConsumptionRate = 0.0;
        }

        // Constructor with parameters for initializing all fields
        public ElectricVehicle(string serialNumber, string made, EnumModel model, Date madeDate, double tripCounter, EnumVehicleType vehicleType, double batteryConsumptionRate)
            : base(serialNumber, made, model, madeDate, tripCounter, vehicleType) // Calls the base class constructor
        {
            this.batteryConsumptionRate = batteryConsumptionRate;
        }

        // Property for battery consumption rate
        public double BatteryConsumptionRate
        {
            get { return this.batteryConsumptionRate; }
            set { this.batteryConsumptionRate = value; }
        }

        // Calculates mileage efficiency: 1 / battery consumption rate
        public override double CalculateMileageEfficiency()
        {
            return batteryConsumptionRate > 0 ? 1 / batteryConsumptionRate : 0.0;
        }

        // Returns a string representation of the electric vehicle
        public override string ToString()
        {
            return $"{base.ToString()}, Battery Consumption Rate: {this.batteryConsumptionRate}";
        }
    }
}
