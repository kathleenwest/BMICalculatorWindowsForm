namespace BMICalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYourName = new System.Windows.Forms.Label();
            this.txtYourNameInput = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rdbUSUnitInput = new System.Windows.Forms.RadioButton();
            this.rdbMetricUnitInput = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblNormalWeightDisplay = new System.Windows.Forms.Label();
            this.lblBMIMessageOutput = new System.Windows.Forms.Label();
            this.lblWeightCategoryOutput = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblBMIOutput = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.lblHeightFt = new System.Windows.Forms.Label();
            this.txtHeightInches = new System.Windows.Forms.TextBox();
            this.lblHeightIn = new System.Windows.Forms.Label();
            this.grpUnit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(90, 59);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(190, 37);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Your Name:";
            // 
            // txtYourNameInput
            // 
            this.txtYourNameInput.Location = new System.Drawing.Point(298, 52);
            this.txtYourNameInput.Name = "txtYourNameInput";
            this.txtYourNameInput.Size = new System.Drawing.Size(644, 44);
            this.txtYourNameInput.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(26, 180);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(118, 37);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Location = new System.Drawing.Point(231, 173);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(80, 44);
            this.txtHeightInput.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(26, 258);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(126, 37);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight:";
            // 
            // txtWeightInput
            // 
            this.txtWeightInput.Location = new System.Drawing.Point(231, 251);
            this.txtWeightInput.Name = "txtWeightInput";
            this.txtWeightInput.Size = new System.Drawing.Size(143, 44);
            this.txtWeightInput.TabIndex = 6;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rdbUSUnitInput);
            this.grpUnit.Controls.Add(this.rdbMetricUnitInput);
            this.grpUnit.Location = new System.Drawing.Point(532, 127);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(410, 190);
            this.grpUnit.TabIndex = 2;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rdbUSUnitInput
            // 
            this.rdbUSUnitInput.AutoSize = true;
            this.rdbUSUnitInput.Checked = true;
            this.rdbUSUnitInput.Location = new System.Drawing.Point(24, 128);
            this.rdbUSUnitInput.Name = "rdbUSUnitInput";
            this.rdbUSUnitInput.Size = new System.Drawing.Size(315, 41);
            this.rdbUSUnitInput.TabIndex = 3;
            this.rdbUSUnitInput.TabStop = true;
            this.rdbUSUnitInput.Text = "US Unit (foot, lbs)";
            this.rdbUSUnitInput.UseVisualStyleBackColor = true;
            this.rdbUSUnitInput.CheckedChanged += new System.EventHandler(this.rdbUSUnitInput_CheckedChanged);
            // 
            // rdbMetricUnitInput
            // 
            this.rdbMetricUnitInput.AutoSize = true;
            this.rdbMetricUnitInput.Location = new System.Drawing.Point(24, 53);
            this.rdbMetricUnitInput.Name = "rdbMetricUnitInput";
            this.rdbMetricUnitInput.Size = new System.Drawing.Size(330, 41);
            this.rdbMetricUnitInput.TabIndex = 2;
            this.rdbMetricUnitInput.TabStop = true;
            this.rdbMetricUnitInput.Text = "Metric Unit (kg cm)";
            this.rdbMetricUnitInput.UseVisualStyleBackColor = true;
            this.rdbMetricUnitInput.CheckedChanged += new System.EventHandler(this.rdbMetricUnitInput_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(350, 342);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(265, 86);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblNormalWeightDisplay);
            this.grpResults.Controls.Add(this.lblBMIMessageOutput);
            this.grpResults.Controls.Add(this.lblWeightCategoryOutput);
            this.grpResults.Controls.Add(this.lblWeightCategory);
            this.grpResults.Controls.Add(this.lblBMIOutput);
            this.grpResults.Controls.Add(this.lblYourBMI);
            this.grpResults.Location = new System.Drawing.Point(56, 452);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(931, 377);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for";
            // 
            // lblNormalWeightDisplay
            // 
            this.lblNormalWeightDisplay.AutoSize = true;
            this.lblNormalWeightDisplay.ForeColor = System.Drawing.Color.Green;
            this.lblNormalWeightDisplay.Location = new System.Drawing.Point(28, 306);
            this.lblNormalWeightDisplay.Name = "lblNormalWeightDisplay";
            this.lblNormalWeightDisplay.Size = new System.Drawing.Size(415, 37);
            this.lblNormalWeightDisplay.TabIndex = 5;
            this.lblNormalWeightDisplay.Text = "Your Ideal Weight Range is:";
            // 
            // lblBMIMessageOutput
            // 
            this.lblBMIMessageOutput.AutoSize = true;
            this.lblBMIMessageOutput.Location = new System.Drawing.Point(287, 219);
            this.lblBMIMessageOutput.Name = "lblBMIMessageOutput";
            this.lblBMIMessageOutput.Size = new System.Drawing.Size(569, 37);
            this.lblBMIMessageOutput.TabIndex = 4;
            this.lblBMIMessageOutput.Text = "Normal BMI is between 18.50 and 24.9";
            // 
            // lblWeightCategoryOutput
            // 
            this.lblWeightCategoryOutput.AutoSize = true;
            this.lblWeightCategoryOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategoryOutput.Location = new System.Drawing.Point(294, 153);
            this.lblWeightCategoryOutput.Name = "lblWeightCategoryOutput";
            this.lblWeightCategoryOutput.Size = new System.Drawing.Size(377, 39);
            this.lblWeightCategoryOutput.TabIndex = 3;
            this.lblWeightCategoryOutput.Text = "Your Weight Category Is:";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.Location = new System.Drawing.Point(16, 155);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(264, 37);
            this.lblWeightCategory.TabIndex = 2;
            this.lblWeightCategory.Text = "Weight Category:";
            // 
            // lblBMIOutput
            // 
            this.lblBMIOutput.AutoSize = true;
            this.lblBMIOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIOutput.Location = new System.Drawing.Point(294, 91);
            this.lblBMIOutput.Name = "lblBMIOutput";
            this.lblBMIOutput.Size = new System.Drawing.Size(180, 39);
            this.lblBMIOutput.TabIndex = 1;
            this.lblBMIOutput.Text = "BMI Output";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Location = new System.Drawing.Point(121, 93);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(159, 37);
            this.lblYourBMI.TabIndex = 0;
            this.lblYourBMI.Text = "Your BMI:";
            // 
            // lblHeightFt
            // 
            this.lblHeightFt.AutoSize = true;
            this.lblHeightFt.Location = new System.Drawing.Point(327, 180);
            this.lblHeightFt.Name = "lblHeightFt";
            this.lblHeightFt.Size = new System.Drawing.Size(35, 37);
            this.lblHeightFt.TabIndex = 9;
            this.lblHeightFt.Text = "ft";
            // 
            // txtHeightInches
            // 
            this.txtHeightInches.Location = new System.Drawing.Point(368, 173);
            this.txtHeightInches.Name = "txtHeightInches";
            this.txtHeightInches.Size = new System.Drawing.Size(76, 44);
            this.txtHeightInches.TabIndex = 5;
            // 
            // lblHeightIn
            // 
            this.lblHeightIn.AutoSize = true;
            this.lblHeightIn.Location = new System.Drawing.Point(462, 176);
            this.lblHeightIn.Name = "lblHeightIn";
            this.lblHeightIn.Size = new System.Drawing.Size(42, 37);
            this.lblHeightIn.TabIndex = 11;
            this.lblHeightIn.Text = "in";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1027, 848);
            this.Controls.Add(this.lblHeightIn);
            this.Controls.Add(this.txtHeightInches);
            this.Controls.Add(this.lblHeightFt);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.txtWeightInput);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeightInput);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtYourNameInput);
            this.Controls.Add(this.lblYourName);
            this.Name = "MainForm";
            this.Text = "Body Mass Index";
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.TextBox txtYourNameInput;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rdbUSUnitInput;
        private System.Windows.Forms.RadioButton rdbMetricUnitInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblBMIMessageOutput;
        private System.Windows.Forms.Label lblWeightCategoryOutput;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblBMIOutput;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.Label lblHeightFt;
        private System.Windows.Forms.TextBox txtHeightInches;
        private System.Windows.Forms.Label lblHeightIn;
        private System.Windows.Forms.Label lblNormalWeightDisplay;
    }
}

