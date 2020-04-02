using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCargaison.models
{
    class Routiere : Cargaison
    {
        public override double Cout
        {
            get
            {
                int Val;

                if (VolumeTotal < 380000)
                {
                    Val = 4;
                    return Val * Distance * PoidsTotal;
                }
                else
                {
                    Val = 6;
                    return Val * Distance * PoidsTotal;
                }

            }
        }

        public override string ToString()
        {
            return base.ToString() + " Cout: " + Cout;
        }
    }
}
