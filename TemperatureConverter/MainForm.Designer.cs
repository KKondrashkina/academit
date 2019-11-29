namespace TemperatureConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UOM1 = new System.Windows.Forms.ComboBox();
            this.UOM2 = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.enterValue = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.uomFrom = new System.Windows.Forms.Label();
            this.uomTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UOM1
            // 
            this.UOM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UOM1.FormattingEnabled = true;
            this.UOM1.Items.AddRange(new object[] {
            "Celsius degrees",
            "Kelvins",
            "Fahrenheit degrees"});
            this.UOM1.Location = new System.Drawing.Point(175, 50);
            this.UOM1.Name = "UOM1";
            this.UOM1.Size = new System.Drawing.Size(120, 21);
            this.UOM1.TabIndex = 1;
            this.UOM1.SelectedIndexChanged += new System.EventHandler(this.UOM1_SelectedIndexChanged);
            // 
            // UOM2
            // 
            this.UOM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UOM2.FormattingEnabled = true;
            this.UOM2.Items.AddRange(new object[] {
            "Celsius degrees",
            "Kelvins",
            "Fahrenheit degrees"});
            this.UOM2.Location = new System.Drawing.Point(175, 100);
            this.UOM2.Name = "UOM2";
            this.UOM2.Size = new System.Drawing.Size(120, 21);
            this.UOM2.TabIndex = 2;
            this.UOM2.SelectedIndexChanged += new System.EventHandler(this.UOM2_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.Location = new System.Drawing.Point(25, 100);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 3;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(25, 50);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 4;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // enterValue
            // 
            this.enterValue.AutoSize = true;
            this.enterValue.Location = new System.Drawing.Point(25, 35);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(64, 13);
            this.enterValue.TabIndex = 5;
            this.enterValue.Text = "Enter value:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(25, 85);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result:";
            // 
            // uomFrom
            // 
            this.uomFrom.AutoSize = true;
            this.uomFrom.Location = new System.Drawing.Point(175, 35);
            this.uomFrom.Name = "uomFrom";
            this.uomFrom.Size = new System.Drawing.Size(107, 13);
            this.uomFrom.TabIndex = 9;
            this.uomFrom.Text = "Unit of measurement:";
            // 
            // uomTo
            // 
            this.uomTo.AutoSize = true;
            this.uomTo.Location = new System.Drawing.Point(175, 85);
            this.uomTo.Name = "uomTo";
            this.uomTo.Size = new System.Drawing.Size(107, 13);
            this.uomTo.TabIndex = 10;
            this.uomTo.Text = "Unit of measurement:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 162);
            this.Controls.Add(this.uomTo);
            this.Controls.Add(this.uomFrom);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.enterValue);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.UOM2);
            this.Controls.Add(this.UOM1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox UOM1;
        private System.Windows.Forms.ComboBox UOM2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label enterValue;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label uomFrom;
        private System.Windows.Forms.Label uomTo;
    }
}

