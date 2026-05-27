using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3C.Cafeteria.Cafetria
{
    internal class BebidasFrias : Bebidas
    {
        private float CantidadHielo;

        public float cantidadhielo
        {
            get { return CantidadHielo; }
            set {  CantidadHielo = value;}
        }


    }
}
