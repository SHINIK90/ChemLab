using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detergente : MonoBehaviour
{
    public GameObject tipod;
    public GameObject Water;
    public Material AguaConDetergente;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Det")
        {
            tipod.SetActive(true);
        }
        if (other.tag == "agua")
        {
            Renderer matt = Water.GetComponent<Renderer>();
            matt.material = AguaConDetergente;
            tipod.SetActive(false);
        }
    }
}
