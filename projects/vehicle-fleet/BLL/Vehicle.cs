using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vehicle_Fleet_factory.BLL
{
    // Base abstract class for all types of vehicles
    [Serializable]
    [XmlInclude(typeof(GasolineVehicle))]   // Allow XML serialization of derived types
    [XmlInclude(typeof(ElectricVehicle))]
    [XmlInclude(typeof(HybridVehicle))]
    public abstract class Vehicle : Object, IMileageEfficiency
    {
        // Ignore XML serialization for this explicit interface implementation
        [XmlIgnore]
        IMileageEfficiency IMileageEfficiency => this;

        // Private fields
        private string serialNumber;
        private string made;
        private EnumModel model;
        private Date madeDate;
        private double tripCounter;
        private EnumVehicleType vehicleType;

        // Default constructor: initializes all fields to default values
        public Vehicle()
        {
            this.serialNumber = string.Empty;
            this.made = string.Empty;
            this.model = EnumModel.Undefined;
            this.madeDate = new Date();
            this.tripCounter = 0.0;
            this.vehicleType = EnumVehicleType.Undefined;
        }

        // Constructor with parameters
        public Vehicle(string serialNumber, string made, EnumModel model, Date madeDate, double tripCounter, EnumVehicleType vehicleType)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.madeDate = madeDate;
            this.tripCounter = tripCounter;
            this.vehicleType = vehicleType;
        }

        // Vehicle serial number (e.g., VIN)
        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { this.serialNumber = value; }
        }

        // Manufacturer of the vehicle
        public string Made
        {
            get { return this.made; }
            set { this.made = value; }
        }

        // Vehicle model (enum)
        public EnumModel Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        // Manufacture date (custom Date class)
        public Date MadeDate
        {
            get { return this.madeDate; }
            set { this.madeDate = value; }
        }

        // Total distance or number of trips made
        public double TripCounter
        {
            get { return this.tripCounter; }
            set { this.tripCounter = value; }
        }

        // Vehicle type (e.g., electric, hybrid, essence)
        public EnumVehicleType VehicleType
        {
            get { return this.vehicleType; }
            set { this.vehicleType = value; }
        }

        // Overloaded method: Increase trip counter by 1
        public void MakeTrip()
        {
            this.tripCounter += 1;
        }

        // Overloaded method: Add distance to trip counter
        public void MakeTrip(double distance)
        {
            if (distance > 0.0)
            {
                this.tripCounter += distance;
            }
            else
            {
                throw new ArgumentException("Distance cannot be zero or negative.");
            }
        }

        // Abstract method to be implemented in derived classes
        public abstract double CalculateMileageEfficiency();

        // Return a summary of the vehicle's key properties
        public override string ToString()
        {
            return $"Serial Number: {this.serialNumber}, Made: {this.made}, Model: {this.model}, Made Date: {this.madeDate}, Trip Counter: {this.tripCounter}, Vehicle Type: {this.vehicleType}";
        }
    }
}
