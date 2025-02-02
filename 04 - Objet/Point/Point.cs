using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point
    {
        float x;
        float y;

        public Point()
        {
            x = 5;
            y = 5;
        }
        public Point(float _x, float _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void afficher()
        {
            Console.WriteLine("x = " + this.x + ", y = " + this.y);
        }

        public void deplacer(float nouveauX, float nouveauY)
        {
            this.x = nouveauX;
            this.y = nouveauY;
        }

    }
}
