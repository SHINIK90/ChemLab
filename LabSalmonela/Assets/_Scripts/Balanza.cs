using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balanza : MonoBehaviour
{
    private int totalWeight = 0;
    public GameObject outText;
    private void OnTriggerEnter(Collider other) {
        if(other.transform.GetComponent<WeightedOBJ>()){
            totalWeight += other.transform.GetComponent<WeightedOBJ>().weight;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.transform.GetComponent<WeightedOBJ>()){
            totalWeight -= other.transform.GetComponent<WeightedOBJ>().weight;
        }
    }
    void Update()
    {
        outText.transform.GetComponent<TMPro.TextMeshProUGUI>().text = totalWeight + ".0 G";
    }
}
