using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limpiar : MonoBehaviour
{
    int X;
   void Start()
    {
        X = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trapo")
        {
            X++;
            Debug.Log(X);
            if (X >= 3)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
