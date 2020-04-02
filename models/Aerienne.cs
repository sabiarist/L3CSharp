using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCargaison.models
{
    class Aerienne : Cargaison
    {
        public override double Cout
        {
            get
            {
                int Val;

                if (VolumeTotal < 80000)
                {
                    Val = 10;
                    return Val * Distance * PoidsTotal;
                }
                else
                {
                    Val = 12;
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
