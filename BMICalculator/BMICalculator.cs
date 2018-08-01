using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    /// <summary>
    /// class BMICalculator
    /// Description: The business logic and object that holds data, does
    /// operations, and outputs for the user GUI
    /// </summary>
    class BMICalculator
    {
        // instance variables for the class
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        #region Getter Methods

        /// <summary>
        /// method GetName()
        /// Description: Gets the user name for the object
        /// Inputs: none
        /// Outputs: string of the user name
        /// </summary>
        public string GetName()
        {
            return name;
        } // end of GetName()

        /// <summary>
        /// method GetHeight()
        /// Description: Gets the height of the user from the object
        /// which is returned as a double value
        /// Inputs: none
        /// Outputs: double number value of user's height
        /// </summary>
        public double GetHeight()
        {
            return height;
        } // end of GetHeight()

        /// <summary>
        /// method GetWeight()
        /// Description: Gets the user weight stored as a double on
        /// the object instance field
        /// Inputs: none
        /// Outputs: double weight of user 
        /// </summary>
        public double GetWeight()
        {
            return weight;
        } // end of GetWeight()

        /// <summary>
        /// method GetUnit()
        /// Description: This method gets the UnitType on the object 
        /// which is an enum either American or Metric for the measurement
        /// system of the program
        /// Inputs: none
        /// Outputs: enum UnitType 
        /// </summary>
        public UnitTypes GetUnit()
        {
            return unit;
        } // end of GetUnit()

        #endregion region Getter Methods

        #region Setter Methods

        /// <summary>
        /// method SetName(string value)
        /// Description: Received the string value of the user name
        /// and sets the object's instance field to that value
        /// Inputs: string of user name
        /// Outputs: none
        /// </summary>
        public void SetName(string value)
        {
            // Before setting the name, make sure it is valid
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        } // end of SetName(string value)

        /// <summary>
        /// method SetHeight(double value)
        /// Description: Sets the user height on the
        /// object field as a double
        /// Inputs: the user input height as a double number
        /// Outputs: none
        /// </summary>
        public void SetHeight(double value)
        {
            if (value > 0)
            {
                height = value;
            }
        } // end of SetHeight(double value)

        /// <summary>
        /// method SetWeight(double value)
        /// Description: This method sets the user input weight on
        /// the object instance field
        /// Inputs: double user input value of weight
        /// Outputs: none
        /// </summary>
        public void SetWeight(double value)
        {
            // Weight must be greater than zero
            if (value > 0)
            {
                weight = value;
            }
        } // end of SetWeight(double value)

        /// <summary>
        /// method SetUnit(UnitTypes value)
        /// Description: This sets the UnitType on the object field
        /// to either American or Metric for the measurement system
        /// of the program
        /// Inputs: UnitTypes
        /// Outputs:none
        /// </summary>
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        #endregion Setter Methods

        /// <summary>
        /// method BMIWeightCategory()
        /// Description: This message calculates the BMI and from this number
        /// determines which BMI weight category and returns that message
        /// Inputs:none
        /// Outputs: string message with the BMI weight category
        /// </summary>
        public string BMIWeightCategory()
        {
            // Calculate the BMI
            double bmi = CalculateBMI();

            // Based on the BMI Range
            // Return Category
            if(bmi > 40)
            {
                return "Overweight (Obesity class III)";
            }
            else if (35.0 <= bmi)
            {
                return "Overweight (Obesity class II)";
            }
            else if (30.0 <= bmi)
            {
                return "Overweight (Obesity class I)";
            }
            else if (25.0 <= bmi)
            {
                return "Overweight (Pre-obesity)";
            }
            else if (18.5 <= bmi)
            {
                return "Normal weight";
            }
            else 
            {
                return "Underweight";
            }
        } // end of BMIWeightCategory()

        /// <summary>
        /// method CalculateBMI()
        /// Description: This method calculates and returns the BMI
        /// of the user based on the height, weight, and measurement 
        /// selection
        /// Inputs: none
        /// Outputs: double of the user calculated BMI
        /// </summary>
        public double CalculateBMI()
        {
            double bmi = 0.0;

            // Calculate BMI for US System
            if (unit == UnitTypes.American)
            {
                bmi = 703.0 * weight / (height * height);
            }
            else // Calculate BMI for Metric System
            {
                bmi = weight / (height * height);
            }

            return bmi;
        } // end of CalculateBMI()

        /// <summary>
        /// method CalculateWeight(double bmi)
        /// Description: Based on an input BMI, calculate the weight value
        /// based on the user height stored on the object and return to caller. 
        /// Inputs: double bmi
        /// Outputs: double weight
        /// </summary>
        public double CalculateWeight(double bmi)
        {
            double weight = 0.0;

            // If Using US System, Calculate with Different Formular
            if (unit == UnitTypes.American)
            {
                weight = bmi * (this.GetHeight() * this.GetHeight()) / 703.0;
            }
            else // User is using the metric system
            {
                weight = bmi * (this.GetHeight() * this.GetHeight());
            }

            return weight;
        } // end of CalculateWeight(double bmi)

    } // end of class BMICalculator
} // end of namespace
