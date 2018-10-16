using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {


    
    public float RotateSpeed = 2.5f;
    public Transform target;
    private Vector3 zAxis = new Vector3(0, 0, -1); 

	

	void Update () {

        this.transform.RotateAround(target.position, zAxis, RotateSpeed);
		
	}
}
