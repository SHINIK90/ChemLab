using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class Mechero : MonoBehaviour
{

    public GameObject knob;
    public GameObject flame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float r = ((knob.transform.eulerAngles.y)/240f);
        //Debug.Log(r);
        // if(r > 1){
        //     r = 1;
        // }
        Vector3 ScaleChange = new Vector3(0.1655972f * r, 0.59744f * r, 0.1655972f * r);
        flame.transform.localScale = ScaleChange;

        if(r < 0.1f){
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other) {
        if(other.tag == "Mechero" && InputBridge.Instance.LeftTriggerDown){
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
        if(other.tag == "Mechero" && InputBridge.Instance.RightTriggerDown){
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
