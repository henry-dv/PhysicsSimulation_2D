using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsSimulation_2D
{
    public class PhysicsObject : System.Windows.Controls.Control
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double VX { get; set; }
        public double VY { get; set; }
        public float Mass { get; private set; }

        public PhysicsObject(float mass, double x = 0, double y = 0)
        {
            this.Mass = mass;
            this.X = x;
            this.Y = y;
            this.VX = 0;
            this.VY = 0;
        }

        public void Move(float multiplier)
        {
            this.X *= this.VX * multiplier;
            this.Y *= this.VY * multiplier;
        }
    }
}
