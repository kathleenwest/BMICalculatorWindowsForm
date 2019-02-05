# BMICalculatorWindowsForm

Project Blog Article is Here: https://portfolio.katiegirl.net/2018/08/01/body-mass-index-bmi-calculator/

1. Objectives

The main assignment objectives are:

• To create a Windows Forms application.

• Use parameterized methods and methods with return value to establish communication between objects of classes.
From this point on, we will be considering separation of concerns as discussed earlier. More precisely, we will try to separate the
presentation of data from the logics that manipulate the data. We let the GUI- class (Form object), be responsible for presentation
of all data, and let other classes to serve the GUI by processing input data and producing the needed output data.


2. Description

Body Mass Index (BMI) is a measure of body fat and is commonly used within the health industry to determine whether the weight
of adult men and women is healthy. BMI is calculated in relation to one’s height using the following formulas:

BMI = weight in kg / (height * height in m2) (Metric Units)

BMI = 703.0 *·weight in lb / (height * height in inch2) (U.S. Units)


2.1 The above formulas are standard for adults not taking the age into consideration. The World Health Organization's (WHO)
has recommended a body weight based on BMI values for adults, as summarized in the following table. It is used for both
men and women, age 18 or older. For more information see: http://apps.who.int/bmi/index.jsp?introPage=intro_3.html.


2.2 The user should have the choice of selecting a metric or American unit type. For the metric option, the user should provide
the height and weight values in meters (m) or centimeters (cm) and kilograms (kg), respectively. For the American unit the
values can be given in feet (ft) or inches (in).
