using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incubar : MonoBehaviour
{
    public Animator m_Animator;
    public bool TieneEnvase = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "envase")
        {
            TieneEnvase = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {  
        if (other.tag == "envase")
        {
            TieneEnvase = false;
        }
        if (other.tag == "Entrar" && TieneEnvase == true)
        {
            Debug.Log("Oe serrano bobo");
            m_Animator.SetTrigger("Active");
        }
      
    }
}
