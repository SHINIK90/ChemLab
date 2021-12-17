using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void quitApp(){
        Application.Quit();
    }
    public void changeScene(string i){
        SceneManager.LoadScene(i);
    }
}
