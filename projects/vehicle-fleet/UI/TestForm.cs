using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using Vehicle_Fleet_factory.BLL;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Vehicle_Fleet_factory.UI
{
    public partial class TestForm : Form
    {
        List <Vehicle> vehicles = new List<Vehicle>();// List to hold vehicles

        private int index = -1;// Index for tracking the selected vehicle
        public TestForm()
        {
            InitializeComponent();// Initialize components (UI elements)
            LoadAvailableVehicles();// Load available vehicles in the list
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // Initialize comboBoxType with enum values
            comboBoxType.DataSource = Enum.GetValues(typeof(EnumVehicleType));

            // Clear and load vehicles into comboBoxSelection
            comboBoxSelection.Items.Clear();
            foreach (var vehicle in DataCollection.GetListVehicles())
            {
                comboBoxSelection.Items.Add(vehicle);
            }

            // Select the first vehicle if available
            if (comboBoxSelection.Items.Count > 0)
            {
                comboBoxSelection.SelectedIndex = 0;
            }
        }

        // Load available vehicles into the ListBox for selection
        private void LoadAvailableVehicles()
        {
            listBoxVehicles.Items.Clear();

            foreach (var vehicle in DataCollection.ListOfVehicles)
            {
                listBoxVehicles.Items.Add(FormatVehicleDisplay(vehicle));
            }
        }

        // Format the vehicle information for display
        private string FormatVehicleDisplay(Vehicle vehicle)
        {
            return $"{vehicle.SerialNumber} - {vehicle.VehicleType}";
        }

        private void buttonRunTest_Click(object sender, EventArgs e)
        {
            var selectedVehicle = GetSelectedVehicle();
            if (selectedVehicle == null) return;

            RunVehicleTest(selectedVehicle);

            //Vehicle selectedVehicle = (Vehicle)comboBoxVehicles.SelectedItem;

        }

        // Retrieve the selected vehicle
        private Vehicle GetSelectedVehicle()
        {
            if (listBoxVehicles.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a vehicle.");
                return null;
            }
            return DataCollection.ListOfVehicles[listBoxVehicles.SelectedIndex];

        }


        // Run the test for the selected vehicle
        private void RunVehicleTest(Vehicle vehicle)
        {
            try
            {
                double efficiency = vehicle.CalculateMileageEfficiency();
                ShowTestResults(vehicle.SerialNumber, efficiency);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur pendant le test : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display test results in a message box
        private void ShowTestResults(string serialNumber, double efficiency)
        {
            if (int.TryParse(textBoxDay.Text, out int day) &&
                int.TryParse(textBoxMonth.Text, out int month) &&
                int.TryParse(textBoxYear.Text, out int year))
            {
                try
                {
                    Date testDate = new Date(year, month, day);
                    MessageBox.Show(
                        $"Test Date: {testDate:yyyy-MM-dd}\n" +
                        $"Vehicle: {serialNumber}\n" +
                        $"Efficiency: {efficiency:F2}",
                        "Results"
                    );
                }
                catch
                {
                    MessageBox.Show("Invalid test date!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid test date.");
            }
        }
        
        // Retour au LoginForm
        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMakeTrip_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Vehicle selectedVehicle = DataCollection.ListOfVehicles[index];
                double tripDistance = double.Parse(textBoxTripCounter.Text);
                selectedVehicle.MakeTrip();
                MessageBox.Show($"Trip made successfully! New trip counter: {selectedVehicle.TripCounter}");
                this.textBoxMakeTrip.Text = selectedVehicle.TripCounter.ToString();
            }
            else
            {
                MessageBox.Show("Please select a vehicle to make a trip.");
            }
        }

        private void buttonMakeTripDouble_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Vehicle selectedVehicle = DataCollection.ListOfVehicles[index];
                double tripDistance = double.Parse(textBoxTripCounter.Text);
                selectedVehicle.MakeTrip(tripDistance);
                MessageBox.Show($"Trip made successfully! New trip counter: {selectedVehicle.TripCounter}");
                this.textBoxMakeTripDouble.Text = selectedVehicle.TripCounter.ToString();
            }
            else
            {
                MessageBox.Show("Please select a vehicle to make a trip.");
            }
        }


        private void buttonCalculateMileageEfficiency_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Vehicle selectedVehicle = DataCollection.ListOfVehicles[index];

                if (selectedVehicle is GasolineVehicle gasolineVehicle)
                { 
                    double.TryParse(this.textBoxTripCounter.Text, out double tripCounter);
                    double.TryParse(this.textBoxFuelConsumptionRate.Text, out double fuelConsumptionRate);

                    gasolineVehicle.TripCounter = tripCounter;
                    gasolineVehicle.FuelConsumptionRate = fuelConsumptionRate;

                    double mileageEfficiency = gasolineVehicle.CalculateMileageEfficiency();
                    this.textBoxCalculateMileageEfficiency.Text = mileageEfficiency.ToString();
                }
                else if (selectedVehicle is ElectricVehicle electricVehicle)
                {
                    double.TryParse(this.textBoxTripCounter.Text, out double tripCounter);
                    double.TryParse(this.textBoxBatteryConsumptionRate.Text, out double batteryConsumptionRate);

                    electricVehicle.TripCounter = tripCounter;
                    electricVehicle.BatteryConsumptionRate = batteryConsumptionRate;

                    double mileageEfficiency = electricVehicle.CalculateMileageEfficiency();
                    this.textBoxCalculateMileageEfficiency.Text = mileageEfficiency.ToString();
                }
                else if (selectedVehicle is HybridVehicle hybridVehicle)
                {
                    double.TryParse(this.textBoxTripCounter.Text, out double tripCounter);
                    double.TryParse(this.textBoxFuelConsumptionRate.Text, out double fuelConsumptionRate);
                    double.TryParse(this.textBoxBatteryConsumptionRate.Text, out double batteryConsumptionRate);

                    hybridVehicle.TripCounter = tripCounter;
                    hybridVehicle.FuelConsumptionRate = fuelConsumptionRate;
                    hybridVehicle.BatteryConsumptionRate = batteryConsumptionRate;

                    double mileageEfficiency = hybridVehicle.CalculateMileageEfficiency();
                    this.textBoxCalculateMileageEfficiency.Text = mileageEfficiency.ToString();
                }

                MessageBox.Show($"Mileage Efficiency: {this.textBoxCalculateMileageEfficiency.Text}");
            }
            else
            {
                MessageBox.Show("Please select a vehicle to calculate mileage efficiency.");
            }
        }

        
        private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVehicles.SelectedIndex < 0 || listBoxVehicles.SelectedIndex >= DataCollection.ListOfVehicles.Count)
            {
                MessageBox.Show("Please select a valid vehicle.");
                return;
            }

            index = listBoxVehicles.SelectedIndex;
            Vehicle selectedVehicle = DataCollection.ListOfVehicles[index];

            // Mettre à jour les champs communs
            this.textBoxMakeTrip.Text = selectedVehicle.TripCounter.ToString();
            this.textBoxMakeTripDouble.Text = selectedVehicle.TripCounter.ToString();
            this.textBoxCalculateMileageEfficiency.Text = selectedVehicle.CalculateMileageEfficiency().ToString("F2");
            this.textBoxTripCounter.Text = selectedVehicle.TripCounter.ToString();
            this.textBoxMonth.Text = selectedVehicle.MadeDate.Month.ToString();
            this.textBoxYear.Text = selectedVehicle.MadeDate.Year.ToString();
            this.textBoxDay.Text = selectedVehicle.MadeDate.Day.ToString();
            // Update the type combo box to match the selected vehicle
            comboBoxType.SelectedItem = selectedVehicle.VehicleType;
            // Réinitialiser tous les champs spécifiques
            this.textBoxFuelConsumptionRate.Text = string.Empty;
            this.textBoxBatteryConsumptionRate.Text = string.Empty;
            this.textBoxFuelConsumptionRateHybrid.Text = string.Empty;
            this.textBoxBatteryConsumtionRateHybrid.Text = string.Empty;

            // Mettre à jour selon le type de véhicule
            switch (selectedVehicle)
            {
                case GasolineVehicle gasolineVehicle:
                    this.textBoxFuelConsumptionRate.Text = gasolineVehicle.FuelConsumptionRate.ToString();
                    break;

                case ElectricVehicle electricVehicle:
                    this.textBoxBatteryConsumptionRate.Text = electricVehicle.BatteryConsumptionRate.ToString();
                    break;

                case HybridVehicle hybridVehicle:
                    this.textBoxFuelConsumptionRateHybrid.Text = hybridVehicle.FuelConsumptionRate.ToString();
                    this.textBoxBatteryConsumtionRateHybrid.Text = hybridVehicle.BatteryConsumptionRate.ToString();
                    break;
            }

            // Display the test results
            double efficiency = selectedVehicle.CalculateMileageEfficiency();  // This assumes this method exists in your Vehicle class
            ShowTestResults(selectedVehicle.SerialNumber, efficiency);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null) return;


            EnumVehicleType selectedType = (EnumVehicleType)comboBoxType.SelectedItem;

            // Exemple d'utilisation (à adapter selon vos besoins)
            MessageBox.Show($"Type sélectionné : {selectedType}");

            switch (selectedType)
            {
                case EnumVehicleType.GasolineVehicle:
                    groupBoxElectricVehicle.Visible = false;
                    groupBoxHybridVehicle.Visible = false;
                    groupBoxGasolineVehicle.Visible = true;
                    break;
                case EnumVehicleType.ElectricVehicle:
                    groupBoxElectricVehicle.Visible = true;
                    groupBoxHybridVehicle.Visible = false;
                    groupBoxGasolineVehicle.Visible = false;
                    break;
                case EnumVehicleType.HybridVehicle:
                    groupBoxElectricVehicle.Visible = false;
                    groupBoxHybridVehicle.Visible = true;
                    groupBoxGasolineVehicle.Visible = false;
                    break;
                default:
                    groupBoxElectricVehicle.Visible = true;
                    groupBoxHybridVehicle.Visible = true;
                    groupBoxGasolineVehicle.Visible = true;
                    return;
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxMakeTrip.Text = string.Empty;
            textBoxMakeTripDouble.Text = string.Empty;
            textBoxCalculateMileageEfficiency.Text = string.Empty;
            textBoxTripCounter.Text = string.Empty;
            textBoxFuelConsumptionRate.Text = string.Empty;
            textBoxBatteryConsumptionRate.Text = string.Empty;
            textBoxFuelConsumptionRateHybrid.Text = string.Empty;
            textBoxBatteryConsumtionRateHybrid.Text = string.Empty;
            textBoxMonth.Text = string.Empty;
            textBoxYear.Text = string.Empty;
            textBoxDay.Text = string.Empty;
            DataCollection.ListOfVehicles.Clear();
            index = -1;
        }

        
       
        private void buttonLoadResulat_Click(object sender, EventArgs e)
        {
            this.listBoxVehicles.Items.Clear();
            if (DataCollection.ListOfVehicles.Count > 0)
            {
                foreach (var vehicle in DataCollection.ListOfVehicles)
                {
                    this.listBoxVehicles.Items.Add(vehicle.ToString());
                }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cache le formulaire actuel

            using (LoginForm loginForm = new LoginForm())
            {
                DialogResult result = loginForm.ShowDialog(); // Ouvre LoginForm et attend

                if (result == DialogResult.OK)
                {
                    // Si la connexion réussit, ferme le formulaire actuel
                    this.Close();
                }
                else
                {
                    // Si l'utilisateur annule, réaffiche le formulaire actuel
                    this.Show();
                }
            }
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

        private void groupBoxGasolineVehicle_Enter(object sender, EventArgs e)
        {

        }

        private void labelFuelConsumptionRate_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonReadXml_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the list of vehicles from XML using the FileManager helper method
                List<Vehicle> listFromFile = FileManager.ReadFromXmlFile();

                // Clear existing in-memory data and UI display
                DataCollection.ClearAllVehicles();
                this.listBoxVehicles.Items.Clear();

                // Add each deserialized vehicle back into the data collection and UI
                foreach (var vehicle in listFromFile)
                {
                    DataCollection.AddVehicle(vehicle);
                    this.listBoxVehicles.Items.Add(vehicle.ToString());
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
        
        // Path to the XML file
        public static String xmlFilePath = @"../../DAL/vehiculeFleet.xml";
        public static String textFilePath = @"../../DAL/vehiculeFleet.txt";
        private void button1WriteXml_Click(object sender, EventArgs e)
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
    }
  }
// Compare this snippet from Vehicle-Fleet factory/UI/TestForm.Designer.cs:

