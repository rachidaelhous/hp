using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using Vehicle_Fleet_factory.BLL;

namespace Vehicle_Fleet_factory.UI
{
    public partial class VehicleForm : Form
    {
        //version 01
        List<Vehicle> listOfVehicles = new List<Vehicle>();
        //version 02 -DataCollection
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumVehicleType type in Enum.GetValues(typeof(EnumVehicleType)))
            {
                // Add each Enum value, displaying the enum name
                comboBoxType.Items.Add(type.ToString());
            }
            //comboBoxType.DataSource = Enum.GetValues(typeof(EnumVehicleType));
            comboBoxModel.DataSource = Enum.GetValues(typeof(EnumModel));
            //LoadSampleData();
        }

        private void buttonLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form

            using (LoginForm loginForm = new LoginForm())
            {
                DialogResult result = loginForm.ShowDialog(); // Open LoginForm and wait for it to close

                if (result == DialogResult.OK)
                {
                    // If login is successful, close the current form
                    this.Close();
                }
                else
                {
                    // If the user cancels, show the current form again
                    this.Show();
                }
            }
        }


        int index = -1;
        private void listBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxVehicle.SelectedIndex;
            if (index != -1 && index < DataCollection.ListOfVehicles.Count)
            {
                Vehicle selectedVehicle = DataCollection.ListOfVehicles[index];
                this.textBoxSerialNumber.Text = selectedVehicle.SerialNumber.ToString();
                this.textBoxMade.Text = selectedVehicle.Made;
                this.comboBoxModel.SelectedItem = selectedVehicle.Model;
                this.textBoxYear.Text = selectedVehicle.MadeDate.ToString();
                this.textBoxTripCounter.Text = selectedVehicle.TripCounter.ToString();
                this.comboBoxType.SelectedItem = selectedVehicle.VehicleType;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate and retrieve the vehicle type
                if (!Enum.TryParse(comboBoxType.SelectedItem?.ToString(), out EnumVehicleType vehicleType))
                {
                    MessageBox.Show("Please select a valid vehicle type.");
                    return;
                }

                // 2. Create the correct type of vehicle
                Vehicle currentVehicle = CreateVehicleByType(vehicleType);
                if (currentVehicle == null)
                {
                    MessageBox.Show("Unsupported vehicle type.");
                    return;
                }
                currentVehicle.VehicleType = vehicleType;

                // 3. Fill in the common properties
                currentVehicle.SerialNumber = textBoxSerialNumber.Text;
                currentVehicle.Made = textBoxMade.Text;

                if (!Enum.TryParse(comboBoxModel.Text, out EnumModel model))
                {
                    MessageBox.Show("Invalid vehicle model.");
                    return;
                }
                currentVehicle.Model = model;

                if (!int.TryParse(textBoxYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Invalid year (1900-" + (DateTime.Now.Year + 1) + ")");
                    return;
                }
                currentVehicle.MadeDate = new Date { Year = year };

                if (!double.TryParse(textBoxTripCounter.Text, out double tripCounter) || tripCounter < 0)
                {
                    MessageBox.Show("Invalid trip counter (must be ≥ 0)");
                    return;
                }
                currentVehicle.TripCounter = tripCounter;

                // 4. Add the vehicle to the collection
                DataCollection.AddVehicle(currentVehicle);
                MessageBox.Show("Vehicle added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Helper method to create the appropriate type of vehicle
        private Vehicle CreateVehicleByType(EnumVehicleType type)
        {
            switch (type)
            {
                case EnumVehicleType.GasolineVehicle:
                    return new GasolineVehicle();
                case EnumVehicleType.ElectricVehicle:
                    return new ElectricVehicle();
                case EnumVehicleType.HybridVehicle:
                    return new HybridVehicle();
                default:
                    return null;
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= DataCollection.ListOfVehicles.Count)
            {
                MessageBox.Show("Please select a valid vehicle.");
                return;
            }

            try
            {
                // Retrieve the existing vehicle
                Vehicle existingVehicle = DataCollection.ListOfVehicles[index];

                // Update common properties
                existingVehicle.SerialNumber = textBoxSerialNumber.Text;
                existingVehicle.Made = textBoxMade.Text;

                if (Enum.TryParse(comboBoxModel.Text, out EnumModel model))
                {
                    existingVehicle.Model = model;
                }
                else
                {
                    MessageBox.Show("Invalid model.");
                    return;
                }

                if (int.TryParse(textBoxYear.Text, out int year))
                {
                    existingVehicle.MadeDate = new Date { Year = year };
                }
                else
                {
                    MessageBox.Show("Invalid year.");
                    return;
                }

                if (double.TryParse(textBoxTripCounter.Text, out double tripCounter))
                {
                    existingVehicle.TripCounter = tripCounter;
                }
                else
                {
                    MessageBox.Show("Invalid trip counter.");
                    return;
                }

                // Update the vehicle in the collection
                DataCollection.UpdateVehicle(index, existingVehicle);
                MessageBox.Show("Vehicle updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating: {ex.Message}");
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            this.listBoxVehicle.Items.Clear();
            if (DataCollection.ListOfVehicles.Count > 0)
            {
                foreach (var vehicle in DataCollection.ListOfVehicles)
                {
                    this.listBoxVehicle.Items.Add(vehicle.ToString());
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchSerialNumber = textBoxSerialNumber.Text;
            Vehicle foundVehicle = DataCollection.SearchVehicle(searchSerialNumber);
            if (foundVehicle == null)
            {
                MessageBox.Show("Vehicle not found.");
                
            }
            else
            {
                MessageBox.Show($"Vehicle found: {foundVehicle.ToString()}");
                this.listBoxVehicle.Items.Clear();
                this.listBoxVehicle.Items.Add(foundVehicle.ToString());
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                DataCollection.RemoveVehicleByIndex(index);
                MessageBox.Show("Vehicle removed successfully.");
                listBoxVehicle.Items.RemoveAt(index);
                index = -1; // Reset index after deletion
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and reset selections
            this.textBoxSerialNumber.Text = string.Empty;
            this.textBoxMade.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;
            this.textBoxTripCounter.Text = string.Empty;
            this.comboBoxType.SelectedIndex = -1;
            this.comboBoxModel.SelectedIndex = -1;
            this.listBoxVehicle.SelectedIndex = -1;

            // Clear the list box
            this.listBoxVehicle.Items.Clear();
            // Reset the index
            index = -1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Exit Confirmation - Team01",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Exiting the application -- Team01.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancelled. You are still in the application.");
            }
        }

        public static String xmlFilePath = @"../../DAL/staff.xml";
        public static String textFilePath = @"../../DAL/staff2.txt";
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // Debug: Show where we're writing
                MessageBox.Show($"Attempting to write to: {FileManager.textFilePath}");

                FileManager.WriteToTextFile(DataCollection.ListOfVehicles);

                // Verify file was created
                if (File.Exists(FileManager.textFilePath))
                {
                    var info = new FileInfo(FileManager.textFilePath);
                    MessageBox.Show($"Success! File size: {info.Length} bytes");
                }
                else
                {
                    MessageBox.Show("Error: File was not created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Full error details:\n{ex.ToString()}");
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = FileManager.ReadFromTextFile();
                string message = string.Join(Environment.NewLine, lines);
                MessageBox.Show(message);
                // Clear the list box before loading new data
                listBoxVehicle.Items.Clear();
                // Load the vehicles into the list box
                foreach (var vehicle in DataCollection.ListOfVehicles)
                {
                    listBoxVehicle.Items.Add(vehicle.ToString());
                }
                // Set the selected index to the first item in the list box
                if (listBoxVehicle.Items.Count > 0)
                {
                    listBoxVehicle.SelectedIndex = 0;
                }
                MessageBox.Show("Data loaded from text file successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from text file: {ex.Message}");
            }
        }

        private void buttonWriteToXmlFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the directory for the XML file exists
                Directory.CreateDirectory(Path.GetDirectoryName(xmlFilePath));

                // Create a temporary file to avoid corruption if writing fails
                var tempPath = Path.GetTempFileName();

                // Create an XML writer with indentation for better readability
                using (var writer = XmlWriter.Create(tempPath, new XmlWriterSettings { Indent = true }))
                {
                    // Create an XmlSerializer that supports the Vehicle base type and its known derived types
                    var serializer = new XmlSerializer(typeof(List<Vehicle>),
                        new Type[] {
                    typeof(GasolineVehicle),
                    typeof(ElectricVehicle),
                    typeof(HybridVehicle)
                        });

                    // Serialize the current list of vehicles to the temporary file
                    serializer.Serialize(writer, DataCollection.ListOfVehicles);
                }

                // Replace the old XML file with the newly written one
                File.Delete(xmlFilePath);
                File.Move(tempPath, xmlFilePath);

                // Notify user of success
                MessageBox.Show("Vehicles saved to XML successfully!");
            }
            catch (Exception ex)
            {
                // Build a detailed error message in case of failure
                string errorDetails = $"Type: {ex.GetType().Name}\n";
                errorDetails += $"Message: {ex.Message}\n";

                if (ex.InnerException != null)
                {
                    errorDetails += $"Inner Exception: {ex.InnerException.GetType().Name}\n";
                    errorDetails += $"Inner Message: {ex.InnerException.Message}";
                }

                // Show the error message in a message box
                MessageBox.Show(errorDetails, "Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void buttonReadFromXmlFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the list of vehicles from XML using the FileManager helper method
                List<Vehicle> listFromFile = FileManager.ReadFromXmlFile();

                // Clear existing in-memory data and UI display
                DataCollection.ClearAllVehicles();
                this.listBoxVehicle.Items.Clear();

                // Add each deserialized vehicle back into the data collection and UI
                foreach (var vehicle in listFromFile)
                {
                    DataCollection.AddVehicle(vehicle);
                    this.listBoxVehicle.Items.Add(vehicle.ToString());
                }

                // Notify user of success
                MessageBox.Show($"Loaded {listFromFile.Count} vehicles from XML!");
            }
            catch (Exception ex)
            {
                // Show a simple error message if deserialization fails
                MessageBox.Show($"Failed to load vehicles: {ex.Message}\n\n" +
                                "Make sure all vehicle types are properly configured for XML serialization.");
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de véhicule valide.");
                return;
            }

            if (Enum.TryParse(comboBoxType.SelectedItem.ToString(), out EnumVehicleType vehicleType))
            {
                // Handle the selected vehicle type if needed  
            }
            else
            {
                MessageBox.Show("Type de véhicule invalide.");
            }
        }



        /*private void LoadSampleData()
            {
                // Sample data: EssenceVehicle
                EssenceVehicle essenceVehicle = new EssenceVehicle(
                    "ESS123456",     // Serial Number
                    "Toyota",        // Manufacturer
                    EnumModel.SUV, // Model
                    new Date(2020),  // Manufacture Year
                    5000.0,          // Trip Counter
                    EnumVehicleType.EssenceVehicle, // Vehicle Type
                    8.5              // Fuel Consumption Rate (8.5 liters per 100 km)
                );
                DataCollection.AddVehicle(essenceVehicle);

                // Sample data: ElectricVehicle
                ElectricVehicle electricVehicle = new ElectricVehicle(
                    "EV2020TES",     // Serial Number
                    "Tesla",         // Manufacturer
                    EnumModel.Automatic, // Model
                    new Date(2020),  // Manufacture Year
                    3000.0,          // Trip Counter
                    EnumVehicleType.ElectricVehicle, // Vehicle Type
                    0.18             // Battery Consumption Rate (0.18 kWh per km)
                );
                DataCollection.AddVehicle(electricVehicle);

                // Sample data: HybridVehicle
                HybridVehicle hybridVehicle = new HybridVehicle(
                    "HYB2022B",      // Serial Number
                    "Honda",         // Manufacturer
                    EnumModel.Undefined, // Model
                    new Date(2022),  // Manufacture Year
                    7000.0,          // Trip Counter
                    EnumVehicleType.HybridVehicle, // Vehicle Type
                    6.5,             // Fuel Consumption Rate (6.5 liters per 100 km)
                    0.12             // Battery Consumption Rate (0.12 kWh per km)
                );
                DataCollection.AddVehicle(hybridVehicle);

                // You can continue to add more sample data for other vehicle types as needed

                MessageBox.Show("Sample data loaded successfully!");

                // Display the sample data in the list box
                foreach (var vehicle in DataCollection.ListOfVehicles)
                {
                    this.listBoxVehicle.Items.Add(vehicle.ToString());
                }
                // Set the selected index to the first item in the list box
                if (this.listBoxVehicle.Items.Count > 0)
                {
                    this.listBoxVehicle.SelectedIndex = 0;
                }
            }*/


    }
}
