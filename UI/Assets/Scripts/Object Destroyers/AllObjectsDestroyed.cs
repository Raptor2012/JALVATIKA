using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllObjectsDestroyed : MonoBehaviour {
    public Animator Clear;
    public string Cleared;
    public Animator Pond;
    public string PondCleared;


    void Update () {
        var dirts = GameObject.FindGameObjectsWithTag("DIRT");
        if (dirts.Length == 0)
        {
            Clear.SetBool(Cleared, true);
            Pond.SetBool(PondCleared, true);
        }
    }
}
