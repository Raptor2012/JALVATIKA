using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSequence3 : MonoBehaviour
{
    public string anim;
    public Animator kakabox;
    public Animator kakatext;
    public Animator kakapic;
    public Animator Text6;
    public GameObject GameObj;
    public string kakaboxi;
    public string kakatexti;
    public string kakapici;
    public string text06;
    bool WaitEnd = false;
    
    // Use this for initialization
    void FixedUpdate()
    {
        if (GameObj.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName(anim))
        {
            StartCoroutine(Wait());

            if (WaitEnd)
            {
                StopAllCoroutines();
                kakabox.SetBool(kakaboxi, false);
                kakatext.SetBool(kakatexti, false);
                kakapic.SetBool(kakapici, false);
                Text6.SetBool(text06, false);
            }
     }
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        kakabox.SetBool(kakaboxi, true);
        kakatext.SetBool(kakatexti, true);
        kakapic.SetBool(kakapici, true);
        Text6.SetBool(text06, true);
        yield return new WaitForSeconds(0.4f);
        WaitEnd = true;
   }
}