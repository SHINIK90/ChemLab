using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaEnriquecida : MonoBehaviour
{
    public GameObject agua;
    public GameObject pesoagua;
    float mult = 0;
    float Val = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Val += mult * Time.deltaTime;
        agua.transform.localScale = new Vector3(0.007464302f, Val, 0.0074643f);
        

        if (Val >= 0.01)
        {
            pesoagua.SetActive(true);
            mult = 0;
            Val = 0.01f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "envase")
        {
            
            Debug.Log("Tocando envase");
            mult = 0.002f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "envase")
        {
            mult = 0;
        }
    }
}
