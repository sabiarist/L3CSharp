using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCargaison.dao;
using TPCargaison.models;

namespace TPCargaison.services
{
    class CargaisonService
    {
        private DaoCargaison daoCarg;

        public CargaisonService()
        {
            daoCarg = new DaoCargaison();
        }

        public bool addCargaison(Cargaison cargaison)
        {
            daoCarg.add(cargaison);
            return true;
        }

        public List<Cargaison> listCargaison()
        {
            return daoCarg.getAll();
        }
    }
}
