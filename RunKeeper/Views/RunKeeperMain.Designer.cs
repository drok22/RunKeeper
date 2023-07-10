namespace RunKeeper
{
    partial class RunKeeperMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.runDataGridView = new System.Windows.Forms.DataGridView();
            this.runDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageHRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoesUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevationGainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.runModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runKeeperMainTabControl = new System.Windows.Forms.TabControl();
            this.runsTabPage = new System.Windows.Forms.TabPage();
            this.addRunButton = new System.Windows.Forms.Button();
            this.shoesTabPage = new System.Windows.Forms.TabPage();
            this.addShoesButton = new System.Windows.Forms.Button();
            this.shoeDataGridView = new System.Windows.Forms.DataGridView();
            this.shoeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometersRunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.runDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runModelBindingSource)).BeginInit();
            this.runKeeperMainTabControl.SuspendLayout();
            this.runsTabPage.SuspendLayout();
            this.shoesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runDataGridView
            // 
            this.runDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runDataGridView.AutoGenerateColumns = false;
            this.runDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.runDateDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.paceDataGridViewTextBoxColumn,
            this.averageHRDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.shoesUsedDataGridViewTextBoxColumn,
            this.elevationGainDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn});
            this.runDataGridView.DataSource = this.runModelBindingSource1;
            this.runDataGridView.Location = new System.Drawing.Point(6, 195);
            this.runDataGridView.Name = "runDataGridView";
            this.runDataGridView.RowHeadersWidth = 51;
            this.runDataGridView.RowTemplate.Height = 29;
            this.runDataGridView.Size = new System.Drawing.Size(1187, 443);
            this.runDataGridView.TabIndex = 0;
            // 
            // runDateDataGridViewTextBoxColumn
            // 
            this.runDateDataGridViewTextBoxColumn.DataPropertyName = "RunDate";
            this.runDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.runDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.runDateDataGridViewTextBoxColumn.Name = "runDateDataGridViewTextBoxColumn";
            this.runDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // paceDataGridViewTextBoxColumn
            // 
            this.paceDataGridViewTextBoxColumn.DataPropertyName = "Pace";
            this.paceDataGridViewTextBoxColumn.HeaderText = "Pace";
            this.paceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paceDataGridViewTextBoxColumn.Name = "paceDataGridViewTextBoxColumn";
            this.paceDataGridViewTextBoxColumn.Width = 125;
            // 
            // averageHRDataGridViewTextBoxColumn
            // 
            this.averageHRDataGridViewTextBoxColumn.DataPropertyName = "AverageHR";
            this.averageHRDataGridViewTextBoxColumn.HeaderText = "Average HR";
            this.averageHRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averageHRDataGridViewTextBoxColumn.Name = "averageHRDataGridViewTextBoxColumn";
            this.averageHRDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // shoesUsedDataGridViewTextBoxColumn
            // 
            this.shoesUsedDataGridViewTextBoxColumn.DataPropertyName = "ShoesUsed";
            this.shoesUsedDataGridViewTextBoxColumn.HeaderText = "Shoes Used";
            this.shoesUsedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shoesUsedDataGridViewTextBoxColumn.Name = "shoesUsedDataGridViewTextBoxColumn";
            this.shoesUsedDataGridViewTextBoxColumn.Width = 125;
            // 
            // elevationGainDataGridViewTextBoxColumn
            // 
            this.elevationGainDataGridViewTextBoxColumn.DataPropertyName = "ElevationGain";
            this.elevationGainDataGridViewTextBoxColumn.HeaderText = "Elevation Gain";
            this.elevationGainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elevationGainDataGridViewTextBoxColumn.Name = "elevationGainDataGridViewTextBoxColumn";
            this.elevationGainDataGridViewTextBoxColumn.Width = 125;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.Width = 125;
            // 
            // runModelBindingSource1
            // 
            this.runModelBindingSource1.DataSource = typeof(RunKeeper.Classes.RunModel);
            // 
            // runModelBindingSource
            // 
            this.runModelBindingSource.DataSource = typeof(RunKeeper.Classes.RunModel);
            // 
            // runKeeperMainTabControl
            // 
            this.runKeeperMainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runKeeperMainTabControl.Controls.Add(this.runsTabPage);
            this.runKeeperMainTabControl.Controls.Add(this.shoesTabPage);
            this.runKeeperMainTabControl.Location = new System.Drawing.Point(12, 12);
            this.runKeeperMainTabControl.Name = "runKeeperMainTabControl";
            this.runKeeperMainTabControl.SelectedIndex = 0;
            this.runKeeperMainTabControl.Size = new System.Drawing.Size(1207, 677);
            this.runKeeperMainTabControl.TabIndex = 2;
            // 
            // runsTabPage
            // 
            this.runsTabPage.Controls.Add(this.addRunButton);
            this.runsTabPage.Controls.Add(this.runDataGridView);
            this.runsTabPage.Location = new System.Drawing.Point(4, 29);
            this.runsTabPage.Name = "runsTabPage";
            this.runsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.runsTabPage.Size = new System.Drawing.Size(1199, 644);
            this.runsTabPage.TabIndex = 0;
            this.runsTabPage.Text = "Runs";
            this.runsTabPage.UseVisualStyleBackColor = true;
            // 
            // addRunButton
            // 
            this.addRunButton.Location = new System.Drawing.Point(1099, 160);
            this.addRunButton.Name = "addRunButton";
            this.addRunButton.Size = new System.Drawing.Size(94, 29);
            this.addRunButton.TabIndex = 1;
            this.addRunButton.Text = "Track a Run";
            this.addRunButton.UseVisualStyleBackColor = true;
            this.addRunButton.Click += new System.EventHandler(this.AddRunButtonClicked);
            // 
            // shoesTabPage
            // 
            this.shoesTabPage.Controls.Add(this.addShoesButton);
            this.shoesTabPage.Controls.Add(this.shoeDataGridView);
            this.shoesTabPage.Location = new System.Drawing.Point(4, 29);
            this.shoesTabPage.Name = "shoesTabPage";
            this.shoesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shoesTabPage.Size = new System.Drawing.Size(1199, 644);
            this.shoesTabPage.TabIndex = 1;
            this.shoesTabPage.Text = "Shoes";
            this.shoesTabPage.UseVisualStyleBackColor = true;
            // 
            // addShoesButton
            // 
            this.addShoesButton.Location = new System.Drawing.Point(1099, 211);
            this.addShoesButton.Name = "addShoesButton";
            this.addShoesButton.Size = new System.Drawing.Size(94, 29);
            this.addShoesButton.TabIndex = 2;
            this.addShoesButton.Text = "Add Shoes";
            this.addShoesButton.UseVisualStyleBackColor = true;
            this.addShoesButton.Click += new System.EventHandler(this.AddShoesButtonClicked);
            // 
            // shoeDataGridView
            // 
            this.shoeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoeDataGridView.AutoGenerateColumns = false;
            this.shoeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.shoeNameDataGridViewTextBoxColumn,
            this.kilometersRunDataGridViewTextBoxColumn});
            this.shoeDataGridView.DataSource = this.shoeModelBindingSource;
            this.shoeDataGridView.Location = new System.Drawing.Point(6, 246);
            this.shoeDataGridView.Name = "shoeDataGridView";
            this.shoeDataGridView.RowHeadersWidth = 51;
            this.shoeDataGridView.RowTemplate.Height = 29;
            this.shoeDataGridView.Size = new System.Drawing.Size(1187, 392);
            this.shoeDataGridView.TabIndex = 0;
            // 
            // shoeModelBindingSource
            // 
            this.shoeModelBindingSource.DataSource = typeof(RunKeeper.Classes.ShoeModel);
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // shoeNameDataGridViewTextBoxColumn
            // 
            this.shoeNameDataGridViewTextBoxColumn.DataPropertyName = "ShoeName";
            this.shoeNameDataGridViewTextBoxColumn.HeaderText = "Shoe Name";
            this.shoeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shoeNameDataGridViewTextBoxColumn.Name = "shoeNameDataGridViewTextBoxColumn";
            this.shoeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // kilometersRunDataGridViewTextBoxColumn
            // 
            this.kilometersRunDataGridViewTextBoxColumn.DataPropertyName = "KilometersRun";
            this.kilometersRunDataGridViewTextBoxColumn.HeaderText = "Kilometers Run";
            this.kilometersRunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kilometersRunDataGridViewTextBoxColumn.Name = "kilometersRunDataGridViewTextBoxColumn";
            this.kilometersRunDataGridViewTextBoxColumn.Width = 125;
            // 
            // RunKeeperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 701);
            this.Controls.Add(this.runKeeperMainTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RunKeeperMain";
            this.Text = "RunKeepR";
            ((System.ComponentModel.ISupportInitialize)(this.runDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runModelBindingSource)).EndInit();
            this.runKeeperMainTabControl.ResumeLayout(false);
            this.runsTabPage.ResumeLayout(false);
            this.shoesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shoeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView runDataGridView;
        private DataGridViewTextBoxColumn runDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averageHRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shoesUsedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elevationGainDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private BindingSource runModelBindingSource;
        private TabControl runKeeperMainTabControl;
        private TabPage runsTabPage;
        private TabPage shoesTabPage;
        private Button addShoesButton;
        private DataGridView shoeDataGridView;
        private BindingSource shoeModelBindingSource;
        private Button addRunButton;
        private BindingSource runModelBindingSource1;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shoeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kilometersRunDataGridViewTextBoxColumn;
    }
}