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
            lastHitLabel = new Label();
            clickTimerUpdateTimer = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            stayOnTopToolStripMenuItem = new ToolStripMenuItem();
            listenToNumpadToolStripMenuItem = new ToolStripMenuItem();
            enableClickTimerToolStripMenuItem = new ToolStripMenuItem();
            modeComboBox = new ToolStripComboBox();
            label5 = new Label();
            lastConversionLabel = new Label();
            lastHitCountdownLabel = new Label();
            elevationInput = new Label();
            keyPressDistanceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)distanceInput).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 999;
            label1.Text = "->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(9, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 999;
            label2.Text = "Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(98, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
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
            distanceInput.Size = new Size(54, 24);
            distanceInput.TabIndex = 0;
            distanceInput.Value = new decimal(new int[] { 1600, 0, 0, 0 });
            distanceInput.ValueChanged += DistanceInput_ValueChanged;
            // 
            // lastHitLabel
            // 
            lastHitLabel.AutoSize = true;
            lastHitLabel.Font = new Font("Segoe UI", 9F);
            lastHitLabel.Location = new Point(166, 28);
            lastHitLabel.Margin = new Padding(4, 0, 4, 0);
            lastHitLabel.Name = "lastHitLabel";
            lastHitLabel.Size = new Size(61, 15);
            lastHitLabel.TabIndex = 999;
            lastHitLabel.Text = "Last hit in:";
            lastHitLabel.Visible = false;
            // 
            // clickTimerUpdateTimer
            // 
            clickTimerUpdateTimer.Interval = 250;
            clickTimerUpdateTimer.Tick += ClickTimerUpdateTimer_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImeMode = ImeMode.NoControl;
            menuStrip1.Items.AddRange(new ToolStripItem[] { configurationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(234, 24);
            menuStrip1.TabIndex = 1000;
            menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stayOnTopToolStripMenuItem, listenToNumpadToolStripMenuItem, enableClickTimerToolStripMenuItem, modeComboBox });
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(93, 20);
            configurationToolStripMenuItem.Text = "Configuration";
            // 
            // stayOnTopToolStripMenuItem
            // 
            stayOnTopToolStripMenuItem.CheckOnClick = true;
            stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            stayOnTopToolStripMenuItem.Size = new Size(181, 22);
            stayOnTopToolStripMenuItem.Text = "Stay on top";
            stayOnTopToolStripMenuItem.Click += StayOnTopCheckbox_CheckedChanged;
            // 
            // listenToNumpadToolStripMenuItem
            // 
            listenToNumpadToolStripMenuItem.CheckOnClick = true;
            listenToNumpadToolStripMenuItem.Name = "listenToNumpadToolStripMenuItem";
            listenToNumpadToolStripMenuItem.Size = new Size(181, 22);
            listenToNumpadToolStripMenuItem.Text = "Listen to numpad";
            listenToNumpadToolStripMenuItem.Click += EnableNumpadCheckbox_CheckedChanged;
            // 
            // enableClickTimerToolStripMenuItem
            // 
            enableClickTimerToolStripMenuItem.CheckOnClick = true;
            enableClickTimerToolStripMenuItem.Name = "enableClickTimerToolStripMenuItem";
            enableClickTimerToolStripMenuItem.Size = new Size(181, 22);
            enableClickTimerToolStripMenuItem.Text = "Enable click timer";
            enableClickTimerToolStripMenuItem.Click += EnableClickTimerCheckbox_CheckedChanged;
            // 
            // modeComboBox
            // 
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.Items.AddRange(new object[] { "Axis/Allies", "British", "USSR" });
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(121, 23);
            modeComboBox.SelectedIndexChanged += ModeComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(13, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 1002;
            label5.Text = "Last Conversion:";
            // 
            // lastConversionLabel
            // 
            lastConversionLabel.Font = new Font("Microsoft Sans Serif", 11.25F);
            lastConversionLabel.Location = new Point(13, 119);
            lastConversionLabel.Margin = new Padding(4, 0, 4, 0);
            lastConversionLabel.Name = "lastConversionLabel";
            lastConversionLabel.Size = new Size(208, 20);
            lastConversionLabel.TabIndex = 1003;
            lastConversionLabel.Text = "-";
            // 
            // lastHitCountdownLabel
            // 
            lastHitCountdownLabel.Font = new Font("Microsoft Sans Serif", 11.25F);
            lastHitCountdownLabel.Location = new Point(166, 49);
            lastHitCountdownLabel.Margin = new Padding(4, 0, 4, 0);
            lastHitCountdownLabel.Name = "lastHitCountdownLabel";
            lastHitCountdownLabel.Size = new Size(60, 20);
            lastHitCountdownLabel.TabIndex = 1004;
            lastHitCountdownLabel.Text = "-";
            lastHitCountdownLabel.Visible = false;
            // 
            // elevationInput
            // 
            elevationInput.Font = new Font("Microsoft Sans Serif", 11.25F);
            elevationInput.Location = new Point(98, 49);
            elevationInput.Margin = new Padding(4, 0, 4, 0);
            elevationInput.Name = "elevationInput";
            elevationInput.Size = new Size(60, 20);
            elevationInput.TabIndex = 1005;
            elevationInput.Text = "-";
            // 
            // keyPressDistanceLabel
            // 
            keyPressDistanceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keyPressDistanceLabel.ForeColor = SystemColors.GrayText;
            keyPressDistanceLabel.Location = new Point(13, 74);
            keyPressDistanceLabel.Margin = new Padding(4, 0, 4, 0);
            keyPressDistanceLabel.Name = "keyPressDistanceLabel";
            keyPressDistanceLabel.Size = new Size(54, 19);
            keyPressDistanceLabel.TabIndex = 1006;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 151);
            Controls.Add(keyPressDistanceLabel);
            Controls.Add(elevationInput);
            Controls.Add(lastHitCountdownLabel);
            Controls.Add(lastConversionLabel);
            Controls.Add(label5);
            Controls.Add(lastHitLabel);
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
            Text = "HLL Artillery Calculator v1.0.3";
            FormClosing += CalculatorForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)distanceInput).EndInit();
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
        private System.Windows.Forms.Label lastHitLabel;
        private System.Windows.Forms.Timer clickTimerUpdateTimer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem stayOnTopToolStripMenuItem;
        private ToolStripMenuItem listenToNumpadToolStripMenuItem;
        private ToolStripMenuItem enableClickTimerToolStripMenuItem;
        private Label label5;
        private Label lastConversionLabel;
        private ToolStripComboBox modeComboBox;
        private Label lastHitCountdownLabel;
        private Label elevationInput;
        private Label keyPressDistanceLabel;
    }
}

