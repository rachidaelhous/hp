using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Fleet_factory.BLL
{
    [Serializable] // Marking the class as serializable
    public class GasolineVehicle : Vehicle
    {
        // Private field for fuel consumption rate
        private double fuelConsumptionRate;

        // Default constructor: initializes fuel consumption rate to 0
        public GasolineVehicle()
            : base()  // Calls the base class constructor
        {
            this.fuelConsumptionRate = 0.0;
        }

        // Constructor with parameters to initialize all fields, including inherited ones
        public GasolineVehicle(string serialNumber, string made, EnumModel model, Date madeDate, double tripCounter, EnumVehicleType vehicleType, double fuelConsumptionRate)
            : base(serialNumber, made, model, madeDate, tripCounter, vehicleType)  // Calls the base class constructor with parameters
        {
            this.fuelConsumptionRate = fuelConsumptionRate;
        }

        // Property to get and set fuel consumption rate
        public double FuelConsumptionRate
        {
            get { return this.fuelConsumptionRate; }
            set { this.fuelConsumptionRate = value; }
        }

        // Overriding the abstract method CalculateMileageEfficiency from the base class
        public override double CalculateMileageEfficiency()
        {
            // If fuel consumption rate is greater than 0, calculate mileage efficiency
            if (fuelConsumptionRate > 0)
            {
                return TripCounter / fuelConsumptionRate;  // Returns efficiency in kilometers per liter
            }
            else
            {
                return 0.0;  // If no fuel is consumed, efficiency is 0
            }
        }

        // Overriding ToString method to include fuel consumption rate in the output
        public override string ToString()
        {
            return $"{base.ToString()}, Fuel Consumption Rate: {this.fuelConsumptionRate}";  // Calls base ToString() and appends fuel consumption rate
        }
    }
}
