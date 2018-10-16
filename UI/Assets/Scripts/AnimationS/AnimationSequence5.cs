using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSequence5 : MonoBehaviour
{

    public string anim;
    public Animator dewaterpic;
    public Animator dewatertext;
    public Animator nextbutton;
    public GameObject GameObj;
    public string dewaterpici;
    public string dewatertexti;
    public string nextbuttoni;
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
                dewaterpic.SetBool(dewaterpici, false);
                dewatertext.SetBool(dewatertexti, false);
                nextbutton.SetBool(nextbuttoni, false);
            }
        }
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        dewaterpic.SetBool(dewaterpici, true);
        dewatertext.SetBool(dewatertexti, true);
        nextbutton.SetBool(nextbuttoni, true);
        yield return new WaitForSeconds(0.4f);
        WaitEnd = true;
    }
}