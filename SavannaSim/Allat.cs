using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavannaSim
{
    abstract class Allat
    {
        private int _eletkor = 0;

        // TODO Max eletkor?
        public int Eletkor { 
            get => _eletkor; set 
            { 
                if (value < 0 || value > 1000 ) 
                {
                    throw new Exception("nem megfelelo eletkor"); 
                }
                _eletkor = value; 
            } 
        }
        abstract public int MaxEletkor { get; protected set; } 
        private int _ehseg;
        public int Ehseg { get => _ehseg; set 
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("nem megfelelo ehseg szint");
                }
                _ehseg = value;
            } 
        }
        private bool _el = true;
        public bool El
        {
            get => _el; set
            {
                if (_el is false)
                {
                    throw new Exception("nem lehet feleleszteni");
                }
                _el = value;
            } 
        } 

        protected Szavanna Szavanna { get; set; }

        protected int evMulvaTudSzaporodni = 0;
        public void Oregszik()
        {
            Eletkor++;
            if (evMulvaTudSzaporodni != 0)
            {
                evMulvaTudSzaporodni--;
            }
            if (Eletkor >= MaxEletkor) 
            {
                El = false;
            }
        }

        abstract public Allat Szaporodik();


        abstract public void Eszik();

        // TODO: ???
        public void Mozog()
        {
            throw new NotImplementedException();
        }


    }
}
