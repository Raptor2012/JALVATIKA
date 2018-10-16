using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllObjectsTiling : MonoBehaviour
{
    public GameObject GG;
   
    
    public void Destroying()
    {
        Destroy(GG);
    }

   
}
