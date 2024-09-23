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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceInput = new NumericUpDown();
            elevationInput = new NumericUpDown();
            lastHitLabel = new Label();
            lastHitCountdownLabel = new Label();
            clickTimerUpdateTimer = new System.Windows.Forms.Timer(components);
            modeComboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            stayOnTopToolStripMenuItem = new ToolStripMenuItem();
            listenToNumpadToolStripMenuItem = new ToolStripMenuItem();
            enableClickTimerToolStripMenuItem = new ToolStripMenuItem();
            lastConversionLabel = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)distanceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevationInput).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 999;
            label1.Text = "->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 999;
            label2.Text = "Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 999;
            label3.Text = "Elevation:";
            // 
            // distanceInput
            // 
            distanceInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            distanceInput.Location = new Point(13, 47);
            distanceInput.Margin = new Padding(4, 3, 4, 3);
            distanceInput.Maximum = new decimal(new int[] { 1600, 0, 0, 0 });
            distanceInput.Name = "distanceInput";
            distanceInput.Size = new Size(82, 24);
            distanceInput.TabIndex = 0;
            distanceInput.Value = new decimal(new int[] { 1600, 0, 0, 0 });
            distanceInput.ValueChanged += DistanceInput_ValueChanged;
            // 
            // elevationInput
            // 
            elevationInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            elevationInput.Location = new Point(127, 47);
            elevationInput.Margin = new Padding(4, 3, 4, 3);
            elevationInput.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            elevationInput.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            elevationInput.Name = "elevationInput";
            elevationInput.Size = new Size(82, 24);
            elevationInput.TabIndex = 1;
            elevationInput.Value = new decimal(new int[] { 622, 0, 0, 0 });
            // 
            // lastHitLabel
            // 
            lastHitLabel.AutoSize = true;
            lastHitLabel.Location = new Point(217, 28);
            lastHitLabel.Margin = new Padding(4, 0, 4, 0);
            lastHitLabel.Name = "lastHitLabel";
            lastHitLabel.Size = new Size(62, 15);
            lastHitLabel.TabIndex = 999;
            lastHitLabel.Text = "Last hit in:";
            lastHitLabel.Visible = false;
            // 
            // lastHitCountdownLabel
            // 
            lastHitCountdownLabel.BackColor = SystemColors.Window;
            lastHitCountdownLabel.BorderStyle = BorderStyle.FixedSingle;
            lastHitCountdownLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastHitCountdownLabel.Location = new Point(221, 47);
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
            clickTimerUpdateTimer.Tick += ClickTimerUpdateTimer_Tick;
            // 
            // modeComboBox
            // 
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Items.AddRange(new object[] { "Axis/Allies", "British", "USSR" });
            modeComboBox.Location = new Point(13, 92);
            modeComboBox.Margin = new Padding(4, 3, 4, 3);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(98, 23);
            modeComboBox.TabIndex = 3;
            modeComboBox.SelectedIndexChanged += ModeComboBox_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImeMode = ImeMode.NoControl;
            menuStrip1.Items.AddRange(new ToolStripItem[] { configurationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(292, 24);
            menuStrip1.TabIndex = 1000;
            menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stayOnTopToolStripMenuItem, listenToNumpadToolStripMenuItem, enableClickTimerToolStripMenuItem });
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(93, 20);
            configurationToolStripMenuItem.Text = "Configuration";
            // 
            // stayOnTopToolStripMenuItem
            // 
            stayOnTopToolStripMenuItem.CheckOnClick = true;
            stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            stayOnTopToolStripMenuItem.Size = new Size(167, 22);
            stayOnTopToolStripMenuItem.Text = "Stay on top";
            stayOnTopToolStripMenuItem.Click += StayOnTopCheckbox_CheckedChanged;
            // 
            // listenToNumpadToolStripMenuItem
            // 
            listenToNumpadToolStripMenuItem.CheckOnClick = true;
            listenToNumpadToolStripMenuItem.Name = "listenToNumpadToolStripMenuItem";
            listenToNumpadToolStripMenuItem.Size = new Size(167, 22);
            listenToNumpadToolStripMenuItem.Text = "Listen to numpad";
            listenToNumpadToolStripMenuItem.Click += EnableNumpadCheckbox_CheckedChanged;
            // 
            // enableClickTimerToolStripMenuItem
            // 
            enableClickTimerToolStripMenuItem.CheckOnClick = true;
            enableClickTimerToolStripMenuItem.Name = "enableClickTimerToolStripMenuItem";
            enableClickTimerToolStripMenuItem.Size = new Size(167, 22);
            enableClickTimerToolStripMenuItem.Text = "Enable click timer";
            enableClickTimerToolStripMenuItem.Click += EnableClickTimerCheckbox_CheckedChanged;
            // 
            // lastConversionLabel
            // 
            lastConversionLabel.BackColor = SystemColors.Window;
            lastConversionLabel.BorderStyle = BorderStyle.FixedSingle;
            lastConversionLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastConversionLabel.Location = new Point(127, 92);
            lastConversionLabel.Margin = new Padding(4, 0, 4, 0);
            lastConversionLabel.Name = "lastConversionLabel";
            lastConversionLabel.Size = new Size(157, 26);
            lastConversionLabel.TabIndex = 1001;
            lastConversionLabel.Text = "-";
            lastConversionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 74);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 1002;
            label5.Text = "Last Conversion";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 131);
            Controls.Add(lastConversionLabel);
            Controls.Add(label5);
            Controls.Add(modeComboBox);
            Controls.Add(lastHitCountdownLabel);
            Controls.Add(lastHitLabel);
            Controls.Add(elevationInput);
            Controls.Add(distanceInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculatorForm";
            Text = "HLL Artillery Calculator v1.1.0";
            FormClosing += CalculatorForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)distanceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevationInput).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown distanceInput;
        private System.Windows.Forms.NumericUpDown elevationInput;
        private System.Windows.Forms.Label lastHitLabel;
        private System.Windows.Forms.Label lastHitCountdownLabel;
        private System.Windows.Forms.Timer clickTimerUpdateTimer;
        private System.Windows.Forms.ComboBox modeComboBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem stayOnTopToolStripMenuItem;
        private ToolStripMenuItem listenToNumpadToolStripMenuItem;
        private ToolStripMenuItem enableClickTimerToolStripMenuItem;
        private Label lastConversionLabel;
        private Label label5;
    }
}

