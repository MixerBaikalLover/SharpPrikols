using System;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CPU cpu = new CPU("ryzen3600", 6 ,2.6, 4.1);
            GPU gpu = new GPU("RTX 3080", 16000, true);
            Memory mem = new Memory(8000, 3200);
            Memory mem1 = new Memory(8000, 3200);
            Computer comp = new Computer(cpu, gpu, new [] {mem, mem1});
            Console.Write("Your computer rating is " + comp.getRating());
        }
    }
}