using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectAnimation : MonoBehaviour
{
    public float delay = 0f;
    public string anim;
    public GameObject obj;
    public GameObject objDestroy;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (obj.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName(anim))
        {

            Destroy(objDestroy, obj.GetComponent<Animator>().GetNextAnimatorStateInfo(0).length + delay);

        }
    }
}