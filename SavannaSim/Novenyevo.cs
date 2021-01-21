using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavannaSim
{
    class Novenyevo : Allat
    {
        private int _maxEletkor;

        public override int MaxEletkor { 
            get => _maxEletkor;
            protected set
            {
                if (value > 14)
                {
                    throw new Exception("nem megfelelo max eletkor");
                }
                _maxEletkor = value;
            }
        }

        public override void Eszik()
        {

        }

        public override Allat Szaporodik()
        {
            // List<Allat> kornyezoAllatok = Szavanna.KornyezoAllatok(this);

            if (evMulvaTudSzaporodni != 0)
            {
                return null;
            }

            var ujEgyed = new Novenyevo();
            this.evMulvaTudSzaporodni = 2;

        }


    }
}
