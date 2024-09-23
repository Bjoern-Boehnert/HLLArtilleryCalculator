
namespace HLLArtilleryCalculator
{
    internal record ConversionEntry(int Meters, int Mils)
    {
        public override string ToString()
        {
            return $"{Meters}M, {Mils}mil";
        }
    }
    internal class ConversionHistory
    {
        private int size;
        private ConversionEntry[] history;
        private int index = 0;
        private int count = 0;

        public ConversionHistory(int size = 1)
        {
            this.size = size;
            this.history = new ConversionEntry[size];
        }

        internal void AddEntry(int meters, int mils)
        {
            var entry = new ConversionEntry(meters, mils);

            history[index] = entry;
            index = (index + 1) % size;
            count = Math.Min(count + 1, size);
        }

        internal ConversionEntry[] GetHistory()
        {
            return history;
        }

        internal ConversionEntry GetLatestEntry() 
        {
            if (count == 0)
            {
                throw new InvalidOperationException("No entries in history.");
            }
            int latestIndex = index == 0 ? size - 1 : index - 1;
            return history[latestIndex];
        }
    }
}