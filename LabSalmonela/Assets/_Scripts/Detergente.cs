using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detergente : MonoBehaviour
{
    public GameObject tipod;
    public GameObject Water;
    public Material AguaConDetergente;
    public bool hasDetergent = false;
    bool TieneTipod;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Det")
        {
            tipod.SetActive(true);
            TieneTipod = true;
        }
        if (other.tag == "agua" && TieneTipod == true)
        {
            Renderer matt = Water.GetComponent<Renderer>();
            matt.material = AguaConDetergente;
            tipod.SetActive(false);
            TieneTipod = false;
            hasDetergent = true;
        }
    }
}
