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

        /// <summary>
        /// Constructeur principal (initialise un point avec les coordonnées en paramètre)
        /// </summary>
        /// <param name="_x">Coordonnée X du point</param>
        /// <param name="_y">Coordonnée Y du point</param>
        public Point(float _x, float _y)
        {
            this.x = _x;
            this.y = _y;
        }

        /// <summary>
        /// Constructeur par défaut (initialise un point en (0, 0))
        /// </summary>
        public Point() : this(0, 0)
        {
        }

        /// <summary>
        /// Constructeur par clonage (crée un nouveau point en copiant un point existant)
        /// </summary>
        /// <param name="_pointARecopier"></param>
        public Point(Point _pointARecopier)
        {
            this.x = _pointARecopier.x;
            this.y = _pointARecopier.y;
        }

        /// <summary>
        /// Déplace le point vers de nouvelles coordonnées (précisé en paramètre)
        /// </summary>
        /// <param name="nouveauX"></param>
        /// <param name="nouveauY"></param>
        public void Deplacer(float nouveauX, float nouveauY)
        {
            this.x = nouveauX;
            this.y = nouveauY;
        }

        /// <summary>
        /// Calcule et retourne le point symétrique par rapport à l'axe X.
        /// </summary>
        public Point SymetrieX()
        {
            Point pointSymetrieX = new(this.x, -(this.y));
            return pointSymetrieX;
        }

        /// <summary>
        /// Calcule et retourne le point symétrique par rapport à l'axe Y.
        /// </summary>
        public Point SymetrieY()
        {
            Point pointSymetrieY = new(-(this.x), this.y);
            return pointSymetrieY;
        }

        /// <summary>
        /// Calcule et retourne le point symétrique par rapport à l'origine (symétrie par rapport aux deux axes).
        /// </summary>
        public Point SymetrieXY()
        {
            float nouveauX = SymetrieY().x;
            float nouveauY = SymetrieX().y;
            Point pointSymetriePoint = new Point(nouveauX, nouveauY);
            return pointSymetriePoint;
        }

        /// <summary>
        /// Permute les coordonnées X et Y du point.
        /// </summary>
        public void Permuter()
        {
            float z = this.x;
            this.x = this.y;
            this.y = z;
        }

        public override string ToString()
        {
            return base.ToString() + "; x = " + this.x + "; y = " + this.y;
        }

    }
}
