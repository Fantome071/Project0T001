using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Plateau
    {
        public TuilePiece[,] _plateau { get; set; }
        public TuileFantome[] _tuileFantome { get; set; }

        public Plateau()
        {
            _plateau = new TuilePiece[6, 6];
            _tuileFantome = new TuileFantome[4];
        }
    }
}
