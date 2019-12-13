using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_testowy
{
    enum charClass
    {
        warrior,
        mage,
        archer
    }
    enum ClassDamage
    {
        pierwszy = 1,
        drugi = 2,
        trzeci = 3
    }

    class Character
    {
        public double posx;
        public double posy;
        public int level;
        public string nick;
        public charClass klasa;
        //public readonly charClass CharClass;

        public Character(double posx, double posy, int level, string nick, charClass klasa)
        {
            this.posx = posx;
            this.posy = posy;
            this.level = level;
            this.nick = nick;
            this.klasa = klasa;

        }
        private Character()
        {

        }
        public static Character generate(double posx, double posy, int level, string nick, charClass klasa) 
        { 
            return new Character(posx, posy, level, nick, klasa); 
        }
        public void action()
        {
            Console.WriteLine("{0} chodzi", nick);
        }

    }
}
