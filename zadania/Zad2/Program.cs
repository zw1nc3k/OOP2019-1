using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
    class Character
    {
       public string nick;
        public Character(string nick)
        {
            this.nick = nick;
        }
       
        void action(string nick)
        {
            Console.WriteLine("{0} porusza sie normalnie", nick);
        }
    }
    class Warrior : Character
    {

        public Warrior(string nick) : base(nick)
        {
            this.nick = nick;
        }

        public void action(string nick)
        {
            Console.WriteLine("{0} porusza sie z mieczem", nick);
        }
    }
    class Mage : Character
    {
        public Mage(string nick) : base(nick)
        {
            this.nick = nick;
        }

        public new void action(string nick)
        {
            Console.WriteLine("{0} lata sobie", nick);
        }
    }
    class Archer : Character
    {
        public Archer(string nick) : base(nick)
        {
            this.nick = nick;
        }

        public void action(string nick)
        {
            Console.WriteLine("{0} biega z łukiem", nick);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Warrior wojownik = new Warrior("Kojownik");
            wojownik.action(wojownik.nick);
            Archer archer = new Archer("Wucznik");
            archer.action(archer.nick);
            Mage mag = new Mage("Zag");
            mag.action(mag.nick);

           List<Character> characters = new List<Character>();
            characters.Add(wojownik);
            characters.Add(archer);
            characters.Add(mag);
            characters.Add(new Character("Ctandardowy"));

           // Console.ReadKey();
               foreach(var character in characters)
               {
                  
               }

           characters.Sort((x, y) => string.Compare(x.nick, y.nick));
            foreach(var nick in characters)
            {
                Console.WriteLine(nick.nick);
            }
            Console.ReadKey();
        }
    }
}