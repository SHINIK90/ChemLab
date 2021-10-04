using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] InitialItems;
    public GameObject[] InitialItemsCheck;
    

    public void InitialItemsGrab(int a){
        InitialItemsCheck[a].SetActive(true);
        Destroy(InitialItems[a]);
    }
}
