using System;
using System.Windows.Forms;
using System.Timers;

namespace HLLArtilleryCalculator
{
    public partial class CalculatorForm : Form
    {
        IDistanceElevationConverter Converter { get; set; } = new DistanceElevationConverter();
        ArtilleryTimingCalculator TimingCalculator { get; } = new ArtilleryTimingCalculator();
        ConversionHistory ConversionHistory { get; } = new ConversionHistory();

        NumpadListener NumpadListener { get; set; } = null;
        ClickListener ClickListener { get; set; } = null;

        DateTime LastNumpadInputAt { get; set; } = DateTime.MinValue;
        DateTime LastClickAt { get; set; } = DateTime.MinValue;

        decimal pendingDistance = 0;
        Debouncer InputDebouncer { get; set; } = null;

        public CalculatorForm()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            listenToNumpadToolStripMenuItem.Checked = Properties.Settings.Default.EnableNumpadListener;
            stayOnTopToolStripMenuItem.Checked = Properties.Settings.Default.StayOnTop;
            enableClickTimerToolStripMenuItem.Checked = Properties.Settings.Default.EnableClickTimer;
            modeComboBox.SelectedItem = Properties.Settings.Default.ConversionMode;

            pendingDistance = distanceInput.Value;
            InputDebouncer = new Debouncer(500);
        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void EnableNumpadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumpadListener();
        }

        private void UpdateNumpadListener()
        {
            var enabled = Properties.Settings.Default.EnableNumpadListener = listenToNumpadToolStripMenuItem.Checked;
            if (enabled && NumpadListener == null)
            {
                NumpadListener = new NumpadListener() { Callback = ReceiveNumpadDigit };
            }
            else if (!enabled && NumpadListener != null)
            {
                NumpadListener.Dispose();
                NumpadListener = null;
            }
        }

        private void EnableClickTimerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClickListener();
            UpdateClickTimerControls();
        }

        private void UpdateClickListener()
        {
            var enabled = Properties.Settings.Default.EnableClickTimer = enableClickTimerToolStripMenuItem.Checked;
            if (enabled && ClickListener == null)
            {
                ClickListener = new ClickListener() { Callback = ReceiveClick };
            }
            else if (!enabled && ClickListener != null)
            {
                ClickListener.Dispose();
                ClickListener = null;
            }
        }

        private void UpdateClickTimerControls()
        {
            if (enableClickTimerToolStripMenuItem.Checked)
            {
                clickTimerUpdateTimer.Start();
                lastHitLabel.Show();
                lastHitCountdownLabel.Show();
            }
            else
            {
                clickTimerUpdateTimer.Stop();
                lastHitLabel.Hide();
                lastHitCountdownLabel.Hide();
            }
        }

        private void StayOnTopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            TopMost = Properties.Settings.Default.StayOnTop = item.Checked;
        }

        private void DistanceInput_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown control = (NumericUpDown)sender;
            int distanceValue = (int)control.Value;

            int mil = Converter.ConvertDistanceToElevation(distanceValue);
            elevationInput.Text = mil.ToString();

            try
            {
                // Show Latest Entry
                var entry = ConversionHistory.GetLatestEntry();
                lastConversionLabel.Text = entry.ToString();

            }
            catch (Exception ex)
            {
                // No Entries
            }


            // Safe for History
            ConversionHistory.AddEntry(distanceValue, mil);

        }

        private void OnDebounceComplete(int distance)
        {
            distanceInput.Invoke((MethodInvoker)delegate
            {
                distanceInput.Value = distance;
                keyPressDistanceLabel.Text = "";
            });
        }


        private void ReceiveNumpadDigit(int digit)
        {
            if (ActiveForm == this)
            {
                return;
            }

            if (DateTime.Now - LastNumpadInputAt > TimeSpan.FromSeconds(1))
            {
                pendingDistance = digit;
            }
            else
            {
                var newStringValue = pendingDistance.ToString() + digit;
                if (decimal.TryParse(newStringValue, out var newValue))
                {
                    if (newValue <= 1600 && newValue >= 0)
                    {
                        pendingDistance = newValue;
                    }
                }
            }

            InputDebouncer.Debounce((int)pendingDistance, OnDebounceComplete);
            keyPressDistanceLabel.Text = pendingDistance.ToString();

            LastNumpadInputAt = DateTime.Now;
        }

        private void ClickTimerUpdateTimer_Tick(object sender, EventArgs e)
        {
            var hitTimePrediction = TimingCalculator.PredictHitTime(LastClickAt);
            var timeUntilHit = hitTimePrediction - DateTime.Now;
            var remainingSeconds = Math.Round(timeUntilHit.TotalSeconds);

            if (remainingSeconds < 0)
            {
                lastHitCountdownLabel.Text = "-";
            }
            else
            {
                lastHitCountdownLabel.Text = remainingSeconds.ToString();
            }
        }

        private void ReceiveClick()
        {
            LastClickAt = DateTime.Now;
        }

        private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conversionMode = modeComboBox.SelectedItem;
            switch (conversionMode)
            {
                case "Axis/Allies":
                    Converter = new DistanceElevationConverter();
                    break;
                case "USSR":
                    Converter = new RussianDistanceElevationConverter();
                    break;
                case "British":
                    Converter = new BritishDistanceElevationConverter();
                    break;
            }

            // Update Elevation
            elevationInput.Text = Converter.ConvertDistanceToElevation(Convert.ToInt32(distanceInput.Value)).ToString();
        }

    }
}
