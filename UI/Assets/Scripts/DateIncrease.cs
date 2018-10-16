using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateIncrease : MonoBehaviour {

    public Text myText;
    public Animator Dates;
    public Animator Next;
    public string Nexti;
    public string Nextii;
    public string datei;
    bool End = true;

    void Start () {

        if (End) { 

            StartCoroutine(Date());
        }
    }
	
    IEnumerator Date()
    {
        myText.text = "3rd JUNE"; 
        yield return new WaitForSeconds(0.7f);
        myText.text = "4th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "5th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "6th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "7th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "8th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "9th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(0.7f);
        myText.text = "10th JUNE";
        myText.fontSize = 75;
        yield return new WaitForSeconds(0.2f);
        myText.fontSize = 55;
        yield return new WaitForSeconds(5);
        Dates.SetBool(datei, true);
        Next.SetBool(Nexti, true);
        yield return new WaitForSeconds(0.3f);
        Next.SetBool(Nextii, true);
        yield return new WaitForSeconds(0.3f);
        End = false;


    }
    
	}
