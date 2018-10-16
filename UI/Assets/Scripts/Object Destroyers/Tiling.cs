using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiling : MonoBehaviour
{
    public Animator Clear;
    public string Cleared;
    public Animator Pond;
    public string PondCleared;


    void Update()
    {
        var tiles = GameObject.FindGameObjectsWithTag("TILES");
        if (tiles.Length == 0)
        {
            Clear.SetBool(Cleared, true);
            Pond.SetBool(PondCleared, true);

        }
    }
}
