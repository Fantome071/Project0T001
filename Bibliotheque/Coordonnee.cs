using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Coordonnee
    {
        public int _x { get; set; }
        public int _y { get; set; }

        public Coordonnee(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetCoordonnee(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetNull()
        {
            _x = 0;
            _y = 0;
        }
    }
}
