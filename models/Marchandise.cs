using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCargaison.models
{
    class Marchandise
    {
        private int numero;
        private double poid;
        private double volume;

        //Many To One => Attribut de navigation
        private Cargaison cargaison;

        public int Numero { get => numero; set => numero = value; }
        public double Poid { get => poid; set => poid = value; }
        public double Volume { get => volume; set => volume = value; }
        public Cargaison Cargaison { get => cargaison; }
    }
}
