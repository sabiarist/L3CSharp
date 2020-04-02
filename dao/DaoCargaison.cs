using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCargaison.models;

namespace TPCargaison.dao
{
    class DaoCargaison: ISystem<Cargaison>
    {
        private List<Cargaison> cargaison;

        public DaoCargaison()
        {
            cargaison.Add(new Aerienne()
            {
                Distance = 100000,
                PoidsTotal = 0,
                VolumeTotal = 0
            }
            );

            cargaison.Add(new Aerienne()
            {
                Distance = 70000,
                PoidsTotal = 0,
                VolumeTotal = 0
            }
            );
        }

        internal List<Cargaison> Cargaison { get => cargaison; set => cargaison = value; }

        public List<Cargaison> getAll()
        {
            return this.Cargaison;
        }

        public Cargaison getById(int id)
        {
            return null;
        }

        public bool add(Cargaison cargaison)
        {
            Cargaison.Add(cargaison);
            return true;
        }
    }
}
