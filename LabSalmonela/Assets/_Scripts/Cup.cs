using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Physics.IgnoreLayerCollision(0, 11);
    }

}
