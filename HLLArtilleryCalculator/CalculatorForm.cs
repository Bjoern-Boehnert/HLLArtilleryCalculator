using System;
using System.Windows.Forms;

namespace HLLArtilleryCalculator
{
    public partial class CalculatorForm : Form
    {
        IDistanceElevationConverter Converter { get; set; } = new DistanceElevationConverter();
        ArtilleryTimingCalculator TimingCalculator { get; } = new ArtilleryTimingCalculator();

        NumpadListener NumpadListener { get; set; } = null;
        ClickListener ClickListener { get; set; } = null;
        TransparencyHotkeyListener TransparencyListener { get; }
        TransparencyManager TransparencyManager { get; }

        DateTime LastNumpadInputAt { get; set; } = DateTime.MinValue;
        DateTime LastClickAt { get; set; } = DateTime.MinValue;

        public CalculatorForm()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            enableNumpadCheckbox.Checked = Properties.Settings.Default.EnableNumpadListener;
            stayOnTopCheckbox.Checked = Properties.Settings.Default.StayOnTop;
            enableClickTimerCheckbox.Checked = Properties.Settings.Default.EnableClickTimer;
            modeComboBox.SelectedItem = Properties.Settings.Default.ConversionMode;

            TransparencyManager = new TransparencyManager(this);
            TransparencyListener = new TransparencyHotkeyListener()
            {
                Callback = () => transparentCheckbox.Checked = !transparentCheckbox.Checked
            };
        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void enableNumpadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumpadListener();
        }

        private void UpdateNumpadListener()
        {
            var enabled = Properties.Settings.Default.EnableNumpadListener = enableNumpadCheckbox.Checked;
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

        private void enableClickTimerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClickListener();
            UpdateClickTimerControls();
        }

        private void UpdateClickListener()
        {
            var enabled = Properties.Settings.Default.EnableClickTimer = enableClickTimerCheckbox.Checked;
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
            if (enableClickTimerCheckbox.Checked)
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

        private void stayOnTopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = Properties.Settings.Default.StayOnTop = stayOnTopCheckbox.Checked;
        }

        private void distanceInput_ValueChanged(object sender, EventArgs e)
        {
            elevationInput.Value = Converter.ConvertDistanceToElevation(distanceInput.Value);
        }

        private void ReceiveNumpadDigit(int digit)
        {
            if (ActiveForm == this)
            {
                return;
            }

            if (DateTime.Now - LastNumpadInputAt > TimeSpan.FromSeconds(1))
            {
                distanceInput.Value = digit;
            }
            else
            {
                var newStringValue = distanceInput.Value.ToString() + digit;
                if (decimal.TryParse(newStringValue, out var newValue))
                {
                    distanceInput.Value = newValue;
                }
            }

            LastNumpadInputAt = DateTime.Now;
        }

        private void clickTimerUpdateTimer_Tick(object sender, EventArgs e)
        {
            var hitTimePrediction = TimingCalculator.PredictHitTime(LastClickAt);
            var timeUntilHit = hitTimePrediction - DateTime.Now;
            var remainingSeconds = Math.Round(timeUntilHit.TotalSeconds);

            if (remainingSeconds < 0)
            {
                lastHitCountdownLabel.Text = "";
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

        private void transparentCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TransparencyManager.EnableTransparency = transparentCheckbox.Checked;
        }

        private void CalculatorForm_Activated(object sender, EventArgs e)
        {
            if (transparentCheckbox.Checked)
                transparentCheckbox.Checked = false;
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
                    Converter = new RusDistanceElevationConverter();
                    break;
                case "British":
                    Converter = new BritishDistanceElevationConverter();
                    break;
            }
            distanceInput_ValueChanged(sender, e);
        }
    }
}
