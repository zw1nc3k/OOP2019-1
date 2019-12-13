using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa
{
    interface IMapa
    {
        // public void generate();
        // public void list();
        // public void show();

        void generate();
        void list();
        void show();
    }
    class Mapa : IMapa
    {
        public MapElement[,] data;

        public void generate()
        {
            int[] size = new int[2];

            bool error;

            do
            {
                error = false;

                Console.Write("Podaj wymiary mapy <x, y>: ");

                string[] input = Console.ReadLine().Split(',');

                if (input.Length != size.Length)
                    error = true;
                else
                    for (int i = 0; i < size.Length; i++)
                        if (!Int32.TryParse(input[i], out size[i]))
                            error = true;
                        else if (size[i] < 1 || size[i] > 10)
                            error = true;
            } while (error);

            this.data = new MapElement[size[0], size[1]];

            Random random = new Random();

            // I want to make sure that at least one grass field is generated

            for (int i = 0; i < size.Length; i++)
                size[i] = random.Next(0, this.data.GetLength(i) - 1);

            this.data[size[0], size[1]] = new Grass(size[0], size[1]);

            for (int i = 0; i < this.data.GetLength(0); i++)
            {
                for (int j = 0; j < this.data.GetLength(1); j++)
                {
                    if (i == size[0] && j == size[1])
                        continue;

                    int number = random.Next(0, 10);

                    if (number <= 1)
                        this.data[i, j] = new Rock(i, j);
                    else if (number <= 4)
                        this.data[i, j] = new Tree(i, j);
                    else
                        this.data[i, j] = new Grass(i, j);
                }
            }
        }

        public void list()
        {
            for (int i = 0; i < this.data.GetLength(0); i++)
                for (int j = 0; j < this.data.GetLength(1); j++)
                    this.data[i, j].print();
        }

        public void show()
        {
            for (int i = 0; i < this.data.GetLength(0); i++)
            {
                for (int j = 0; j < this.data.GetLength(1); j++)
                    Console.Write(this.data[i, j].icon);

                Console.WriteLine();
            }
        }
    }
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void print()
        {
            Console.WriteLine($"X: {this.x} Y: {this.y}");
        }
    }
    class MapElement : Point
    {
        public char icon { get; set; }

        public MapElement(int x, int y, char icon) : base(x, y)
        {
            this.icon = icon;
        }
    }
    class User : Point
    {
        public string name { get; set; }
        public int level { get; set; }

        public User(string name, int level, int x, int y) : base(x, y)
        {
            this.name = name;
            this.level = level;
        }

        public override void print()
        {
            Console.WriteLine($"[{this.name}, level {this.level}] X: {this.x} Y: {this.y}");
        }
    }
    class Rock : MapElement
    {
        public Rock(int x, int y) : base(x, y, 'R')
        {

        }

        public override void print()
        {
            Console.WriteLine($"[Rock] X: {this.x} Y: {this.y}");
        }
    }

    class Tree : MapElement
    {
        public Tree(int x, int y) : base(x, y, 'T')
        {

        }

        public override void print()
        {
            Console.WriteLine($"[Tree] X: {this.x} Y: {this.y}");
        }
    }
    class Grass : MapElement
    {
        public Grass(int x, int y) : base(x, y, 'G')
        {

        }

        public override void print()
        {
            Console.WriteLine($"[Grass] X: {this.x} Y: {this.y}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mapa map = new Mapa();

            map.generate();
            map.list();
            map.show();

            // random the player's position from all available grass fields on the map

            int x = 0, y = 0;

            Random random = new Random();

            for (int i = 0; i < map.data.GetLength(0); i++)
                for (int j = 0; j < map.data.GetLength(1); j++)
                    if (map.data[i, j] is Grass)
                    {
                        x = i;
                        y = j;

                        if (random.Next(0, 100) >= 60)
                            break;
                    }

            User user = new User("Player", 0, x, y);

            user.print();

            Console.ReadKey();
        }
    }
}
