using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public GameObject[] InitialItems;
    public GameObject[] InitialItemsCheck;
    public GameObject[] InitialItemsCheckTask;
    public GameObject InitialItemsCheckImgs;
    public int InitialItemsCounter = 0;
    int currentPaso = 1;
    public GameObject Stains;
    public GameObject WBStainsText;
    public GameObject UVLight;
    public GameObject completedText;
    public GameObject TMPaso1;
    public GameObject TMPaso2;
    public GameObject TMPaso3;
    public GameObject WBPaso1;
    public GameObject WBPaso2;
    public GameObject WBPaso3;


    private void Update() {
        if(InitialItemsCounter == 3){
            Invoke("Completed1", 1f);
            Invoke("Start2", 3f);
        }
        if(stainCleaned() == 0){
            currentPaso = 2;
            Invoke("Completed", 1f);
            Invoke("Start3", 3f);
        }
    }    


    public void InitialItemsGrab(int a){
        InitialItemsCheck[a].SetActive(true);
        InitialItemsCheckTask[a].SetActive(true);
        Destroy(InitialItems[a]);
        InitialItemsCounter++;
    }
    public int stainCleaned(){
        int left = Stains.transform.childCount;
        WBStainsText.GetComponent<TextMeshProUGUI>().text = "Manchas Restantes:\n" + left + "/3";
        return left;
    }
    public void Completed1(){
        Destroy(InitialItemsCheckImgs);
        WBPaso1.SetActive(true);
        TMPaso1.SetActive(false);
        TMPaso2.SetActive(true);
    }
    public void Start2(){
        WBPaso1.SetActive(false);
        WBPaso2.SetActive(true);
    }
    public void Start3(){
        WBPaso1.SetActive(false);
        WBPaso2.SetActive(false);
        WBPaso3.SetActive(true);
    }
    public void Bunsen(float a){
        //Debug.Log(a);
    }

    public void UV(){
        UVLight.SetActive(!UVLight.activeSelf);
    }
    void completed(){
        completedText.GetComponent<TextMeshProUGUI>().text = "Completado " + currentPaso + "/9";
        WBPaso1.SetActive(true);
    }
}
