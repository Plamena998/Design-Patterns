using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public int radius {  get; set; }

        public Circle()
        {

        }

        public Circle(Circle source): base(source)
        {
            this.radius = source.radius;
        }

        public override Shape Clone()
        {
            return  new Circle(this);
        }

        public override string ToString()
        {
           return $"Кръг [X:{x}, Y:{y}, Цвят:{color}, Радиус:{radius}]";
        }
    }
}
