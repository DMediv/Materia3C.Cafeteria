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

        public BebidasFrias(string _nombre, string _tamaño, float _precio, float _cantidadhielo) : base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadhielo;
        }

        public override string Preparar()
        {
            return "preparando un : " + nombre + "helado (con " + cantidadhielo + " cubos de hielo) de tamaño " + tamaño;
        }


    }
}
