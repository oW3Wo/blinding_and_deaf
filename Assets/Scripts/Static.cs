using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public static class Static {

    public struct BuildingPos
    {
        float bottomleft;
        float topright;
    }

    public enum BuildBl { player1,player2,none};
    public enum Belong { player1, player2, none };

    public static BuildingPos b1, b2, b3, b4, b5, b6;
}
