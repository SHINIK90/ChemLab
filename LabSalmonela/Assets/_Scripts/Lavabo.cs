using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class Lavabo : MonoBehaviour
{

    public GameObject knob;
    public GameObject agua;
    float y= 0;
    float Val;

    // Update is called once per frame
    void Update()
    {

        float Ang = knob.transform.eulerAngles.y;
        Debug.Log(Ang);
        if (Ang < 90)
        {
            Ang = 90.0f;
        }
        if (Ang > 180.0f)
        {
            Ang = 180;
        }
        if(Ang>=91 && Ang < 180)
        {
            
            Val = y += 0.03f * Time.deltaTime;
            agua.transform.localScale = new Vector3(0.5f, Val, 0.5f);
        }
    }
}
