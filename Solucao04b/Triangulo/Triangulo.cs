using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        private String b;
        private String h;

        public String B
        {
            get { return b; }
            set { b = value; }
        }
        public String H
        {
            get { return h; }
            set { h = value; }
        }
        public String getArea() { return (float.Parse(b) * float.Parse(h) / 2).ToString(); }
    }
}
