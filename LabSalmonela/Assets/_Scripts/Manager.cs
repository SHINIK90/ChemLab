using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public GameObject[] outlines1;
    public GameObject[] outlines2;
    public GameObject[] outlines3;
    public GameObject[] outlines4;
    public GameObject[] outlines5;
    public GameObject[] outlines6;
    public GameObject[][] outlines = new GameObject[8][];
    public GameObject[] InitialItems;
    public GameObject[] InitialItemsCheck;
    public GameObject[] InitialItemsCheckTask;
    private int InitialItemsCounter = 0;
    int currentPaso = 0;
    public GameObject Stains;
    public GameObject WBStainsText;
    public GameObject BunsenFire;
    public GameObject detergent;
    public GameObject balanza;
    public GameObject UVLight;
    public GameObject completedText;
    public GameObject[] TMPasos;
    public GameObject[] WBPasos;
    public GameObject WBCompleted;
    public Incubar incubadora;
    
    private void Awake() {
        outlines[0] = outlines1;
        outlines[1] = outlines2;
        outlines[2] = outlines3;
        outlines[3] = outlines4;
        outlines[4] = outlines5;
        outlines[5] = outlines6;

        for(int i = 1; i < 6; i++){
            updateOutlines(i,false);
        }
    }
    private void Update() {
        stepStatus();
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
    public void Bunsen(float a){
        //Debug.Log(a);
    }
    void Completed(){
        int c = currentPaso;
        completedText.GetComponent<TextMeshProUGUI>().text = "Completado\n" + currentPaso + "/9";
        WBCompleted.SetActive(true);
        WBPasos[c-1].SetActive(false);
        TMPasos[c-1].SetActive(false);
        TMPasos[c].SetActive(true);
    }
    void StartStep(){
        int c = currentPaso;
        WBCompleted.SetActive(false);
        WBPasos[c].SetActive(true);
    }
    void stepFinished(){
        currentPaso++;
        Invoke("Completed", 1f);
        Invoke("StartStep", 3f);
        updateOutlines(currentPaso, true);
        updateOutlines(currentPaso - 1, false);
    }
    void stepStatus(){
        switch (currentPaso+1){
            case 1:
                if(InitialItemsCounter == 3){stepFinished();}
                break;
            case 2:
                if(stainCleaned() == 0){stepFinished();}
                break;
            case 3:
                if(BunsenFire.activeSelf){stepFinished();}
                break;
            case 4:
                if(detergent.GetComponent<Detergente>().hasDetergent){stepFinished();}
                break;
            case 5:
                if(balanza.GetComponent<TextMeshProUGUI>().text == "250.0 G"){stepFinished();}
                break;
            case 6:
                if(incubadora.count == 1) { stepFinished(); }
                break;
            default:
                break;
        }
    }
    public void UV(){
        UVLight.SetActive(!UVLight.activeSelf);
    }
    void updateOutlines(int a, bool b)
    {
        for(int i = 0; i<outlines[a].Length; i++){
            outlines[a][i].GetComponent<Outline>().enabled = b;
        }
        
    }
}
