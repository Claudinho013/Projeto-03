using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solucao02
{
    class Triangulo
    {
        private String b;
        private String h;

        public void setB(String _b) { b = _b; }
        public void setH(String _h) { h = _h; }
        public String getB() { return b; }
        public String getH() { return h; }
        public String getArea() { return (float.Parse(b) * float.Parse(h) / 2).ToString(); }
    }
}
