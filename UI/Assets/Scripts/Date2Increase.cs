using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date2Increase : MonoBehaviour
{
    
    public Text myText;
    public Animator Dates;
    public Animator Next;
    public string Nexti;
    public string Nextii;
    public string datei;
    public Animator Black;
    public string blacki;
    bool End = true;
    

    void Start()
    {

        if (End)
        {

            StartCoroutine(Date());
        }
    }

    IEnumerator Date()
    {
        myText.text = "13th JUNE";
        yield return new WaitForSeconds(0.7f);
        myText.text = "14th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "15th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "16th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "17th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "18th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "19th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(4.5f);
        Dates.SetBool(datei, true);
        Next.SetBool(Nexti, true);
        Black.SetBool(blacki, true);
        yield return new WaitForSeconds(0.3f);
        Next.SetBool(Nextii, true);
        yield return new WaitForSeconds(0.3f);
        End = false;
        //
        yield return new WaitForSeconds(0.5f);
        myText.fontSize = 56;
        Black.SetBool(blacki, false);
        Next.SetBool(Nextii, false);
        yield return new WaitForSeconds(0.6f);

        
        
       
    }

}
