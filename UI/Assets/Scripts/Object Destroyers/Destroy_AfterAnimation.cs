using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_AfterAnimation : MonoBehaviour {
    public float delay = 0f;
    public string anim;
  

    // Use this for initialization
    void Update() {
        if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName(anim)) { 

            Destroy(gameObject, this.GetComponent<Animator>().GetNextAnimatorStateInfo(0).length + delay);


        }
    }

}
