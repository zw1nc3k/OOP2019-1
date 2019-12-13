using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07
{
    class Kontrakt
    {
        internal enum _typKontraktu {staz, etat};
        public _typKontraktu typKontraktu;
        internal double _pensja;
        public int podstawaWynagrodzenia;

        public Kontrakt(int podstawaWynagrodzenia, _typKontraktu typKontraktu)
        {
            this.typKontraktu = typKontraktu;
            this.podstawaWynagrodzenia = podstawaWynagrodzenia;
        }
        public Kontrakt()
        {
            this.typKontraktu = _typKontraktu.staz;
            this.podstawaWynagrodzenia = 2000;
        }

        public double Pensja()
        {
            if (this.typKontraktu == _typKontraktu.staz)
            {
                this._pensja = 2000;
                return 2000;
            }
            else //if(this.typKontraktu == _typKontraktu.etat) => aktualnie nie ma innych kontraktów
            {
                this._pensja = this.podstawaWynagrodzenia;
                return this._pensja;
            }
        }
        public double Pensja(int iloscNadgodzin)
        {
            if (this.typKontraktu == _typKontraktu.staz)
            {
                this._pensja = 2000;
                return this._pensja;
            }
            else //if(this.typKontraktu == _typKontraktu.etat) => aktualnie nie ma innych kontraktów
            {
                this._pensja = this.podstawaWynagrodzenia + iloscNadgodzin * (this.podstawaWynagrodzenia / 160);
                return this._pensja;
            }
        }

    }
}
