namespace Computer
{
    public class CPU
    {
        internal string title { get; set; }
        internal int cores { get; set; }
        internal double minFreq { get; set; }
        internal double maxFreq { get; set; }

        public CPU(string title, int cores, double minFreq, double maxFreq)
        {
            this.title = title;
            this.cores = cores;
            this.minFreq = minFreq;
            this.maxFreq = maxFreq;
        }

        public void Deconstruct(out string title, out int cores, out double minFreq, out double maxFreq)
        {
            title = this.title;
            cores = this.cores;
            minFreq = this.minFreq;
            maxFreq = this.maxFreq;
        }
    }
}