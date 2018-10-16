using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSequence2 : MonoBehaviour
{
public string anim;
public Animator biwibox;
public Animator biwitext;
public Animator biwipic;
public Animator Text7;
public GameObject damn;
public string biwiboxi;
public string biwitexti;
public string biwipici;
public string text07;
bool WaitEnd = false;



// Use this for initialization
void Update()
{
    if (damn.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName(anim))
    {
        StartCoroutine(Wait());

        if (WaitEnd)
        {
            StopAllCoroutines();
            biwibox.SetBool(biwiboxi, false);
            biwitext.SetBool(biwitexti, false);
            biwipic.SetBool(biwipici, false);
            Text7.SetBool(text07, false);
               
        }



    }
}


IEnumerator Wait()
{

    yield return new WaitForSeconds(2);
    biwibox.SetBool(biwiboxi, true);
    biwitext.SetBool(biwitexti, true);
    biwipic.SetBool(biwipici, true);
    Text7.SetBool(text07, true);
    yield return new WaitForSeconds(1);
    WaitEnd = true;


}
}