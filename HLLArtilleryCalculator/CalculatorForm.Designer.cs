namespace HLLArtilleryCalculator
{
    partial class CalculatorForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            enableNumpadCheckbox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceInput = new NumericUpDown();
            elevationInput = new NumericUpDown();
            stayOnTopCheckbox = new CheckBox();
            enableClickTimerCheckbox = new CheckBox();
            lastHitLabel = new Label();
            lastHitCountdownLabel = new Label();
            clickTimerUpdateTimer = new System.Windows.Forms.Timer(components);
            transparentCheckbox = new CheckBox();
            modeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)distanceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevationInput).BeginInit();
            SuspendLayout();
            // 
            // enableNumpadCheckbox
            // 
            enableNumpadCheckbox.AutoSize = true;
            enableNumpadCheckbox.Location = new Point(299, 32);
            enableNumpadCheckbox.Margin = new Padding(4, 3, 4, 3);
            enableNumpadCheckbox.Name = "enableNumpadCheckbox";
            enableNumpadCheckbox.Size = new Size(119, 19);
            enableNumpadCheckbox.TabIndex = 6;
            enableNumpadCheckbox.Text = "Listen to numpad";
            enableNumpadCheckbox.UseVisualStyleBackColor = true;
            enableNumpadCheckbox.CheckedChanged += enableNumpadCheckbox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 999;
            label1.Text = "->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 999;
            label2.Text = "Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 6);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 999;
            label3.Text = "Elevation:";
            // 
            // distanceInput
            // 
            distanceInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            distanceInput.Location = new Point(14, 25);
            distanceInput.Margin = new Padding(4, 3, 4, 3);
            distanceInput.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            distanceInput.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            distanceInput.Name = "distanceInput";
            distanceInput.Size = new Size(82, 24);
            distanceInput.TabIndex = 0;
            distanceInput.Value = new decimal(new int[] { 1600, 0, 0, 0 });
            distanceInput.ValueChanged += distanceInput_ValueChanged;
            // 
            // elevationInput
            // 
            elevationInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            elevationInput.Location = new Point(128, 25);
            elevationInput.Margin = new Padding(4, 3, 4, 3);
            elevationInput.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            elevationInput.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            elevationInput.Name = "elevationInput";
            elevationInput.Size = new Size(82, 24);
            elevationInput.TabIndex = 1;
            elevationInput.Value = new decimal(new int[] { 622, 0, 0, 0 });
            // 
            // stayOnTopCheckbox
            // 
            stayOnTopCheckbox.AutoSize = true;
            stayOnTopCheckbox.Location = new Point(299, 6);
            stayOnTopCheckbox.Margin = new Padding(4, 3, 4, 3);
            stayOnTopCheckbox.Name = "stayOnTopCheckbox";
            stayOnTopCheckbox.Size = new Size(86, 19);
            stayOnTopCheckbox.TabIndex = 5;
            stayOnTopCheckbox.Text = "Stay on top";
            stayOnTopCheckbox.UseVisualStyleBackColor = true;
            stayOnTopCheckbox.CheckedChanged += stayOnTopCheckbox_CheckedChanged;
            // 
            // enableClickTimerCheckbox
            // 
            enableClickTimerCheckbox.AutoSize = true;
            enableClickTimerCheckbox.Location = new Point(299, 60);
            enableClickTimerCheckbox.Margin = new Padding(4, 3, 4, 3);
            enableClickTimerCheckbox.Name = "enableClickTimerCheckbox";
            enableClickTimerCheckbox.Size = new Size(119, 19);
            enableClickTimerCheckbox.TabIndex = 7;
            enableClickTimerCheckbox.Text = "Enable click timer";
            enableClickTimerCheckbox.UseVisualStyleBackColor = true;
            enableClickTimerCheckbox.CheckedChanged += enableClickTimerCheckbox_CheckedChanged;
            // 
            // lastHitLabel
            // 
            lastHitLabel.AutoSize = true;
            lastHitLabel.Location = new Point(218, 6);
            lastHitLabel.Margin = new Padding(4, 0, 4, 0);
            lastHitLabel.Name = "lastHitLabel";
            lastHitLabel.Size = new Size(61, 15);
            lastHitLabel.TabIndex = 999;
            lastHitLabel.Text = "Last hit in:";
            lastHitLabel.Visible = false;
            // 
            // lastHitCountdownLabel
            // 
            lastHitCountdownLabel.BackColor = SystemColors.Window;
            lastHitCountdownLabel.BorderStyle = BorderStyle.FixedSingle;
            lastHitCountdownLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastHitCountdownLabel.Location = new Point(222, 25);
            lastHitCountdownLabel.Margin = new Padding(4, 0, 4, 0);
            lastHitCountdownLabel.Name = "lastHitCountdownLabel";
            lastHitCountdownLabel.Size = new Size(63, 26);
            lastHitCountdownLabel.TabIndex = 999;
            lastHitCountdownLabel.TextAlign = ContentAlignment.MiddleCenter;
            lastHitCountdownLabel.Visible = false;
            // 
            // clickTimerUpdateTimer
            // 
            clickTimerUpdateTimer.Interval = 250;
            clickTimerUpdateTimer.Tick += clickTimerUpdateTimer_Tick;
            // 
            // transparentCheckbox
            // 
            transparentCheckbox.AutoSize = true;
            transparentCheckbox.Location = new Point(120, 62);
            transparentCheckbox.Margin = new Padding(4, 3, 4, 3);
            transparentCheckbox.Name = "transparentCheckbox";
            transparentCheckbox.Size = new Size(164, 19);
            transparentCheckbox.TabIndex = 4;
            transparentCheckbox.Text = "Transparent (Ctrl+Shift+K)";
            transparentCheckbox.UseVisualStyleBackColor = true;
            transparentCheckbox.CheckedChanged += transparentCheckbox_CheckedChanged;
            // 
            // modeComboBox
            // 
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Items.AddRange(new object[] { "Axis/Allies", "British", "USSR" });
            modeComboBox.Location = new Point(14, 60);
            modeComboBox.Margin = new Padding(4, 3, 4, 3);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(98, 23);
            modeComboBox.TabIndex = 3;
            modeComboBox.SelectedIndexChanged += ModeComboBox_SelectedIndexChanged;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 92);
            Controls.Add(modeComboBox);
            Controls.Add(transparentCheckbox);
            Controls.Add(lastHitCountdownLabel);
            Controls.Add(lastHitLabel);
            Controls.Add(stayOnTopCheckbox);
            Controls.Add(elevationInput);
            Controls.Add(distanceInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enableClickTimerCheckbox);
            Controls.Add(enableNumpadCheckbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CalculatorForm";
            Text = "Artillery Calculator";
            Activated += CalculatorForm_Activated;
            FormClosing += CalculatorForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)distanceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevationInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.CheckBox enableNumpadCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown distanceInput;
        private System.Windows.Forms.NumericUpDown elevationInput;
        private System.Windows.Forms.CheckBox stayOnTopCheckbox;
        private System.Windows.Forms.CheckBox enableClickTimerCheckbox;
        private System.Windows.Forms.Label lastHitLabel;
        private System.Windows.Forms.Label lastHitCountdownLabel;
        private System.Windows.Forms.Timer clickTimerUpdateTimer;
        private System.Windows.Forms.CheckBox transparentCheckbox;
        private System.Windows.Forms.ComboBox modeComboBox;
    }
}

