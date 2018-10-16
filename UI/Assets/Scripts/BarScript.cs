using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class BarScript : MonoBehaviour {
    
    Image Bar;
    public float maxAmount = 100f;
    public static float Amount;

	
	void Start () {

        Bar = GetComponent<Image>();
        Amount = maxAmount;
    		
	}
	
	
	void Update () {

        Bar.fillAmount = Amount / maxAmount;
    }
}
