using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    /// <summary>
    /// class MainForm
    /// Description: This is the code behind the Windows form that acts as the 
    /// user interface, GUI, and visual part of the application. This class 
    /// processes user inputs, creates a business code class, and does any 
    /// functions, processing, and storing of variables on the business object.
    /// The class creates an object for the BMICalculator class where all the main
    /// operations and data reside. 
    /// </summary>
    public partial class MainForm : Form
    {
        // Create an instance of the BMICalculator class
        private BMICalculator bmiCalc = new BMICalculator();

        /// <summary>
        /// method MainForm()
        /// Description: The main entry point of the windows form application
        /// Initializes the windows form and the GUI
        /// Inputs: None
        /// Outputs: None
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        } // end of MainForm()

        #region Initialize
        /// <summary>
        /// Name: method InitializeGUI()
        /// Description: This method does setup on the GUI for
        /// the windows form and clears all output labels
        /// Sets the default measurement system to US
        /// Inputs: none
        /// Outputs: none
        /// </summary>
        private void InitializeGUI()
        {
            // Change the Title of the Windows Form Window
            this.Text = "The Body Mass Calculator";

            // Set Defaults for Measurement System
            // Radio Input Controls
            rdbUSUnitInput.Checked = true;
            rdbMetricUnitInput.Checked = false;
            lblHeight.Text = "Height (ft)";
            lblWeight.Text = "Weight (lbs)";

            // Clear User Input Text Boxes
            txtHeightInput.Text = string.Empty;
            txtWeightInput.Text = string.Empty;
            txtYourNameInput.Text = string.Empty;

            // Clear Display Output Labels
            lblBMIOutput.Text = string.Empty;
            lblWeightCategoryOutput.Text = string.Empty;
            lblBMIMessageOutput.Text = string.Empty;
            lblNormalWeightDisplay.Text = string.Empty;
        } // end of InitializeGUI()
        #endregion Initialize

        #region EventHandlers for User Input Events/Changes
        /// <summary>
        /// method btnCalculate_Click(object sender, EventArgs e)
        /// Description: Event handler for when the user presses
        /// the "Calculate" button. It will trigger methods to
        /// read and validate input then display results
        /// Inputs: object sender, EventArgs e
        /// Outputs: none
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Read and Validate Input
            bool ok = ReadInputBMI();

            // If the Input is OK Display the results
            if (ok)
            {
                DisplayResults(); // calculate and display results
            }
        } // end of btnCalculate_Click(object sender, EventArgs e)

        /// <summary>
        /// method rdbMetricUnitInput_CheckedChanged(object sender, EventArgs e)
        /// Description: Event handler for when the user changes the state of the
        /// radio button selection for the metric measurement. I will first check
        /// to see if the radio button is selected, then change the labels for the 
        /// height and weight to metric, and then set the object UnitType to Metric,
        /// and then hide the references to the labels and text boxes for US
        /// Inputs: (object sender, EventArgs e)
        /// Outputs: none
        /// </summary>
        private void rdbMetricUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            // If the Metric Radio Button is Selected
            if (rdbMetricUnitInput.Checked)
            {
                // Update the height and weight to metric
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";

                // Set the unit weight
                bmiCalc.SetUnit(UnitTypes.Metric);

                // Hide the label and text references to US system
                lblHeightFt.Visible = false;
                lblHeightIn.Visible = false;
                txtHeightInches.Visible = false;
            }
        } // end of rdbMetricUnitInput_CheckedChanged(object sender, EventArgs e)

        /// <summary>
        /// method rdbUSUnitInput_CheckedChanged(object sender, EventArgs e)
        /// Description: Event handler for when the user changes the state of the
        /// radio button selection for the US measurement. I will first check
        /// to see if the radio button is selected, then change the labels for the 
        /// height and weight to US, and then set the object UnitType to American,
        /// and then unhide the references to the labels and text boxes for US
        /// Inputs: (object sender, EventArgs e)
        /// Outputs: none
        /// </summary>
        private void rdbUSUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            // If the US Measurement radio button is selected
            if (rdbUSUnitInput.Checked)
            {
                // Change the labels to US measurements
                lblHeight.Text = "Height (ft)";
                lblWeight.Text = "Weight (lbs)";

                // Set the object to American measurement
                bmiCalc.SetUnit(UnitTypes.American);

                // Unhide the US measurement labels and inputs
                lblHeightFt.Visible = true;
                lblHeightIn.Visible = true;
                txtHeightInches.Visible = true;
            }
        } // end of rdbUSUnitInput_CheckedChanged(object sender, EventArgs e)
        #endregion EventHandlers for User Input Events/Changes

        #region ReadInputs
        /// <summary>
        /// method ReadHeight()
        /// Description: This method reads and trys to parse the user input
        /// boxes for the height measurement and then set the height on the
        /// object instance variable.
        /// Inputs: none
        /// Outputs: bool: true for successful validation and input reading
        /// </summary>

        private bool ReadHeight()
        {
            // local variables to store height input box values
            // after they have been parsed
            double height = 0;
            double inches = 0;
            double inchesConverted = 0;
            
            // try to trim and then parse the height input boxes
            bool ok = double.TryParse(txtHeightInput.Text.Trim(), out height);
            bool ok2 = double.TryParse(txtHeightInches.Text.Trim(), out inches);

            // Process the US Inches box first
            // Convert to feet to add to the height
            if(bmiCalc.GetUnit() == UnitTypes.American)
            {
                // Validate Parsing was Successful
                // Validate the inches are not negative
                if (ok2 && (inches >= 0)) // inches can be zero or greater than 12
                {
                    inchesConverted = inches / 12;
                }
                else // Error Condition - Show to User
                {
                    MessageBox.Show("Invalid Height value (inches)!", "Error!");
                    return false;
                }
            }

            // Process the main height box first
            // Validate the input parsed
            // Validate the height is > 0
            if (ok && (height > 0)) // height cannot be zero or negative
            {
                // Check to see if it the US unit
                if (bmiCalc.GetUnit() == UnitTypes.American)
                {
                    // Set the height to ft + inches converted to ft, convert to inches
                    bmiCalc.SetHeight((height + inchesConverted)* 12.00); //feet to inches
                }
                else // process the metric value of the height
                {
                    // Set the height to the metric value after conversion to m
                    bmiCalc.SetHeight(height/100.0); // cm  --> m
                }
            }
            else // Error Condition - Show to User
            {
                MessageBox.Show("Invalid Height value!","Error!");
                return false;
            }

            return ok;
        } // end of ReadHeight()

        /// <summary>
        /// method ReadInputBMI()
        /// Description: Method to read, validate, and process all the user
        /// input boxes for the windows form application including the
        /// measurement type selection, height, and weight. 
        /// Inputs: none
        /// Outputs: bool: true to indicate successful read and valid input
        /// </summary>
        private bool ReadInputBMI()
        {           
            // If User Selected Metric Measurements 
            if (rdbMetricUnitInput.Checked)
            {
                // Set the object type to Metric
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else // The user selected US measurements
            {
                // Set the object type to American
                bmiCalc.SetUnit(UnitTypes.American);
            }

            // Read, Validate, and Process User Name Input
            ReadName();

            // Read, Validate, and Process User Weight and Height Input
            // Return success only if both methods were successful
            return ReadHeight() && ReadWeight();
        } // end of ReadInputBMI()

        /// <summary>
        /// method ReadName()
        /// Description: Reads and Processes User Name Input from a text
        /// box. Trims the text. If empty, sets the name to "No name"
        /// Inputs: none
        /// Outputs: none
        /// </summary>
        private void ReadName()
        {
            // If the user input text box is empty or null
            if (string.IsNullOrEmpty(txtYourNameInput.Text.Trim()))
            {
                // Set to a default name
                bmiCalc.SetName("No name");
            }
            else // trim and set the name
            {
                // set the name on the object after trimming
                bmiCalc.SetName(txtYourNameInput.Text.Trim());
            }
        } // end of ReadName()

        /// <summary>
        /// method ReadWeight()
        /// Description: Reads, Validates, and Processes the user weight
        /// input from the text box after trimming, parsing, and then
        /// sets the value on the object field
        /// Inputs: none
        /// Outputs: bool: true if successful 
        /// </summary>
        private bool ReadWeight()
        {
            // local value to hold the parsed value
            double outValue = 0;

            // try and parse the weight input text box
            bool ok = double.TryParse(txtWeightInput.Text.Trim(), out outValue);

            // Make sure the input parsed and is > 0
            if (ok && (outValue > 0)) // weight cannot be zero or negative
            {
                // Set the weight value on the object field
                bmiCalc.SetWeight(outValue);
            }
            else // Alert user of error condition on user input box
            {
                MessageBox.Show("Invalid Weight value!", "Error!");
                return false;
            }

            return ok;
        } // end of ReadWeight()
        #endregion ReadInputs

        #region DisplayResults
        /// <summary>
        /// method DisplayResults()
        /// Description: Updates the form GUI to show the output results
        /// of the BMI calculation and assigned weight category. It also
        /// determines to ideal weight range for the user based on their height
        /// by calling a custom method. All the calculations are done on the
        /// BMICalculator class object not the main form. 
        /// Inputs: none
        /// Outputs: none
        /// </summary>

        private void DisplayResults()
        {
            // Calculate and Show the BMI result formated. 
            lblBMIOutput.Text = bmiCalc.CalculateBMI().ToString("f2");

            // Calculate and Show the BMI Weight Category 
            lblWeightCategoryOutput.Text = bmiCalc.BMIWeightCategory().ToString();

            // Show the standard BMI range message
            lblBMIMessageOutput.Text = "Normal BMI is between 18.50 and 24.9";

            // Personalize the Result Group for the User Name
            grpResults.Text = "Results for " + bmiCalc.GetName();

            // If the user selected US Measurement
            // Calculate the ideal weight and display in US units
            if(bmiCalc.GetUnit() == UnitTypes.American)
            {
                lblNormalWeightDisplay.Text = "Normal weight should be between " + bmiCalc.CalculateWeight(18.50).ToString("f2") + " and " + bmiCalc.CalculateWeight(24.9).ToString("f2") + " lbs";
            }
            else // Calculate and display in Metric units
            {
                lblNormalWeightDisplay.Text = "Normal weight should be between " + bmiCalc.CalculateWeight(18.50).ToString("f2") + " and " + bmiCalc.CalculateWeight(24.9).ToString("f2") + " kg";
            }
        } // end of DisplayResults()
        #endregion DisplayResults
    } // end of class partial class MainForm : Form
} // end of namespace
