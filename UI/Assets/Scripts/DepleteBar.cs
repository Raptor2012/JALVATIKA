using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepleteBar : MonoBehaviour {

    public Animator Round;
    public Animator Round1;
    public Animator Round2;
    public Animator Round3;
    public Animator Round4;
    public Animator Round5;
    public Animator Round6;
    public Animator Round7;
    public Animator Round8;
    public Animator Round9;
    public Animator Round10;
    public Animator Star;
    public Animator StarText;
    public string Starti;
    public string StartiText;
    public GameObject Dots;
    public GameObject Button;


    public string Rounded;
    



    public void Onclik() {

        BarScript.Amount -= 0.3f;
       	}
    

    void Update()
    {

        if (BarScript.Amount <= 95f)
        {

            Round.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 90f)
        {

            Round1.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 85f)
        {

            Round2.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 75f)
        {

            Round3.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 65f)
        {

            Round4.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 55f)
        {

            Round5.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 45f)
        {

            Round6.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 35f)
        {

            Round7.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 30f)
        {

            Round8.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 20f)
        {

            Round9.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 10f)
        {

            Round10.SetBool(Rounded, true);
        }

        if (BarScript.Amount <= 0f)
        {
            Destroy(Dots);
            Destroy(Button);
            Star.SetBool(Starti, true);
            StarText.SetBool(StartiText, true);

        }

    }
   }
