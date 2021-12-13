using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] InitialItems;
    public GameObject[] InitialItemsCheck;
    public GameObject[] InitialItemsCheckTask;
    public GameObject InitialItemsCheckImgs;
    public int InitialItemsCounter = 0;
    public GameObject UVLight;
    public GameObject TMPaso1;
    public GameObject TMPaso2;
    public GameObject WBPaso1;
    public GameObject WBPaso2;


    private void Update() {
        if(InitialItemsCounter == 3){
            Invoke("Completed1", 1f);
            Invoke("Start2", 3f);
        }
    }    


    public void InitialItemsGrab(int a){
        InitialItemsCheck[a].SetActive(true);
        InitialItemsCheckTask[a].SetActive(true);
        Destroy(InitialItems[a]);
        InitialItemsCounter++;
    }
    public void Completed1(){
        Destroy(InitialItemsCheckImgs);
        WBPaso1.SetActive(true);
        Destroy(TMPaso1);
        TMPaso2.SetActive(true);
    }
    public void Start2(){
        Destroy(WBPaso1);
        WBPaso2.SetActive(true);
    }

    public void Bunsen(float a){
        //Debug.Log(a);
    }

    public void UV(){
        UVLight.SetActive(!UVLight.activeSelf);
    }
}
