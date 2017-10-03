
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

    public class RotateCylinder : MonoBehaviour {

    public float rotateSpeed;
    
    // Use this for initialization
    void Start () {

    }
    // Update is called once per frame
	void Update () {

        //transform.Rotate(0, 0, Time.deltaTime * rotateSpeed)
    }

    void FixedUpdate()
    {
        //
        //
        //
        //
        //Trying to call deltaYpostion variable from VRTK_MoveInPlace().CalculateListAverage()
        //Then apply that changing float value to rotateSpeed
        GameObject playArea = GameObject.Find("PlayArea");
        VRTK_MoveInPlace deltaY = GetComponent<VRTK_MoveInPlace>().CalculateListAverage();

        //VRTK_MoveInPlace moveCylinder = GetComponent<VRTK_MoveInPlace>();
        //ExposedReference
        
        //rotateSpeed = moveCylinder;
        transform.Rotate(0, 0, rotateSpeed);

    }
}

