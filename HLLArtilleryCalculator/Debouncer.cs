namespace HLLArtilleryCalculator
{
    internal class Debouncer
    {
        private readonly System.Timers.Timer timer;
        private Action<int> onDebounce;
        private int pendingValue;

        public Debouncer(double interval)
        {
            timer = new System.Timers.Timer(interval);
            timer.AutoReset = false;
            timer.Elapsed += (sender, e) => OnTimerElapsed();
        }

        public void Debounce(int value, Action<int> callback)
        {
            pendingValue = value;
            onDebounce = callback;
            timer.Stop();
            timer.Start();
        }

        private void OnTimerElapsed()
        {
            onDebounce?.Invoke(pendingValue);
        }

        public void Dispose()
        {
            timer?.Dispose();
        }

    }
}
