using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incubar : MonoBehaviour
{
    public Animator m_Animator;
    public bool TieneEnvase = false;
    public GameObject cerrar;
    public int count = 0;

    private void OnTriggerEnter(Collider other)
    {    
        Debug.Log(other.tag);
        if (other.tag == "envase")
        {
            //Debug.Log("Oe serrano bobo");
            TieneEnvase = true;
            cerrar.SetActive(true);
        }
        if (other.tag == "Entrar" && TieneEnvase == true)
        {
            m_Animator.SetTrigger("Active");
            Destroy(cerrar, 0.01f);
            count = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {  
        if (other.tag == "envase")
        {
            cerrar.SetActive(false);
            TieneEnvase = false;
        }
      
    }
}
