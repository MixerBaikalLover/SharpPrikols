namespace Computer
{
    public class Memory
    {
        internal double memory { get; set; }
        internal double freq { get; set; }

        public Memory(double memory, double freq)
        {
            this.memory = memory;
            this.freq = freq;
        }

        public void Deconstruct(out double memory, out double freq)
        {
            memory = this.memory;
            freq = this.freq;
        }
    }
}