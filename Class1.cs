using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario
{
    public class Planetario
    {
        public List <Pianeta> Pianeti = new List<Pianeta> ();
        public double G { get; set; }
        public double Timer { get; set; } = 0.001;
    }
}
