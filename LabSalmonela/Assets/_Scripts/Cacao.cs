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
    public GameObject Cacao4;
    public GameObject Cacao5;
    int cont;
    bool TieneCacao;
    void Start()
    {
        cont = 0;
        TieneCacao=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 6)
        {
            cont = 5;
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
        if(cont == 4)
        {
            Cacao4.SetActive(true);
        }
        if(cont == 5)
        {
            Cacao5.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Funda")
        {
            TieneCacao = true;
            GC.SetActive(true);
        }
        if (other.tag == "envase" && TieneCacao == true)
        {
            GC.SetActive(false);
            cont+=1;
            TieneCacao = false;

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
