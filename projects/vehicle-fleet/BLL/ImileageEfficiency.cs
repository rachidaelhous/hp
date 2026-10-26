using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vehicle_Fleet_factory.BLL
{
    // Interface for calculating mileage efficiency
    public interface IMileageEfficiency
    {
        // Method signature for calculating mileage efficiency
        // In C#, methods in interfaces are implicitly public and abstract, so no need to specify these modifiers
        // Method signature refers to the method's name, return type, and parameter types, excluding the method body
        double CalculateMileageEfficiency();
    }
}
