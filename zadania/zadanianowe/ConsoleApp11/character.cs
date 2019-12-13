using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    enum charClass { warrior, mage, archer}
    enum classDamage {pół, półtorej, jeden}
    class character
    {
        public double posx;
        public double posy;
        public int lvl;
        public string nick;
        public charClass klasa;
        private character()
        {

        }
        public character(double posx, double posy, int lvl, string nick, charClass klasa)
        {
            this.posx = posx;
            this.posy = posy;
            this.lvl = lvl;
            this.nick = nick;
            this.klasa = klasa;

        }
        public static character Generate(double posx, double posy, int lvl, string nick, charClass klasa)
        {
            return new character(posx, posy, lvl, nick, klasa);
        }

    }
}
