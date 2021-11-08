using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] InitialItems;
    public GameObject[] InitialItemsCheck;
    public GameObject UVLight;
    

    public void InitialItemsGrab(int a){
        InitialItemsCheck[a].SetActive(true);
        Destroy(InitialItems[a]);
    }

    public void Bunsen(float a){
        //Debug.Log(a);
    }

    public void UV(){
        UVLight.SetActive(!UVLight.activeSelf);
    }
}
