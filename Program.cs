using System;

namespace Lab8_1
{
    class Apple
    {
        public string Name { get; set; }
    }
    class Fruits
    {
        Apple[] data;

        public Fruits()
        {
            data = new Apple[6];
        }
        public Apple this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Fruits fruits = new Fruits();
            fruits[0] = new Apple() { Name = "x" };
            fruits[1] = new Apple() { Name = "y" };
            Apple y = fruits[1];
            Apple x = fruits[0];
            Console.WriteLine(y?.Name);
            Console.WriteLine(x?.Name);
            Console.ReadKey();
        }

    }
}
