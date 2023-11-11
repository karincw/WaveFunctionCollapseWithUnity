using UnityEngine;

namespace Karin.WaveFunction
{
    public class Tile : MonoBehaviour
    {
        public Tile[] upNeighbours;
        public Tile[] rightNeighbours;
        public Tile[] downNeighbours;
        public Tile[] leftNeighbours;
    }

    public class Tile3D : MonoBehaviour
    {
        public Tile[] frontNeibours;
        public Tile[] backNeibours;
        public Tile[] leftNeibours;
        public Tile[] rightNeibours;
        public Tile[] upNeibours;
        public Tile[] downNeibours;
    }
}