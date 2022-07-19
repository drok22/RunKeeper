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
            this.runDateLabel = new System.Windows.Forms.Label();
            this.runDistanceLabel = new System.Windows.Forms.Label();
            this.runDurationLabel = new System.Windows.Forms.Label();
            this.runPaceLabel = new System.Windows.Forms.Label();
            this.runNotesLabel = new System.Windows.Forms.Label();
            this.runShoesLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // runDateLabel
            // 
            this.runDateLabel.AutoSize = true;
            this.runDateLabel.Location = new System.Drawing.Point(67, 42);
            this.runDateLabel.Name = "runDateLabel";
            this.runDateLabel.Size = new System.Drawing.Size(49, 25);
            this.runDateLabel.TabIndex = 2;
            this.runDateLabel.Text = "Date";
            // 
            // runDistanceLabel
            // 
            this.runDistanceLabel.AutoSize = true;
            this.runDistanceLabel.Location = new System.Drawing.Point(37, 101);
            this.runDistanceLabel.Name = "runDistanceLabel";
            this.runDistanceLabel.Size = new System.Drawing.Size(79, 25);
            this.runDistanceLabel.TabIndex = 3;
            this.runDistanceLabel.Text = "Distance";
            // 
            // runDurationLabel
            // 
            this.runDurationLabel.AutoSize = true;
            this.runDurationLabel.Location = new System.Drawing.Point(35, 160);
            this.runDurationLabel.Name = "runDurationLabel";
            this.runDurationLabel.Size = new System.Drawing.Size(81, 25);
            this.runDurationLabel.TabIndex = 4;
            this.runDurationLabel.Text = "Duration";
            // 
            // runPaceLabel
            // 
            this.runPaceLabel.AutoSize = true;
            this.runPaceLabel.Location = new System.Drawing.Point(69, 219);
            this.runPaceLabel.Name = "runPaceLabel";
            this.runPaceLabel.Size = new System.Drawing.Size(47, 25);
            this.runPaceLabel.TabIndex = 5;
            this.runPaceLabel.Text = "Pace";
            // 
            // runNotesLabel
            // 
            this.runNotesLabel.AutoSize = true;
            this.runNotesLabel.Location = new System.Drawing.Point(57, 278);
            this.runNotesLabel.Name = "runNotesLabel";
            this.runNotesLabel.Size = new System.Drawing.Size(59, 25);
            this.runNotesLabel.TabIndex = 6;
            this.runNotesLabel.Text = "Notes";
            // 
            // runShoesLabel
            // 
            this.runShoesLabel.AutoSize = true;
            this.runShoesLabel.Location = new System.Drawing.Point(56, 337);
            this.runShoesLabel.Name = "runShoesLabel";
            this.runShoesLabel.Size = new System.Drawing.Size(60, 25);
            this.runShoesLabel.TabIndex = 7;
            this.runShoesLabel.Text = "Shoes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 31);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(122, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 31);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(122, 275);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 31);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(122, 334);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 31);
            this.textBox7.TabIndex = 13;
            // 
            // RunEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 407);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.runShoesLabel);
            this.Controls.Add(this.runNotesLabel);
            this.Controls.Add(this.runPaceLabel);
            this.Controls.Add(this.runDurationLabel);
            this.Controls.Add(this.runDistanceLabel);
            this.Controls.Add(this.runDateLabel);
            this.Name = "RunEditView";
            this.Text = "Add/Edit Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label runDateLabel;
        private Label runDistanceLabel;
        private Label runDurationLabel;
        private Label runPaceLabel;
        private Label runNotesLabel;
        private Label runShoesLabel;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}