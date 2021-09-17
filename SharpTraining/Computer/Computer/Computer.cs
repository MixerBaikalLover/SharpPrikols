namespace Computer
{
    public class Computer
    {
        internal CPU cpu { get; set; }
        internal GPU gpu  { get; set; }
        internal Memory[] memoriesBlocks  { get; set; }

        public Computer(CPU cpu, GPU gpu, Memory[] memoriesBlocks)
        {
            this.cpu = cpu;
            this.gpu = gpu;
            this.memoriesBlocks = memoriesBlocks;
        }

        public void Deconstruct(out CPU cpu, out GPU gpu, out Memory[] memoriesBlocks)
        {
            cpu = this.cpu;
            gpu = this.gpu;
            memoriesBlocks = this.memoriesBlocks;
        }

        public double getRating()
        {
            double res = cpu.maxFreq * 0.95 * cpu.cores + gpu.memory * 0.2;
            if (gpu.rtx)
            {
                res++;
            }

            return res;
        }
    }
}