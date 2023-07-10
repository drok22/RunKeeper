namespace RunKeeper.Views
{
    partial class RunEditView
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
            this.components = new System.ComponentModel.Container();
            this.runDateLabel = new System.Windows.Forms.Label();
            this.runDistanceLabel = new System.Windows.Forms.Label();
            this.runDurationLabel = new System.Windows.Forms.Label();
            this.runPaceLabel = new System.Windows.Forms.Label();
            this.runNotesLabel = new System.Windows.Forms.Label();
            this.runDateTextBox = new System.Windows.Forms.TextBox();
            this.runModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runDistanceTextBox = new System.Windows.Forms.TextBox();
            this.runDurationTextBox = new System.Windows.Forms.TextBox();
            this.runPaceTextBox = new System.Windows.Forms.TextBox();
            this.runNotesTextBox = new System.Windows.Forms.TextBox();
            this.runTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.elevationGainTextBox = new System.Windows.Forms.TextBox();
            this.elevationGainLabel = new System.Windows.Forms.Label();
            this.shoesUsedTextBox = new System.Windows.Forms.TextBox();
            this.shoesUsedLabel = new System.Windows.Forms.Label();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.avgHRTextBox = new System.Windows.Forms.TextBox();
            this.avgHRLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runDateLabel
            // 
            this.runDateLabel.AutoSize = true;
            this.runDateLabel.Location = new System.Drawing.Point(74, 21);
            this.runDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runDateLabel.Name = "runDateLabel";
            this.runDateLabel.Size = new System.Drawing.Size(41, 20);
            this.runDateLabel.TabIndex = 2;
            this.runDateLabel.Text = "Date";
            // 
            // runDistanceLabel
            // 
            this.runDistanceLabel.AutoSize = true;
            this.runDistanceLabel.Location = new System.Drawing.Point(49, 70);
            this.runDistanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runDistanceLabel.Name = "runDistanceLabel";
            this.runDistanceLabel.Size = new System.Drawing.Size(66, 20);
            this.runDistanceLabel.TabIndex = 3;
            this.runDistanceLabel.Text = "Distance";
            // 
            // runDurationLabel
            // 
            this.runDurationLabel.AutoSize = true;
            this.runDurationLabel.Location = new System.Drawing.Point(48, 119);
            this.runDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runDurationLabel.Name = "runDurationLabel";
            this.runDurationLabel.Size = new System.Drawing.Size(67, 20);
            this.runDurationLabel.TabIndex = 4;
            this.runDurationLabel.Text = "Duration";
            // 
            // runPaceLabel
            // 
            this.runPaceLabel.AutoSize = true;
            this.runPaceLabel.Location = new System.Drawing.Point(76, 168);
            this.runPaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runPaceLabel.Name = "runPaceLabel";
            this.runPaceLabel.Size = new System.Drawing.Size(39, 20);
            this.runPaceLabel.TabIndex = 5;
            this.runPaceLabel.Text = "Pace";
            // 
            // runNotesLabel
            // 
            this.runNotesLabel.AutoSize = true;
            this.runNotesLabel.Location = new System.Drawing.Point(67, 462);
            this.runNotesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runNotesLabel.Name = "runNotesLabel";
            this.runNotesLabel.Size = new System.Drawing.Size(48, 20);
            this.runNotesLabel.TabIndex = 6;
            this.runNotesLabel.Text = "Notes";
            // 
            // runDateTextBox
            // 
            this.runDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runModelBindingSource, "RunDate", true));
            this.runDateTextBox.Location = new System.Drawing.Point(119, 18);
            this.runDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.runDateTextBox.Name = "runDateTextBox";
            this.runDateTextBox.Size = new System.Drawing.Size(121, 27);
            this.runDateTextBox.TabIndex = 8;
            // 
            // runModelBindingSource
            // 
            this.runModelBindingSource.DataSource = typeof(RunKeeper.Classes.RunModel);
            // 
            // runDistanceTextBox
            // 
            this.runDistanceTextBox.Location = new System.Drawing.Point(119, 67);
            this.runDistanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.runDistanceTextBox.Name = "runDistanceTextBox";
            this.runDistanceTextBox.Size = new System.Drawing.Size(121, 27);
            this.runDistanceTextBox.TabIndex = 9;
            // 
            // runDurationTextBox
            // 
            this.runDurationTextBox.Location = new System.Drawing.Point(119, 116);
            this.runDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.runDurationTextBox.Name = "runDurationTextBox";
            this.runDurationTextBox.Size = new System.Drawing.Size(121, 27);
            this.runDurationTextBox.TabIndex = 10;
            // 
            // runPaceTextBox
            // 
            this.runPaceTextBox.Location = new System.Drawing.Point(119, 165);
            this.runPaceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.runPaceTextBox.Name = "runPaceTextBox";
            this.runPaceTextBox.Size = new System.Drawing.Size(121, 27);
            this.runPaceTextBox.TabIndex = 11;
            // 
            // runNotesTextBox
            // 
            this.runNotesTextBox.Location = new System.Drawing.Point(119, 459);
            this.runNotesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.runNotesTextBox.Name = "runNotesTextBox";
            this.runNotesTextBox.Size = new System.Drawing.Size(121, 27);
            this.runNotesTextBox.TabIndex = 12;
            // 
            // runTemperatureTextBox
            // 
            this.runTemperatureTextBox.Location = new System.Drawing.Point(119, 263);
            this.runTemperatureTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.runTemperatureTextBox.Name = "runTemperatureTextBox";
            this.runTemperatureTextBox.Size = new System.Drawing.Size(121, 27);
            this.runTemperatureTextBox.TabIndex = 15;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(22, 266);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(93, 20);
            this.temperatureLabel.TabIndex = 14;
            this.temperatureLabel.Text = "Temperature";
            // 
            // elevationGainTextBox
            // 
            this.elevationGainTextBox.Location = new System.Drawing.Point(119, 361);
            this.elevationGainTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.elevationGainTextBox.Name = "elevationGainTextBox";
            this.elevationGainTextBox.Size = new System.Drawing.Size(121, 27);
            this.elevationGainTextBox.TabIndex = 17;
            // 
            // elevationGainLabel
            // 
            this.elevationGainLabel.AutoSize = true;
            this.elevationGainLabel.Location = new System.Drawing.Point(11, 364);
            this.elevationGainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.elevationGainLabel.Name = "elevationGainLabel";
            this.elevationGainLabel.Size = new System.Drawing.Size(104, 20);
            this.elevationGainLabel.TabIndex = 16;
            this.elevationGainLabel.Text = "Elevation Gain";
            // 
            // shoesUsedTextBox
            // 
            this.shoesUsedTextBox.Location = new System.Drawing.Point(119, 410);
            this.shoesUsedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.shoesUsedTextBox.Name = "shoesUsedTextBox";
            this.shoesUsedTextBox.Size = new System.Drawing.Size(121, 27);
            this.shoesUsedTextBox.TabIndex = 19;
            // 
            // shoesUsedLabel
            // 
            this.shoesUsedLabel.AutoSize = true;
            this.shoesUsedLabel.Location = new System.Drawing.Point(30, 413);
            this.shoesUsedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoesUsedLabel.Name = "shoesUsedLabel";
            this.shoesUsedLabel.Size = new System.Drawing.Size(85, 20);
            this.shoesUsedLabel.TabIndex = 18;
            this.shoesUsedLabel.Text = "Shoes Used";
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(119, 312);
            this.humidityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(121, 27);
            this.humidityTextBox.TabIndex = 21;
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(45, 315);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(70, 20);
            this.humidityLabel.TabIndex = 20;
            this.humidityLabel.Text = "Humidity";
            // 
            // avgHRTextBox
            // 
            this.avgHRTextBox.Location = new System.Drawing.Point(119, 214);
            this.avgHRTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.avgHRTextBox.Name = "avgHRTextBox";
            this.avgHRTextBox.Size = new System.Drawing.Size(121, 27);
            this.avgHRTextBox.TabIndex = 23;
            // 
            // avgHRLabel
            // 
            this.avgHRLabel.AutoSize = true;
            this.avgHRLabel.Location = new System.Drawing.Point(27, 217);
            this.avgHRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgHRLabel.Name = "avgHRLabel";
            this.avgHRLabel.Size = new System.Drawing.Size(88, 20);
            this.avgHRLabel.TabIndex = 22;
            this.avgHRLabel.Text = "Average HR";
            // 
            // RunEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 633);
            this.Controls.Add(this.avgHRTextBox);
            this.Controls.Add(this.avgHRLabel);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.shoesUsedTextBox);
            this.Controls.Add(this.shoesUsedLabel);
            this.Controls.Add(this.elevationGainTextBox);
            this.Controls.Add(this.elevationGainLabel);
            this.Controls.Add(this.runTemperatureTextBox);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.runNotesTextBox);
            this.Controls.Add(this.runPaceTextBox);
            this.Controls.Add(this.runDurationTextBox);
            this.Controls.Add(this.runDistanceTextBox);
            this.Controls.Add(this.runDateTextBox);
            this.Controls.Add(this.runNotesLabel);
            this.Controls.Add(this.runPaceLabel);
            this.Controls.Add(this.runDurationLabel);
            this.Controls.Add(this.runDistanceLabel);
            this.Controls.Add(this.runDateLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RunEditView";
            this.Text = "Add/Edit Run";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunEditView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.runModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label runDateLabel;
        private Label runDistanceLabel;
        private Label runDurationLabel;
        private Label runPaceLabel;
        private Label runNotesLabel;
        private TextBox runDateTextBox;
        private TextBox runDistanceTextBox;
        private TextBox runDurationTextBox;
        private TextBox runPaceTextBox;
        private TextBox runNotesTextBox;
        private TextBox runTemperatureTextBox;
        private Label temperatureLabel;
        private TextBox elevationGainTextBox;
        private Label elevationGainLabel;
        private TextBox shoesUsedTextBox;
        private Label shoesUsedLabel;
        private BindingSource runModelBindingSource;
        private TextBox humidityTextBox;
        private Label humidityLabel;
        private TextBox avgHRTextBox;
        private Label avgHRLabel;
    }
}