using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public int x {  get; set; }
        public int y { get; set; }
        public string color { get; set; }

        public Shape()
        {

        }
        public Shape (Shape source)
        {
            this.x = source.x;
            this.y = source.y;
            this.color = source.color;
        }

        public abstract Shape Clone ();
    }
}
