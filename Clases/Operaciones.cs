using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator.Clases
{
    public class Operaciones
    {
        private float numero1 = 0;
        private float numero2 = 0;

        public Operaciones(float _numero1, float _numero2)
        {
            numero1 = _numero1;
            numero2 = _numero2;
        }
        public Operaciones()
        {

        }

        public float Resta(float _numero1, float _numero2)
        {
            return _numero1 - _numero2;
        }

        public float Suma(float _numero1, float _numero2)
        {
            return _numero1 + _numero2;
        }

        public float Multiplicacion(float _numero1, float _numero2)
        {
            return _numero1 * _numero2;
        }

        public float Division(float _numero1, float _numero2)
        {
            return _numero1 / _numero2;
        }

        public double ReglaSimple(double _a, double _b, double _c)
        {
            return (_a * _b) / _c ;
        }
    }
}
