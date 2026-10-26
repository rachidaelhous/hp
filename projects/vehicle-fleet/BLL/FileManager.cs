using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Vehicle_Fleet_factory.BLL
{
    public class FileManager
    {
        // File paths for the XML and text files.
        // Public static variables holding the paths for the XML and text files.
        // These paths are shared across all instances of FileManager and can be accessed globally.
        public static String xmlFilePath = @"../../DAL/staff.xml";
        public static String textFilePath = @"../../DAL/staff2.txt";

        // Serialize and write a list of vehicles to an XML file
        public static void WriteToXmlFile(List<Vehicle> list)
        {
            var tempPath = Path.GetTempFileName(); // Create a temporary file to store data before replacing the original file
            try
            {
                // XmlSerializer to handle serialization of vehicle list
                var serializer = new XmlSerializer(typeof(List<Vehicle>),
                    new[] {
                        typeof(GasolineVehicle),
                        typeof(ElectricVehicle),
                        typeof(HybridVehicle)
                    });

                // Write the serialized list to the temporary file
                using (var writer = XmlWriter.Create(tempPath, new XmlWriterSettings { Indent = true }))
                {
                    serializer.Serialize(writer, list);
                }

                // Replace the old file with the new one
                File.Delete(xmlFilePath);
                File.Move(tempPath, xmlFilePath);
            }
            catch
            {
                // Clean up temporary file in case of error
                if (File.Exists(tempPath)) File.Delete(tempPath);
                throw;
            }
        }

        // Deserialize and read a list of vehicles from an XML file
        public static List<Vehicle> ReadFromXmlFile()
        {
            // Return an empty list if the file doesn't exist
            if (!File.Exists(xmlFilePath))
                return new List<Vehicle>();

            try
            {
                // Set CloseInput to true to automatically close the underlying input stream when the XmlReader is disposed.
                var settings = new XmlReaderSettings { CloseInput = true };

                // Open the XML file and create an XML reader
                using (var stream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var reader = XmlReader.Create(stream, settings))
                {
                    var serializer = new XmlSerializer(typeof(List<Vehicle>),
                        new Type[] {
                            typeof(GasolineVehicle),
                            typeof(ElectricVehicle),
                            typeof(HybridVehicle)
                        });

                    // Deserialize the XML content into a list of vehicles
                    // If deserialization results in null, return a new empty list instead of nul
                      List<Vehicle> vehicles = (List<Vehicle>)serializer.Deserialize(reader);
                    if (vehicles == null)
                    {
                        return new List<Vehicle>(); // Return a new empty list if deserialization results in null
                    }
                    else
                    {
                        return vehicles; // Otherwise, return the deserialized list
                    }
                     
                }
            }
            catch (Exception ex)
            {
                // Catch and throw an error if deserialization fails
                throw new ApplicationException("XML deserialization failed", ex);
            }
        }

        // Write the list of vehicles to a text file
        public static void WriteToTextFile(List<Vehicle> listOfVehicles)
        {
            try
            {
                // Use StreamWriter to write each vehicle's ToString() representation to the text file
                using (StreamWriter writer = new StreamWriter(textFilePath))
                {
                    foreach (Vehicle vehicle in listOfVehicles)
                    {
                        writer.WriteLine(vehicle.ToString());
                    }
                }
            }
            catch (IOException ex)
            {
                // Catch and throw an error if writing to the text file fails
                throw new ApplicationException("Error writing to text file", ex);
            }
        }

        // Read a list of vehicle information from a text file
        public static List<string> ReadFromTextFile()
        {
            // Return an empty list if the file doesn't exist
            if (!File.Exists(textFilePath))
                return new List<string>();

            try
            {
                // Read all lines from the text file and return as a list of strings
                return File.ReadAllLines(textFilePath).ToList();
            }
            catch (IOException ex)
            {
                // Catch and throw an error if reading from the text file fails
                throw new ApplicationException("Error reading from text file", ex);
            }
        }
    }
}
