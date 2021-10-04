using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] InitialItems;
    public GameObject[] InitialItemsCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialItemsGrab(int a){
        InitialItemsCheck[a].SetActive(true);
        Destroy(InitialItems[a]);
    }
}
