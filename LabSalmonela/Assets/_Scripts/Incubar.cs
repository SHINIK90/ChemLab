using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incubar : MonoBehaviour
{
    public Animator m_Animator;
    public bool TieneEnvase = false;
    public GameObject cerrar;

    private void OnTriggerEnter(Collider other)
    {    
        Debug.Log(other.tag);
        if (other.tag == "envase")
        {
            TieneEnvase = true;
            cerrar.SetActive(true);
        }
        else
        {
            TieneEnvase = false;
            cerrar.SetActive(false);
        }
        if (other.tag == "Entrar" && TieneEnvase == true)
        {
            // Debug.Log("Oe serrano bobo");
            m_Animator.SetTrigger("Active");
        }
    }
    private void OnTriggerExit(Collider other)
    {  
        if (other.tag == "envase")
        {
            TieneEnvase = false;
        }
      
    }
}
