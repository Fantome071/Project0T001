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

        public TuilePiece[] _tuilePieceBleu { get; set; }
        public TuilePiece[] _tuilePieceRouge { get; set; }
        public TuilePiece[] _tuilePieceBlanc { get; set; }
        public TuilePiece[] _tuilePieceVert { get; set; }

        public Plateau()
        {
            _plateau = new TuilePiece[6, 6];

            _tuileFantome = new TuileFantome[4];

            Couleur[] totalCouleur = new Couleur[4];
            for (int i = 0; i < 4; i++)
            {
                totalCouleur[i] = new Couleur(i + 1);
                _tuileFantome[i] = new TuileFantome(totalCouleur[i]);
            }


            int[] valeurPiece = new int[9];
            for (int i = 0; i < 4; i++)
                valeurPiece[i] = 1000;
            for (int i = 2; i < 7; i++)
                valeurPiece[i + 2] = 1000 * i;

            _tuilePieceBleu = new TuilePiece[9];
            _tuilePieceRouge = new TuilePiece[9];
            _tuilePieceBlanc = new TuilePiece[9];
            _tuilePieceVert = new TuilePiece[9];

            for (int i = 0; i < 9; i++)
            {
                _tuilePieceBleu[i] = new TuilePiece(totalCouleur[0], valeurPiece[i]);
                _tuilePieceRouge[i] = new TuilePiece(totalCouleur[1], valeurPiece[i]);
                _tuilePieceBlanc[i] = new TuilePiece(totalCouleur[2], valeurPiece[i]);
                _tuilePieceVert[i] = new TuilePiece(totalCouleur[3], valeurPiece[i]);
            }
        }
    }
}
