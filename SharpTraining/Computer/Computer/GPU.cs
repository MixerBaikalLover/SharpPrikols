namespace Computer
{
    public class GPU
    {
        internal string title { get; set; }
        internal double memory { get; set; }
        internal bool rtx { get; set; }

        public GPU(string title, double memory, bool rtx)
        {
            this.title = title;
            this.memory = memory;
            this.rtx = rtx;
        }

        public void Deconstruct(out string title, out double memory, out bool rtx)
        {
            title = this.title;
            memory = this.memory;
            rtx = this.rtx;
        }
    }
}