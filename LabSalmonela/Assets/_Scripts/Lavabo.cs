using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class Lavabo : MonoBehaviour
{

    public GameObject knob;
    public GameObject agua;
    int mult = 0;
    float Val= 0;

    // Update is called once per frame
    void Update()
    {

        float Ang = knob.transform.eulerAngles.y;
       // Debug.Log(Ang);
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
            
            Val += mult * Time.deltaTime;
            agua.transform.localScale = new Vector3(1.066666f, Val, 1.066666f);
        }
        if (Val >= 5){
            mult = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigg")
        {
            mult = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Trigg")
        {
            mult = 0;
        }
    }
}
