using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class Lavabo : MonoBehaviour
{
    public GameObject knob;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Ang = (knob.transform.eulerAngles.x);
        Debug.Log(Ang);
        // if(r > 1){
        //     r = 1;
        // }
    }
}
