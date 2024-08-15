using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niveis_de_acesso
{
    internal class Ponto
    {
        public double x;
        public double y;

        public Ponto(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        public double Distancia(Ponto p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y-p.y));
        }
    }
}
