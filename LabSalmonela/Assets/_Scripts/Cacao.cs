using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacao : MonoBehaviour
{
    public GameObject GC;
    public GameObject advertencia;
    public GameObject Cacao1;
    public GameObject Cacao2;
    public GameObject Cacao3;
    int cont;
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 4)
        {
            cont = 3;
            advertencia.SetActive(true);
        }
        if(cont == 1)
        {
            Cacao1.SetActive(true);
        }
        if (cont == 2)
        {
            Cacao2.SetActive(true);
        }
        if(cont == 3)
        {
            Cacao3.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Funda")
        {
            Debug.Log("SAQUENME DE LATINOAMERICA");
            GC.SetActive(true);
        }
        if (other.tag == "envase")
        {
            GC.SetActive(false);
            cont+=1;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "envase")
        {
            advertencia.SetActive(false);
        }
    }
}
