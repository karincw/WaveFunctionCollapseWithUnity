using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karin.WaveFunction
{
    public class Cell : MonoBehaviour
    {
        public bool collapsed;
        public Tile[] tileOptions;

        public void CreateCell(bool collapsedState, Tile[] tiles)
        {
            collapsed = collapsedState;
            tileOptions = tiles;
        }

        public void ReCreateCell(Tile[] tiles)
        {
            tileOptions = tiles;
        }
    }
}
