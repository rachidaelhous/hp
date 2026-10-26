using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;  // This allows access to configuration settings
using System.Windows.Forms;  // This is for creating the UI components
using Vehicle_Fleet_factory.BLL;  // Importing the business logic for vehicle management

namespace Vehicle_Fleet_factory.UI
{
    public partial class LoginForm : Form
    {
        // Constructor to initialize the form
        public LoginForm()
        {
            InitializeComponent();
        }

        // This event handler runs when the form is loaded
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Add user roles to the ComboBox (drop-down menu)
            comboBoxUsermode.Items.Add(EnumUserMode.Manager.ToString());  // Adding Manager role
            comboBoxUsermode.Items.Add(EnumUserMode.Technician.ToString());  // Adding Technician role
            comboBoxUsermode.SelectedIndex = 0;  // Default option is set to Manager
        }

        // This event handler runs when the login button is clicked
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Get the manager and technician passwords from the configuration file (app.config)
            string managerPassword = ConfigurationManager.AppSettings["ManagerPassword"];
            string technicianPassword = ConfigurationManager.AppSettings["TechnicianPassword"];

            // Get the selected user role and entered username/password from the form
            string selectedRole = comboBoxUsermode.SelectedItem.ToString();
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            // Check if the username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;  // Stop further execution if credentials are missing
            }

            // If the selected role is Manager, check if the password matches
            if (selectedRole == EnumUserMode.Manager.ToString())
            {
                if (password == managerPassword)
                {
                    // If correct, show the VehicleForm and close this form
                    VehicleForm vehicleForm = new VehicleForm();
                    this.Hide();  // Hide the login form
                    vehicleForm.ShowDialog();  // Show the vehicle form as a modal dialog
                    this.Close();  // Close the login form once the vehicle form is done
                }
                else
                {
                    MessageBox.Show("Incorrect password for Manager");
                }
            }
            // If the selected role is Technician, check if the password matches
            else if (selectedRole == EnumUserMode.Technician.ToString())
            {
                if (password == technicianPassword)
                {
                    // If correct, show the TestForm and close this form
                    TestForm testForm = new TestForm();
                    this.Hide();  // Hide the login form
                    testForm.ShowDialog();  // Show the test form as a modal dialog
                    this.Close();  // Close the login form once the test form is done
                }
                else
                {
                    MessageBox.Show("Incorrect password for Technician");
                }
            }
            else
            {
                // If the user role is not valid
                MessageBox.Show("Invalid user role");
            }
        }

        // This event handler runs when the reset button is clicked
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Clear the username and password fields and reset the role to the default
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            comboBoxUsermode.SelectedIndex = 0;  // Default to Manager role
        }

        // This event handler runs when the exit button is clicked
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog before exiting the application
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation - Team01",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If the user confirms, exit the application
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Exiting the application -- Team01.");
                Application.Exit();
            }
            else
            {
                // If the user cancels, show a message that they're still in the app
                MessageBox.Show("Exit cancelled. You are still in the application.");
            }
        }
    }
}
